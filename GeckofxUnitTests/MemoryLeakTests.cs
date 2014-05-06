using System;
using System.Runtime.InteropServices;
using Gecko;
using NUnit.Framework;

namespace GeckofxUnitTests
{
	/// <summary>
	/// Memory leaks(yes!!!) tests
	/// </summary>
	[TestFixture]
	public class MemoryLeakTests
	{
		private GeckoWebBrowser browser;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			browser = new GeckoWebBrowser();
			var unused = browser.Handle;
			Assert.IsNotNull(browser);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			browser.Dispose();
		}


		/// <summary>
		/// Calculate RCW counter for browser Window
		/// </summary>
		/// <param name="browser"></param>
		/// <returns></returns>
		private int GetWindowRefCount( GeckoWebBrowser browser )
		{
			int ret = 0;
			nsIDOMWindow wnd = null;
			using ( var window = browser.Window )
			{
				wnd=Xpcom.QueryInterface<nsIDOMWindow>( window.DomWindow );
			}
			ret = Marshal.ReleaseComObject(wnd);
			return ret;
		}

		/// <summary>
		/// Calculate RCW counter for browser Document
		/// </summary>
		/// <param name="browser"></param>
		/// <returns></returns>
		private int GetDocumentRefCount(GeckoWebBrowser browser)
		{
			int ret = 0;
			nsIDOMDocument domDoc = null;
			using (var doc = browser.DomDocument)
			{
				domDoc = Xpcom.QueryInterface<nsIDOMDocument>(doc.NativeDomDocument);
			}
			ret = Marshal.ReleaseComObject(domDoc);
			return ret;
		}

		/// <summary>
		/// Test Freeing resources when DOM wrappers are freed by IDisposable::Dispose
		/// </summary>
		[Test]
		public void DomMemoryLeakTest_IDisposable()
		{
			int count;
			count = GetWindowRefCount( browser);
			browser.TestLoadHtml("");
			{
				GeckoHtmlElement element = browser.DomDocument.CreateHtmlElement("div");
				Assert.NotNull(element);
				Assert.AreEqual("div", element.TagName.ToLowerInvariant());
			}
			// wait for browser.DomDocument finalizer
			GC.Collect();
			GC.WaitForPendingFinalizers();

			for (int i = 0; i < 1000; i++)
			{
				using ( GeckoDomDocument document = browser.Document )
				{
					Func(document);
				}
			}
			count = GetDocumentRefCount(browser);
			//DomDocument can be 1 or 2
			Assert.Less( count,3 );
			Console.Error.WriteLine("nsIDOMDocument count was {0}", count);
			// wait for GeckoWindow finalizers
			GC.Collect();
			GC.WaitForPendingFinalizers();
			count = GetWindowRefCount( browser);
			Console.Error.WriteLine("nsIDOMWindow count was {0}", count);
			// DomWindow must be only one or none
			Assert.LessOrEqual( count,1);


		}

		/// <summary>
		/// Test Freeing resources when DOM wrappers are freed by Finalize (dtor)
		/// </summary>
		[Test]
		public void DomMemoryLeakTest_Finalize()
		{
			browser.TestLoadHtml("");
			{
				GeckoHtmlElement element = browser.DomDocument.CreateHtmlElement("div");
				Assert.NotNull(element);
				Assert.AreEqual("div", element.TagName.ToLowerInvariant());
			}
			// wait for browser.DomDocument finalizer
			GC.Collect();
			GC.WaitForPendingFinalizers();


			for (int i = 0; i < 1000; i++)
			{
				GeckoDomDocument document = browser.Document;
				Func(document);
			}

			GC.Collect();
			GC.WaitForPendingFinalizers();
			int count = GetDocumentRefCount(browser);
			Console.Error.WriteLine("nsIDOMDocument count was {0}", count);
			//DomDocument can be 1 or 2
			Assert.Less( count, 3 );
			count = GetWindowRefCount(browser);
			Console.Error.WriteLine("nsIDOMWindow count was {0}", count);
			// DomWindow must be only one
			Assert.LessOrEqual(  count,1);
		}

		private void Func(GeckoDomDocument doc)
		{

		}
	}

}