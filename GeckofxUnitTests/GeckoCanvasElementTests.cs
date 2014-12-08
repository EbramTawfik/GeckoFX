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
	internal class GeckoCancasElementTests
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
		public void Width_WidthIsSet_ReturnsSetValue()
		{
			browser.TestLoadHtml(@"<canvas id='myCanvas' width='200' height='100'></canvas>");

			var canvas = (GeckoCanvasElement)browser.Document.GetHtmlElementById("myCanvas");
			Assert.AreEqual(200, canvas.Width);			
		}

		[Test]
		public void Height_HeightIsSet_ReturnsSetValue()
		{
			browser.TestLoadHtml(@"<canvas id='myCanvas' width='200' height='100'></canvas>");

			var canvas = (GeckoCanvasElement)browser.Document.GetHtmlElementById("myCanvas");
			Assert.AreEqual(100, canvas.Height);
		}

		[Test]
		public void ToDataURL_ZeroWidthAndHeightCanvas_ReturnsEmptyDataString()
		{
			browser.TestLoadHtml(@"<canvas id='myCanvas' width='0' height='0'></canvas>");

			var canvas = (GeckoCanvasElement)browser.Document.GetHtmlElementById("myCanvas");
			Assert.AreEqual("data:,", canvas.ToDataURL("image/png"));
		}

		[Test]
		public void ToDataURL_ImagePng_ReturnsDataUriBase64EncodedPng()
		{
			browser.TestLoadHtml(@"<canvas id='myCanvas' width='200' height='100'></canvas>");

			var canvas = (GeckoCanvasElement) browser.Document.GetHtmlElementById("myCanvas");
			Assert.AreEqual("data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAMgAAABkCAYAAADDhn8LAAAAZElEQVR4nO3BMQEAAADCoPVPbQwfoAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA4GM48wABem1MwwAAAABJRU5ErkJggg==", canvas.ToDataURL("image/png"));
		}
	}
}