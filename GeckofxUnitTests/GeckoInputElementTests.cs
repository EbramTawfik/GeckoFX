using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.WebIDL;
using NUnit.Framework;
using System.Windows.Forms;
using Gecko;
using System.IO;
using System.Runtime.InteropServices;
using Gecko.DOM;

namespace GeckofxUnitTests
{
    // Using SetCulture to catch bugs where ToLower is used instead of ToLowerInvariant
	[TestFixture]
    [SetCulture("tr-TR")]
	internal class GeckoInputElementTests
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

		[Test]
		public void SelectionStart_NoSelection_ReturnsZero()
		{
			browser.TestLoadHtml(@"<input type=""text"" id=""txtbox"" value=""text""/>");

			GeckoInputElement element = (GeckoInputElement)browser.Document.GetHtmlElementById("txtbox");
			Assert.AreEqual(0, element.SelectionStart);
		}

		[Test]
		public void SelectionEnd_NoSelection_ReturnsZero()
		{
			browser.TestLoadHtml(@"<input type=""text"" id=""txtbox"" value=""text""/>");

			GeckoInputElement element = (GeckoInputElement)browser.Document.GetHtmlElementById("txtbox");
			Assert.AreEqual(0, element.SelectionEnd);
		}

        [Test]
        public void Click_JavascriptOnClickRuns()
        {
            browser.TestLoadHtml(@"<input type=""text"" id=""txtbox"" value=""text"" onclick=""this.value = 'clicked';""/>");

            var element = (GeckoInputElement)browser.Document.GetHtmlElementById("txtbox");
            element.Click();

            Assert.AreEqual("clicked", element.Value);
        }

        [Test]
        public void Click_AfterMouseUpAndMouseDownEvents_ExpectedJavascriptHandlerRun()
        {
            browser.TestLoadHtml(@"<input type=""text"" id=""txtbox"" value=""text"" onmousedown=""this.value = 'mousedowned';"" onmouseup=""this.value = 'mouseuped';"" onclick=""this.value = 'clicked';""/>");

            GeckoInputElement element = (GeckoInputElement)browser.Document.GetHtmlElementById("txtbox");

            
            DomEventArgs ev = browser.Document.CreateEvent("MouseEvent");
            var webEvent = new Event(browser.Window.DomWindow, ev.DomEvent as nsISupports);
            webEvent.InitEvent("mousedown", true, true);
            element.GetEventTarget().DispatchEvent(ev);

            Assert.AreEqual("mousedowned", element.Value);

            webEvent.InitEvent("mouseup", true, true);
            element.GetEventTarget().DispatchEvent(ev);

            Assert.AreEqual("mouseuped", element.Value);

            element.Click();

            Assert.AreEqual("clicked", element.Value);
        }
	}
}