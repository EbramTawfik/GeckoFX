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
		public void JS_TypeOfValue__()
		{
			using (AutoJSContext cx = new AutoJSContext())
			{
				Assert.AreEqual(JsVal.JSType.JSTYPE_NUMBER, JsVal.JS_TypeOfValue(cx.ContextPointer, 0));
				Assert.AreEqual(JsVal.JSType.JSTYPE_NUMBER, JsVal.JS_TypeOfValue(cx.ContextPointer, 0xffff0000ffffffff));
				Assert.AreEqual(JsVal.JSType.JSTYPE_BOOLEAN, JsVal.JS_TypeOfValue(cx.ContextPointer, 0xffffffffffffffff));
			}			
		}
	}
}