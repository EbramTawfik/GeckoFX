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
	internal class GeckoDocumentTests
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
		public void GetElementsByName_SingleElementExits_ReturnsCollectionWithSingleItem()
		{
			browser.TestLoadHtml("<div name=\"a\" id=\"_lv5\">old value</div>");

			var divElement = browser.Document.GetElementsByName("a");
			Assert.AreEqual(1, divElement.Length);
		}

		[Test]
		public void GetElementsByName_NotElementExists_ReturnsEmptyCollection()
		{
			browser.TestLoadHtml("<div name=\"a\" id=\"_lv5\">old value</div>");

			var emptyCollection = browser.Document.GetElementsByName("div");
			Assert.AreEqual(0, emptyCollection.Length);
		}

		[Test]
		public void GetHtmlElementById_SingleElementExists_CorrectElementReturned()
		{
			browser.TestLoadHtml("<div name=\"a\" id=\"_lv5\">old value</div>");

			var divElement = browser.Document.GetHtmlElementById("_lv5");
			Assert.NotNull(divElement);
			Assert.AreEqual(divElement.Id, "_lv5");
		}

		[Test]
		public void GetHtmlElementById_ElementDoesNotExist_ReturnNull()
		{
			browser.TestLoadHtml("<div name=\"a\" id=\"_lv5\">old value</div>");
			Assert.IsNull(browser.Document.GetHtmlElementById("elementDoesNotExist"));
		}

		[Test]
		public void GetElementById_GetSvgElement_CorrectElementReturned()
		{
			browser.TestLoadHtml("<svg id=\"sss\" width=\"380\" height=\"100\"><text id=\"t1\" class=\"caption\" x=\"10\" y=\"35\">Mouseover a square</text></svg>");

			var svgElement = browser.Document.GetElementById("sss");
			Assert.NotNull(svgElement);
			Assert.AreEqual(svgElement.TagName, "svg");
		}

		[Test]
		public void GetElementById_GetTextElementInsideASvg_CorrectElementReturned()
		{
			browser.TestLoadHtml("<svg id=\"sss\" width=\"380\" height=\"100\"><text id=\"t1\" class=\"caption\" x=\"10\" y=\"35\">Mouseover a square</text></svg>");

			var svgElement = browser.Document.GetElementById("t1");
			Assert.NotNull(svgElement);
			Assert.AreEqual(svgElement.TagName, "text");
		}

		[Test]
		public void GetElementById_ElementDoesNotExist_ReturnNull()
		{
			browser.TestLoadHtml("<svg id=\"sss\" width=\"380\" height=\"100\"><text id=\"t1\" class=\"caption\" x=\"10\" y=\"35\">Mouseover a square</text></svg>");

			Assert.IsNull(browser.Document.GetElementById("idDoesNotExist"));			
		}
		
		[Test]
		public void GetElements_XPathSelectsSingleElement_ReturnsCollectionWithSingleItem()
		{
			browser.TestLoadHtml("<div name=\"a\" id=\"_lv5\">old value</div>");

			var r = browser.Document.EvaluateXPath("//div");
			Assert.AreEqual(1, r.GetNodes().Count());
		}

		[Test]
		public void Body_BodyIsDocumentBodyElement_ReturnedGeckoElementIsDocumentBody()
		{
			browser.TestLoadHtml("<span>hello world</span>");

			var element = browser.Document.Body;
			Assert.NotNull(element);
			Assert.AreEqual(typeof(GeckoBodyElement), element.GetType());
		}

		[Test]
		public void Body_BodyIsFrameset_ReturnedGeckoElementIsFrameSetElement()
		{
			browser.TestLoadFrameset("<span>hello world</span>");

			var element = browser.Document.Body;
			Assert.NotNull(element);
			Assert.AreEqual(typeof(GeckoFrameSetElement), element.GetType());
		}

		[Test]
		public void Forms_GetTwoFormsInADocument()
		{
			browser.TestLoadHtml("<form id=\"a\">hello world</form><form id=\"b\">hi</form>");

			Assert.AreEqual(2, browser.Document.Forms.Length);
			Assert.AreEqual("a", browser.Document.Forms[0].Id);
		}
	}
}