using System.IO;
using NUnit.Framework;
using Skybound.Gecko;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class WebBrowserPersistTests
	{
		private GeckoWebBrowser _browser;
		private string _tempPath;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			_browser = new GeckoWebBrowser();
			var doingThisIsRequired = _browser.Handle;
			_tempPath = Path.GetTempFileName();
		}

		[TearDownAttribute]
		public void AfterEachTestTearDown()
		{
			_browser.Dispose();
			if(File.Exists(_tempPath))
				File.Delete(_tempPath);
		}

		[Test]
		public void SaveDocument_NewFile_Saves()
		{
			LoadHtml("abc");
			_browser.SaveDocument(_tempPath);
			Assert.IsTrue(File.Exists(_tempPath));
			Assert.IsTrue(File.ReadAllText(_tempPath).Contains("abc"));
		}

		[Test]
		public void SaveDocument_DirectoryDoesntExist_DirectoryNotFoundException()
		{
			LoadHtml("");
			Assert.Throws<DirectoryNotFoundException>(()=> _browser.SaveDocument("notthere/a.html"));
		}

		[Test]
		public void SaveDocument_FileLocked_IOException()
		{
			LoadHtml("");
			using (File.OpenWrite(_tempPath))
			{
				Assert.Throws<IOException>(() => _browser.SaveDocument(_tempPath));
			}
		}


		[Test]
		public void SaveDocument_DOMChanged_ChangesSaved()
		{
			LoadHtml("<p id='a'>original</p>");
			_browser.Document.GetElementById("a").TextContent = "changed";
			_browser.SaveDocument(_tempPath);
			Assert.IsTrue(File.Exists(_tempPath));
			Assert.IsTrue(File.ReadAllText(_tempPath).Contains("changed"));
		}

		private void LoadHtml(string bodyContents)
		{
			_browser.LoadHtml("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">"

			+ "<html xmlns=\"http://www.w3.org/1999/xhtml\" >"

			+ "<body>" + bodyContents + "</body></html>");

			_browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
		}
	}
}
