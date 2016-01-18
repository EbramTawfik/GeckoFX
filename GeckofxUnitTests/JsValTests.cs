using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using NUnit.Framework;
using Gecko;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class JsValTests
	{
		[SetUp]
		public void BeforeEachTestSetup()
		{
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
		}

		[Test]
		public void ToString_OnStringJsVal_ReturnsStringContents()
		{
			JsVal stringJsVal = SpiderMonkeyTests.CreateStringJsVal("hello world");
			Assert.AreEqual("hello world", stringJsVal.ToString());
		}

		[Test]
		public void ToString_OnNumberJsVal_ReturnsNumberContentsConvertedToAString()
		{
			JsVal stringJsVal = SpiderMonkeyTests.CreateNumberJsVal(23);
			Assert.AreEqual("23", stringJsVal.ToString());
		}

		[Test]
		public void ToString_OnBoolJsVal_ReturnsNumberContentsConvertedToAString()
		{
			JsVal stringJsVal = SpiderMonkeyTests.CreateBoolJsVal(false);
			Assert.AreEqual("false", stringJsVal.ToString());
		}

		[Test]
		public void Type_OnStringJsVal_RetrunsStringType()
		{
			JsVal stringJsVal = SpiderMonkeyTests.CreateStringJsVal("hello world");
			Assert.AreEqual(JSType.JSTYPE_STRING, stringJsVal.Type);
		}

		[Test]
		public void Type_OnNumberJsVal_ReturnsNumberType()
		{
			JsVal numberJsVal = SpiderMonkeyTests.CreateNumberJsVal(23);
			Assert.AreEqual(JSType.JSTYPE_NUMBER, numberJsVal.Type);
		}

		[Test]
		public void IsString_OnStringJsVal_RetrunsTrue()
		{
			JsVal stringJsVal = SpiderMonkeyTests.CreateStringJsVal("hello world");
			Assert.IsTrue(stringJsVal.IsString);
		}

		[Test]
		public void IsString_OnNumberJsVal_RetrunsFalse()
		{
			JsVal numberJsVal = SpiderMonkeyTests.CreateNumberJsVal(23);
			Assert.IsFalse(numberJsVal.IsString);
		}

	    [Test]
	    public void FromPtr_JsObject_ConvertedToJsValOfExpectedObject()
	    {
            var browser = new GeckoWebBrowser();
            var unused = browser.Handle;
            Assert.IsNotNull(browser);
            browser.TestLoadHtml("hello world.");
            Assert.Null(browser.Editor);

	        using (var context = new AutoJSContext(browser.Window))
	        {
	            var jsObject = context.ConvertCOMObjectToJSObject((nsISupports) browser.Document.DomObject);
	            var jsVal = JsVal.FromPtr(jsObject);

                Assert.IsTrue(jsVal.IsObject);
                Assert.AreEqual(JSType.JSTYPE_OBJECT, jsVal.Type);
                Assert.AreEqual("[object HTMLDocument]", jsVal.ToString());
                // Verify that converting back to ComObject yields expected object.
	            var documentObject = (nsIDOMHTMLDocument)jsVal.ToObject();                
                Assert.AreEqual(browser.Document.TextContent, new GeckoDocument(documentObject).TextContent);
	        }

            browser.Dispose();
	    }
	}
}
