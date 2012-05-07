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

			GeckoInputElement element = (GeckoInputElement)browser.Document.GetElementById("txtbox");
			Assert.AreEqual(0, element.SelectionStart);
		}

		[Test]
		public void SelectionEnd_NoSelection_ReturnsZero()
		{
			browser.TestLoadHtml(@"<input type=""text"" id=""txtbox"" value=""text""/>");

			GeckoInputElement element = (GeckoInputElement)browser.Document.GetElementById("txtbox");
			Assert.AreEqual(0, element.SelectionEnd);
		}
	}
}