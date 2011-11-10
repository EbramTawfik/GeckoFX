using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Skybound.Gecko;

namespace GeckofxUnitTests
{
	[TestFixture]
	class GeckoWebBrowserTests
	{
		GeckoWebBrowser browser;

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
		public void LoadHtml_SomeSimpleHtml_HtmlIsLoadedAndAccessableAfterNavigationFinished()
		{
			string innerHtml = "<div id=\"_lv5\">old value</div>";

			browser.LoadHtml("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">"

						+ "<html xmlns=\"http://www.w3.org/1999/xhtml\" >"

						+ "<body>" + innerHtml + "</body></html>");

			browser.NavigateFinishedNotifier.NavigateFinished += (sender, e) =>
			{
				Assert.AreEqual(browser.Document.Body.InnerHtml, innerHtml);
			};

			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

			Assert.AreEqual(browser.Document.Body.InnerHtml, innerHtml);
		}

		/// <summary>
		/// Helper method to initalize a document with html and wait until document is ready.
		/// </summary>
		/// <param name="innerHtml"></param>
		internal void LoadHtml(string innerHtml)
		{			
			browser.LoadHtml("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">"

						+ "<html xmlns=\"http://www.w3.org/1999/xhtml\" >"

						+ "<body>" + innerHtml + "</body></html>");
			
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
		}

		// TODO: move to a GeckoDocumentTests file.
		[Test]
		public void GetElementsByName_SingleElementExits_ReturnsCollectionWithSingleItem()
		{
			LoadHtml("<div name=\"a\" id=\"_lv5\">old value</div>");

			 var divElement = browser.Document.GetElementsByName("a");
			 Assert.AreEqual(1, divElement.Count);
		}

		// TODO: move to a GeckoDocumentTests file.
		[Test]
		public void GetElementsByName_NotElementExists_ReturnsEmptyCollection()
		{
			LoadHtml("<div name=\"a\" id=\"_lv5\">old value</div>");

			var emptyCollection = browser.Document.GetElementsByName("div");
			Assert.AreEqual(0, emptyCollection.Count);
		}

		// TODO: move to a GeckoDocumentTests file.
		[Test]
		public void GetElementById_SingleElementExists_CorrectElementReturned()
		{
			LoadHtml("<div name=\"a\" id=\"_lv5\">old value</div>");

			var divElement = browser.Document.GetElementById("_lv5");
			Assert.NotNull(divElement);
			Assert.AreEqual(divElement.Id, "_lv5");
		}

		// TODO: move to a GeckoDocumentTests file.
		[Test]
		public void GetElements_XPathSelectsSingleElement_ReturnsCollectionWithSingleItem()
		{
			LoadHtml("<div name=\"a\" id=\"_lv5\">old value</div>");

			var divElement = browser.Document.GetElements("//div");
			Assert.AreEqual(1, divElement.Count());
		}


		// TODO: move to GeckoElementTests file.
		[Test]
		public void OuterHtml_AttributesHaveDoubleQuotes_()
		{
			string divString = "<div name=\"a\" id=\"_lv5\" class=\"none\">old value</div>";
			LoadHtml(divString);

			var divElement = (browser.Document.Body.FirstChild as GeckoElement);
			Assert.AreEqual(divString.ToLowerInvariant(), divElement.OuterHtml.ToLowerInvariant());
		}

		// TODO: move to GeckoElementTests file.
		[Test]
		public void OuterHtml_AttributesHaveSingleQuotes_()
		{
			string divString = "<div name=\'a\' id=\'_lv5\' class='none'>old value</div>";
			LoadHtml(divString);
			
			var divElement = (browser.Document.Body.FirstChild as GeckoElement);
			Assert.AreEqual(divString.ToLowerInvariant().Replace('\'', '"'), divElement.OuterHtml.ToLowerInvariant());			
		}
	}
}	