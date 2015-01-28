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
	public class AutoJSContextTests
	{
		private GeckoWebBrowser _browser;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			_browser = new GeckoWebBrowser();
			var unused = _browser.Handle;
			Assert.IsNotNull(_browser);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			_browser.Dispose();
		}

		[Test]
		public void CreateAndDisposeAutoJsContext_NoSuppliedContext_ContextPointerNotNull()
		{
			using (var context = new AutoJSContext())
			{
				Assert.NotNull(context.ContextPointer);				
			}
		}

		[Test]
		public void PeekCompartmentScope_NotContextHaveBeenPushed_ReturnsGlobalContext()
		{
			using (var context = new AutoJSContext())
			{				
				var globalObject = SpiderMonkey.DefaultObjectForContextOrNull(context.ContextPointer);
				Assert.AreEqual(context.PeekCompartmentScope(), globalObject);	
			}
		}

		[Test]
		public void PushCompartmentScope_PushANewScopeObject_PeekNoLongerReturnsGlobalContext()
		{
			_browser.TestLoadHtml("hello world");
			using (var context = new AutoJSContext(_browser.Window.JSContext))
			{
				context.PushCompartmentScope((nsISupports)_browser.Window.DomWindow);

				var globalObject = SpiderMonkey.DefaultObjectForContextOrNull(context.ContextPointer);
				Assert.AreNotEqual(context.PeekCompartmentScope(), globalObject);
			}
		}

		[Test]
		public void PopCompartmentScope_AfterAPushedScope_PeekNowReturnsGlobalContextAgain()
		{
			_browser.TestLoadHtml("hello world");
			using (var context = new AutoJSContext(_browser.Window.JSContext))
			{
				context.PushCompartmentScope((nsISupports)_browser.Window.DomWindow);

				var globalObject = SpiderMonkey.DefaultObjectForContextOrNull(context.ContextPointer);
				Assert.AreNotEqual(context.PopCompartmentScope(), globalObject);
				Assert.AreEqual(context.PeekCompartmentScope(), globalObject);
			}
		}

	    [Test]
	    public void GetComponentsObject_DoesNotReturnNull()
	    {
	        _browser.TestLoadHtml("hello world");
	        using (var context = new AutoJSContext(_browser.Window.JSContext))
	        {
	            Assert.NotNull(context.GetComponentsObject(), "Getting the javascript Components object failed.");
	        }
	    }
	}
}