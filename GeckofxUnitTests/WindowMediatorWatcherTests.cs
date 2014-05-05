using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Windows.Forms;
using Gecko;
using System.IO;
using System.Runtime.InteropServices;
using Gecko.DOM;

namespace GeckofxUnitTests
{
	[TestFixture]
	internal class WindowMediatorWatcherTests
	{
		private GeckoWebBrowser browser1;
		private GeckoWebBrowser browser2;
		private string[] urls = {"http://localhost/1", "http://localhost/2"};
		private int wmWindowCount, wwWindowCount;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);

			var ws = WindowMediator.GetEnumerator(null);
			wmWindowCount = 0;
			while (ws.MoveNext())
				wmWindowCount++;

			ws = Gecko.Services.WindowWatcher.GetWindowEnumerator();
			wwWindowCount = 0;
			while (ws.MoveNext())
				wwWindowCount++;

			browser1 = new GeckoWebBrowser();
			var unused = browser1.Handle;
			browser2 = new GeckoWebBrowser();
			unused = browser2.Handle;
			Assert.IsNotNull(browser1);
			Assert.IsNotNull(browser2);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			browser1.Dispose();
			browser2.Dispose();
		}

		[Test]
		public void CheckGeckoWindowwwWindowCountLeak()
		{
			var msg = "Leaked gecko window(s) detected! Make sure Dispose() GeckoWebBrowser instances after you have done with them.";			
			Assert.AreEqual(0, wmWindowCount, msg);
			// "Xpcom.ChromeContext = new ChromeContext();" in XpCom.Initialize causes this to be 1
			Assert.AreEqual(1, wwWindowCount, msg);
		}

		[Test]
		public void WindowMediator_GetWindows()
		{
			browser1.LoadHtml("<p>1", urls[0]);
			browser1.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			browser2.LoadHtml("<p>2", urls[1]);
			browser2.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.AreEqual(urls[1], new GeckoWindow(WindowMediator.GetMostRecentWindow(null)).Document.Uri);
			var ws = WindowMediator.GetEnumerator(null);
			int i = 0;
			while (ws.MoveNext())
			{
				if (i >= wmWindowCount)
					Assert.AreEqual(urls[i - wmWindowCount], ws.Current.Document.Uri);
				i++;
			}
			Assert.AreEqual(urls.Length, i - wmWindowCount);
		}

		[Test]
		public void WindowWatcher_GetWindows()
		{
			browser1.LoadHtml("<p>1", urls[0]);
			browser1.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			browser2.LoadHtml("<p>2", urls[1]);
			browser2.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			var ws = Gecko.Services.WindowWatcher.GetWindowEnumerator();
			int i = 0;
			while (ws.MoveNext())
			{
				if (i >= wwWindowCount)
					Assert.AreEqual(urls[i - wwWindowCount], ws.Current.Document.Uri);
				i++;
			}
			Assert.AreEqual(urls.Length, i - wwWindowCount);
		}
	}
			
}