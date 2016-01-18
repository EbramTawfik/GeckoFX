using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.DOM.Svg;
using NUnit.Framework;
using Gecko;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class XPConnectTests
	{
		nsIXPConnect m_instance;

		private GeckoWebBrowser _browser;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			// defined in nsIXPConent.idl
			// CB6593E0-F9B2-11d2-BDD6-000064657374
			var ptr = (IntPtr)Xpcom.GetService(new Guid("CB6593E0-F9B2-11d2-BDD6-000064657374"));
			Assert.IsNotNull(ptr);
			m_instance = (nsIXPConnect)Xpcom.GetObjectForIUnknown(ptr);
			Assert.IsNotNull(m_instance);

			_browser = new GeckoWebBrowser();
			var unused = _browser.Handle;
			Assert.IsNotNull(_browser);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			Marshal.ReleaseComObject(m_instance);
		}

		[Test]
		public void GetCurrentJSStackAttribute_ReturnsNull()
		{
			Assert.IsNull(m_instance.GetCurrentJSStackAttribute());
		}

        [Ignore("Unfortunally GetWrappedNativeOfJSObject is not returning E_FAIL - so Ignore this interesting tech demo")]
		[Test]
		public void FindInterfaceWithMember_OnAWindowElementLookingForNameMethod_ReturnsInterfaceThatContainsMethodNode()
		{
			_browser.TestLoadHtml("hello world");
			using (var context = new AutoJSContext(_browser.Window.JSContext))
			{
				context.PushCompartmentScope((nsISupports)_browser.Window.DomWindow);				
				var jsValWindow = context.EvaluateScript("this");
				var jsVal = SpiderMonkeyTests.CreateStringJsVal(context, "name");				
				var jsObject = SpiderMonkey.JS_ValueToObject(context.ContextPointer, jsValWindow);
				var a = m_instance.GetWrappedNativeOfJSObject(context.ContextPointer, jsObject);

				// Perform the test.
				var i = a.FindInterfaceWithMember(ref jsVal.AsPtr);

				Assert.NotNull(i);
				Assert.IsTrue(i.IsScriptable());
				Assert.AreEqual("nsIDOMWindow", i.GetNameShared());
			}
		}

        [Ignore("Unfortunally GetWrappedNativeOfJSObject is not returning E_FAIL - so Ignore this interesting tech demo")]
		[Test]
		public void FindInterfaceWithName_OnAWindowElementLookingForADOMWindowInterface_ReturnsExpectedInterface()
		{
			_browser.TestLoadHtml("hello world");
            using (var context = new AutoJSContext(_browser.Window.JSContext))
			{
				context.PushCompartmentScope((nsISupports)_browser.Window.DomWindow);				
				var jsValWindow = context.EvaluateScript("this");
				var jsVal = SpiderMonkeyTests.CreateStringJsVal(context, "nsIDOMWindow");
                Assert.IsFalse(jsVal.IsNull);                                
				var jsObject = SpiderMonkey.JS_ValueToObject(context.ContextPointer, jsValWindow);
				var a = m_instance.GetWrappedNativeOfJSObject(context.ContextPointer, jsObject);				                                

				// Perform the test
				var i = a.FindInterfaceWithName(ref jsVal.AsPtr);

				Assert.NotNull(i);
				Assert.IsTrue(i.IsScriptable());
				Assert.AreEqual("nsIDOMWindow", i.GetNameShared());
			}
		}		

		[Ignore("randomly crashes")]
		[Test]
		public void GarbageCollect_ShouldNotThrowException()
		{
			// nsGCType enum:
			// nsGCNormal,
			// nsGCShrinking,
			// nsGCIncremental			
			m_instance.GarbageCollect(0);
		}
	}
}
