using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Windows.Forms;
using Gecko;
using System.IO;
using System.Runtime.InteropServices;
using System;

namespace GeckofxUnitTests
{
	[TestFixture]
	internal class DomWindowTests
	{
		private GeckoWebBrowser browser;
		private Gecko.WebIDL.Window _domWindow;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			browser = new GeckoWebBrowser();
			var unused = browser.Handle;
			Assert.IsNotNull(browser);

			LoadHtml("<div>hello world</div>");

			_domWindow = new Gecko.WebIDL.Window(browser.Window.DomWindow, (nsISupports)browser.Window.DomWindow);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			browser.Dispose();
		}

		/// <summary>
		/// Helper method to initalize a document with html and wait until document is ready.
		/// </summary>
		/// <param name="innerHtml"></param>
		internal void LoadHtml(string innerHtml)
		{
			LoadHtml(innerHtml, false);
		}

		/// <summary>
		/// Helper method to initalize a content editable document with html and wait until document is ready.
		/// </summary>
		/// <param name="innerHtml"></param>
		/// <param name="editable"></param>
		private void LoadHtml(string innerHtml, bool editable)
		{
			string contenteditable = editable ? "contenteditable=\"true\"" : string.Empty;
			browser.LoadHtml("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">"

							 + "<html xmlns=\"http://www.w3.org/1999/xhtml\" >"

							 + "<body " + contenteditable + ">" + innerHtml + "</body></html>");

			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
		}


		[Test]
		public void GetNavigatorAttribute_ReadOnlyDocument_ReturnsValidDomNaviagator()
		{       
			Assert.IsNotNull(_domWindow.Navigator);
		}

        [Test]
        public void ScrollMaxX()
        {

            Assert.LessOrEqual(_domWindow.ScrollMaxX, 50, "Expected 45 - but be flexable because of pixel pos");
            Assert.LessOrEqual(browser.Window.ScrollMaxX, 50, "Expected 45 - but be flexable because of pixel pos");            
        }

	    [Test]
	    public void ScrollMaxY()
	    {
	        Assert.LessOrEqual(_domWindow.ScrollMaxY, 60, "Expected 56 - but be flexable because of pixel pos");
            Assert.LessOrEqual(browser.Window.ScrollMaxY, 60, "Expected 56 - but be flexable because of pixel pos");
	    }

        [Test]
        public void ScrollMinX()
        {
            Assert.AreEqual(0, _domWindow.ScrollMinX);
            Assert.AreEqual(0, browser.Window.ScrollMinX);
        }

        [Test]
        public void ScrollMinY()
        {
            Assert.AreEqual(0, _domWindow.ScrollMinY);
            Assert.AreEqual(0, browser.Window.ScrollMinY);
        }

	    [Test]
	    public void MozPaintCount()
	    {
            Assert.AreEqual(0, _domWindow.MozPaintCount);
            Assert.AreEqual(0, browser.Window.MozPaintCount);
	    }

	    [Test]
	    public void Content_CanCastToWebBrowserPrintType()
	    {
	        var content = _domWindow.Content;
            Assert.NotNull(Xpcom.QueryInterface<nsIWebBrowserPrint>(content));

            content = browser.Window.Content;
            Assert.NotNull(Xpcom.QueryInterface<nsIWebBrowserPrint>(content));            
	    }

        [Ignore("Find always seems to show window even though I pass false as showDialog param.")]
	    [Test]
	    public void Find()
	    {
            Assert.IsFalse(browser.Window.Find("wordNotFound", false, false, true, false, true, false));            
	    }
        
	}
}

	