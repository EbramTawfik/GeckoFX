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

		internal static JsVal CreateStringJsVal(AutoJSContext context, string value)
		{
			string jscript = String.Format("'{0}';", value);
			return CreateJsVal(context, jscript);
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
				return CreateJsVal(cx, jscript);
			}
		}

		private static JsVal CreateJsVal(AutoJSContext cx, string jscript)
		{
			if (cx == null)
				return CreateJsVal(jscript);

				var ptr = new JsVal();
				IntPtr scope = cx.PeekCompartmentScope();
				bool ret = SpiderMonkey.JS_EvaluateScript(cx.ContextPointer, scope, jscript, (uint)jscript.Length, "script", 1, ref ptr);
				Assert.IsTrue(ret);
				return ptr;
			}

		[Test]
		public void JS_TypeOfValue()
		{
			if (Xpcom.IsLinux && IntPtr.Size == 8)
				Assert.Ignore("unsafe test:seg faults on 64bit Linux");

			using (AutoJSContext cx = new AutoJSContext(GlobalJSContextHolder.BackstageJSContext))
			{
				Assert.AreEqual(JSType.JSTYPE_NUMBER, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, JsVal.FromPtr(0)));
				Assert.AreEqual(JSType.JSTYPE_NUMBER, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, JsVal.FromPtr(0xffff0000ffffffff)));
				Assert.AreEqual(JSType.JSTYPE_XML, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, JsVal.FromPtr(0xffffffffffffffff)));
			}
		}

		[Test]
		public void JS_TypeOfValue_OnStringJsValCreatedBySpiderMonkey_ReturnsTypeString()
		{

			var jsVal = CreateStringJsVal("hello world");
			using (AutoJSContext cx = new AutoJSContext(GlobalJSContextHolder.BackstageJSContext))
			{
				Assert.AreEqual(JSType.JSTYPE_STRING, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, jsVal));
			}
		}

		[Test]
		public void JS_TypeOfValue_OnNumberJsValCreatedBySpiderMonkey_ReturnsTypeNumber()
		{

			var jsVal = CreateNumberJsVal(100);
			using (AutoJSContext cx = new AutoJSContext(GlobalJSContextHolder.BackstageJSContext))
			{
				Assert.AreEqual(JSType.JSTYPE_NUMBER, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, jsVal));
			}
		}

		[Test]
		public void JS_TypeOfValue_OnBoolJsValCreatedBySpiderMonkey_ReturnsTypeBool()
		{
			var jsVal = CreateBoolJsVal(true);
			using (AutoJSContext cx = new AutoJSContext(GlobalJSContextHolder.BackstageJSContext))
			{
				Assert.AreEqual(JSType.JSTYPE_BOOLEAN, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, jsVal));
			}
		}

		[Test]
		public void JS_NewStringCopyN()
		{
			using (AutoJSContext cx = new AutoJSContext(GlobalJSContextHolder.BackstageJSContext))
			{
				IntPtr jsString = SpiderMonkey.JS_NewStringCopyN(cx.ContextPointer, "hello world", 11);
				Assert.NotNull(jsString);

				IntPtr str = SpiderMonkey.JS_EncodeString(cx.ContextPointer, jsString);
				string result = Marshal.PtrToStringAnsi(str);
				Assert.AreEqual("hello world", result);
			}
		}

		public IEnumerable<KeyValuePair<string, Action<IntPtr>>> EntryPoints()
		{
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_EncodeString", (c) => SpiderMonkey.JS_EncodeString(IntPtr.Zero, IntPtr.Zero));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_TypeOfValue", (c) => SpiderMonkey.JS_TypeOfValue(IntPtr.Zero, default(JsVal)));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_ValueToString", (c) => SpiderMonkey.JS_ValueToString(IntPtr.Zero, default(JsVal)));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_ValueToObject", (c) => SpiderMonkey.JS_ValueToObject(IntPtr.Zero, default(JsVal)));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_NewStringCopyN", (c) => SpiderMonkey.JS_NewStringCopyN(c, "", 0));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_GetGlobalForObject", (c) => SpiderMonkey.JS_GetGlobalForObject(c, IntPtr.Zero));
			yield return new KeyValuePair<string, Action<IntPtr>>("GetGlobalForObjectCrossCompartment", (c) => SpiderMonkey.GetGlobalForObjectCrossCompartment(IntPtr.Zero));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_SaveFrameChain", (c) => SpiderMonkey.JS_SaveFrameChain(c));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_NewObject", (c) => SpiderMonkey.JS_NewObject(c, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_GetParent", (c) => SpiderMonkey.JS_GetParent(IntPtr.Zero));									
			yield return new KeyValuePair<string, Action<IntPtr>>("CurrentGlobalOrNull", (c) => SpiderMonkey.CurrentGlobalOrNull(c));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_NewContext", (c) => SpiderMonkey.JS_NewContext(IntPtr.Zero, 0));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_GetRuntime", (c) => SpiderMonkey.JS_GetRuntime(c));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_GetContextPrivate", (c) => SpiderMonkey.JS_GetContextPrivate(c));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_SetContextPrivate", (c) => SpiderMonkey.JS_SetContextPrivate(c, IntPtr.Zero));
			yield return new KeyValuePair<string, Action<IntPtr>>("DefaultObjectForContextOrNull", (c) => SpiderMonkey.DefaultObjectForContextOrNull(c));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_BeginRequest", (c) => SpiderMonkey.JS_BeginRequest(c));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_EndRequest", (c) => SpiderMonkey.JS_EndRequest(c));			
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_EvaluateScript", (c) =>
			{
				var jsVal = new JsVal();
				SpiderMonkey.JS_EvaluateScript(c, IntPtr.Zero, "", 0, "", 0, ref jsVal);
			});
			
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_GetClassObject", (c) => SpiderMonkey.JS_GetClassObject(c, IntPtr.Zero));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_GetClass", (c) => SpiderMonkey.JS_GetClass(IntPtr.Zero));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_ContextIterator", (c) =>
			{
				var pt = IntPtr.Zero;
				SpiderMonkey.JS_ContextIterator(IntPtr.Zero, ref pt);
			});
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_SetContextCallback", (c) => SpiderMonkey.JS_SetContextCallback(IntPtr.Zero, null));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_EnterCompartment", (c) => SpiderMonkey.JS_EnterCompartment(c, IntPtr.Zero));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_LeaveCompartment", (c) => SpiderMonkey.JS_LeaveCompartment(c, IntPtr.Zero));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_Free", (c) => SpiderMonkey.JS_Free(c, IntPtr.Zero));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_WrapObject", (c) => SpiderMonkey.JS_WrapObject(c, IntPtr.Zero));
			yield return new KeyValuePair<string, Action<IntPtr>>("IsObjectInContextCompartment", (c) => SpiderMonkey.IsObjectInContextCompartment(IntPtr.Zero, c));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_DestroyRuntime", (c) => SpiderMonkey.JS_DestroyRuntime(IntPtr.Zero));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_HasProperty", (c) => SpiderMonkey.JS_HasProperty(c, IntPtr.Zero, ""));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_GetProperty", (c) => SpiderMonkey.JS_GetProperty(c, IntPtr.Zero, ""));
            yield return new KeyValuePair<string, Action<IntPtr>>("JS_CallFunctionName", (c) => SpiderMonkey.JS_CallFunctionName(c, IntPtr.Zero, "", new JsVal[0]));            
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_SetCompartmentPrincipals", (c) => SpiderMonkey.JS_SetCompartmentPrincipals(c, IntPtr.Zero));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_GetCompartmentPrincipals", (c) => SpiderMonkey.JS_GetCompartmentPrincipals(c));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_SetTrustedPrincipals", (c) => SpiderMonkey.JS_SetTrustedPrincipals(IntPtr.Zero, IntPtr.Zero));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_GetPendingException", (c) => SpiderMonkey.JS_GetPendingException(c));
			yield return new KeyValuePair<string, Action<IntPtr>>("JS_SetErrorReporter", (c) => SpiderMonkey.JS_SetErrorReporter(c, (cx, message, report) => {}));
            yield return new KeyValuePair<string, Action<IntPtr>>("JS_EncodeStringUTF8", (c) => SpiderMonkey.JS_EncodeStringUTF8(c, IntPtr.Zero));
            yield return new KeyValuePair<string, Action<IntPtr>>("JS_GetStringLength", (c) => SpiderMonkey.JS_GetStringLength(IntPtr.Zero));
            yield return new KeyValuePair<string, Action<IntPtr>>("JS_GetStringEncodingLength", (c) => SpiderMonkey.JS_GetStringEncodingLength(c, IntPtr.Zero));

            
		}

		[Test]
		public void SpiderMonkeyEntryPointTests()
		{
			foreach (var entryPoint in EntryPoints())
			{
				var dummy = new GeckoWebBrowser();
				dummy.CreateControl();
				var dummyHandle = dummy.Handle;

				// Try us around the using because, AutoJSContext can throw exception caused by the junk arguments we pass to EntryPoints.
				try
				{
					using (var cx = new AutoJSContext(GlobalJSContextHolder.BackstageJSContext))
					{					
							entryPoint.Value(IntPtr.Zero);
					}
				}
				catch (Exception e)
				{
					if (e is EntryPointNotFoundException)
						Assert.Fail(String.Format("{0}:{1} EntryPoint is wrong: {2}", entryPoint.Value, entryPoint.Key, e.Message));
				}
				dummy.Dispose();
			}
		}

	}
}
