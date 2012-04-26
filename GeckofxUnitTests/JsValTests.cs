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
	}
}
