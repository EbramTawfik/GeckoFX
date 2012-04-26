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
	public class SpiderMonkeyTests
	{
		[SetUp]
		public void BeforeEachTestSetup()
		{

		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
		}

		/// <summary>
		/// Unittest helper method to create a String JsVal
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		internal static JsVal CreateStringJsVal(string value)
		{			
			string jscript = String.Format("'{0}';", value);
			return CreateJsVal(jscript);	
		}

		/// <summary>
		/// Unittest helper method to create a Number JsVal
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		internal static JsVal CreateNumberJsVal(int value)
		{			
			string jscript = String.Format("{0};", value);
			return CreateJsVal(jscript);
		}

		/// <summary>
		/// Unittest helper method to create a bool JsVal
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		internal static JsVal CreateBoolJsVal(bool value)
		{
			string jscript = String.Format("{0};", value ? "true" : "false");
			return CreateJsVal(jscript);
		}

		/// <summary>
		/// Unittest helper method to create a String JsVal
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		private static JsVal CreateJsVal(string jscript)
		{
			using (AutoJSContext cx = new AutoJSContext())
			{				
				var ptr = new JsVal();
				var _securityManager = Xpcom.GetService<nsIScriptSecurityManager>("@mozilla.org/scriptsecuritymanager;1");
				var _systemPrincipal = _securityManager.GetSystemPrincipal();
				var _jsPrincipals = _systemPrincipal.GetJSPrincipals(cx.ContextPointer);
				IntPtr globalObject = SpiderMonkey.JS_GetGlobalForScopeChain(cx.ContextPointer);
				bool ret = SpiderMonkey.JS_EvaluateScriptForPrincipals(cx.ContextPointer, globalObject, _jsPrincipals, jscript, (uint)jscript.Length, "script", 1, ref ptr);
				Assert.IsTrue(ret);
				Marshal.ReleaseComObject(_securityManager);

				return ptr;
			}
		}

		[Test]
		public void JS_TypeOfValue()
		{
			using (AutoJSContext cx = new AutoJSContext())
			{
				Assert.AreEqual(JSType.JSTYPE_NUMBER, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, 0));
				Assert.AreEqual(JSType.JSTYPE_NUMBER, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, 0xffff0000ffffffff));
				Assert.AreEqual(JSType.JSTYPE_BOOLEAN, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, 0xffffffffffffffff));
			}
		}

		[Test]
		public void JS_TypeOfValue_OnStringJsValCreatedBySpiderMonkey_ReturnsTypeString()
		{

			var jsVal = CreateStringJsVal("hello world");
			using (AutoJSContext cx = new AutoJSContext())
			{
				Assert.AreEqual(JSType.JSTYPE_STRING, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, jsVal.Ptr));
			}
		}

		[Test]
		public void JS_TypeOfValue_OnNumberJsValCreatedBySpiderMonkey_ReturnsTypeNumber()
		{

			var jsVal = CreateNumberJsVal(100);
			using (AutoJSContext cx = new AutoJSContext())
			{
				Assert.AreEqual(JSType.JSTYPE_NUMBER, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, jsVal.Ptr));
			}
		}

		[Test]
		public void JS_TypeOfValue_OnBoolJsValCreatedBySpiderMonkey_ReturnsTypeBool()
		{
			var jsVal = CreateBoolJsVal(true);
			using (AutoJSContext cx = new AutoJSContext())
			{
				Assert.AreEqual(JSType.JSTYPE_BOOLEAN, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, jsVal.Ptr));
			}
		}

		[Test]
		public void JS_NewStringCopyN()
		{
			using (AutoJSContext cx = new AutoJSContext())
			{
				IntPtr jsString = SpiderMonkey.JS_NewStringCopyN(cx.ContextPointer, "hello world", 11);
				Assert.NotNull(jsString);

				IntPtr str = SpiderMonkey.JS_EncodeString(cx.ContextPointer, jsString);
				string result = Marshal.PtrToStringAnsi(str);
				Assert.AreEqual("hello world", result);
			}
		}
	}
}
