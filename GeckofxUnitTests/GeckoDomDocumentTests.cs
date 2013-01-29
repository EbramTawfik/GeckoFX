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
	internal class GeckoDomDocumentTests
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
		public void CreateElement_EmptyDocument_HtmlElementReturned()
		{
			browser.TestLoadHtml("");
			GeckoHtmlElement element = browser.DomDocument.CreateHtmlElement("div");
			Assert.NotNull(element);
			Assert.AreEqual("div", element.TagName.ToLowerInvariant());
		}

		[Test]
		public void CreateNonHtmlElement_EmptyDocument_NonHtmlElementReturned()
		{
			browser.TestLoadSvg("");
			GeckoElement element = browser.DomDocument.CreateElement("rect");
			Assert.NotNull(element);
			Assert.AreEqual("rect", element.TagName.ToLowerInvariant());
		}
	}
}