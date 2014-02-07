using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.DOM.Svg;
using NUnit.Framework;
using System.Windows.Forms;
using Gecko;
using System.IO;
using System.Runtime.InteropServices;
using Gecko.DOM;

namespace GeckofxUnitTests
{
	[TestFixture]
	internal class GeckoNodeTests
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

#if DELME
		[Test]
		public void ChildNodes_OnSvgDocument_ChildElementsAreTypedCorrectly()
		{
			string divString = "<div name=\"a\" id=\"_lv5\" class=\"none\">old value</div>";
			browser.TestLoadSvg("<polygon fill='red' stroke='red' points='571,-828 517,-828 517,-792 571,-792 571,-828'/>");

			Assert.IsTrue(((browser.DomDocument as SvgDocument).RootElement as GeckoNode).ChildNodes[0] is GeckoElement);
		}
#endif
	}
}