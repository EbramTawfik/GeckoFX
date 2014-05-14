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
	internal class GeckoMarkupDocumentViewerTests
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
		public void SetFullZoomAttribute_SettingToDefault()
		{
			browser.TestLoadHtml("hello world.");

			browser.GetMarkupDocumentViewer().SetFullZoomAttribute(1.0F);

			Assert.AreEqual(1.0F, browser.GetMarkupDocumentViewer().GetFullZoomAttribute());
		}

		[Test]
		public void SetFullZoomAttribute_ZoomingIn()
		{
			browser.TestLoadHtml("hello world.");

			browser.GetMarkupDocumentViewer().SetFullZoomAttribute(2.0F);

			Assert.AreEqual(2.0F, browser.GetMarkupDocumentViewer().GetFullZoomAttribute());
		}

		[Test]
		public void SetTextZoomAttribute_SettingToDefault()
		{
			browser.TestLoadHtml("hello world.");

			browser.GetMarkupDocumentViewer().SetTextZoomAttribute(1.0F);

			Assert.AreEqual(1.0F, browser.GetMarkupDocumentViewer().GetTextZoomAttribute());
		}

		[Test]
		public void SetTextZoomAttribute_ZoomingIn()
		{
			browser.TestLoadHtml("hello world.");

			browser.GetMarkupDocumentViewer().SetTextZoomAttribute(2.0F);

			Assert.AreEqual(2.0F, browser.GetMarkupDocumentViewer().GetTextZoomAttribute());
		}
	}
}
