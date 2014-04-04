using System;
using Gecko;
using NUnit.Framework;
using System.Linq;

namespace GeckofxUnitTests
{
	[TestFixture]
	internal class GeckoStyleTests
	{
		private GeckoWebBrowser _browser;
		private GeckoStyle _style;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			_browser = new GeckoWebBrowser();
			var unused = _browser.Handle;
			Assert.IsNotNull(_browser);

			_browser.TestLoadEditableHtmlViaStream("<html><head><style type='text/css'>body { color: red }</style></head><body>some random html</body></html>");
			_style = _browser.Document.Body.Style;
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			_browser.Dispose();
		}

		[Test]
		public void Length_NoPropertiesSet()
		{
			Assert.AreEqual(0, _style.Length);
		}

		[Test]
		public void Length_SinglePropertySet()
		{
			_style.SetPropertyValue("top", "1px");

			Assert.AreEqual(1, _style.Length);
		}

		[Test]
		public void CssText_NoPropertiesSet()
		{
			Assert.AreEqual(String.Empty, _style.CssText);
		}

		[Test]
		public void CssText_PropertieSet()
		{
			_style.SetPropertyValue("top", "1px");

			Assert.AreEqual("top: 1px;", _style.CssText);
		}

		[Test]
		public void Indexer_PropertiesExists()
		{
			_style.SetPropertyValue("top", "1px");

			Assert.AreEqual("top", _style[0]);
		}

		[Test]
		public void GetPropertyValue_PropertyDoesNotExist_ReturnsEmptyString()
		{
			Assert.AreEqual(String.Empty, _style.GetPropertyValue("abc"));
		}

		[Test]
		public void SetPropertyValue_PropertyDoesNotExit_PropertyIsSet()
		{									
			_style.SetPropertyValue("white-space", "pre-wrap");

			Assert.AreEqual("pre-wrap", _style.GetPropertyValue("white-space"));
		}

		[Test]
		public void SetPropertyValue_WithPriority_PropertyIsSet()
		{
			_style.SetPropertyValue("white-space", "pre-wrap", "important");

			Assert.AreEqual("pre-wrap", _style.GetPropertyValue("white-space"));			
		}

		[Test]
		public void GetCssRules_DoesNotThrowException()
		{
			GeckoStyleSheet styleSheet = _browser.Document.StyleSheets.First();
			GeckoStyleSheet.StyleRuleCollection cssRules = null;
			Assert.DoesNotThrow(() => { cssRules = styleSheet.CssRules; });
			Assert.DoesNotThrow(() => { cssRules.Insert(0, "#blanc { color: white }"); });
			Assert.DoesNotThrow(() => { cssRules.RemoveAt(0); });
			Assert.DoesNotThrow(() => { cssRules.Clear(); });
		}
	}
}