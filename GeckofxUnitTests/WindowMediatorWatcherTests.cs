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

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
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
				Assert.AreEqual(urls[i], ws.Current.Document.Uri);
				i++;
			}
			Assert.AreEqual(urls.Length, i);
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
				Assert.AreEqual(urls[i], ws.Current.Document.Uri);
				i++;
			}
			Assert.AreEqual(urls.Length, i);
		}
	}
			
}