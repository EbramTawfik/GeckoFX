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
            _browser.TestLoadHtml("hello world");
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
				Assert.AreNotEqual(IntPtr.Zero, context.PeekCompartmentScope());
			}
		}

		[Test]
		public void PushCompartmentScope_PushANewScopeObject_PeekNoLongerReturnsGlobalContext()
		{
			_browser.TestLoadHtml("hello world");
			using (var context = new AutoJSContext(_browser.Window.DomWindow))
			{
			    var globalObject = context.PeekCompartmentScope();
				context.PushCompartmentScope((nsISupports)_browser.Document.FirstChild.DomObject);
				
				Assert.AreNotEqual(context.PeekCompartmentScope(), globalObject);
			}
		}

		[Test]
		public void PopCompartmentScope_AfterAPushedScope_PeekNowReturnsGlobalContextAgain()
		{
			_browser.TestLoadHtml("hello world");
			using (var context = new AutoJSContext(_browser.Window.DomWindow))
			{
				context.PushCompartmentScope((nsISupports)_browser.Document.FirstChild.DomObject);

			    var poppedScope = context.PopCompartmentScope();
			    var peekedScope = context.PeekCompartmentScope();
                Assert.AreNotEqual(poppedScope, peekedScope);
				Assert.AreNotEqual(IntPtr.Zero, peekedScope);
			}
		}

        [Ignore("TODO: I think this may need backstagepass access.")]
	    [Test]
	    public void GetComponentsObject_DoesNotReturnNull()
	    {
	        _browser.TestLoadHtml("hello world");
	        using (var context = new AutoJSContext(_browser.Window.DomWindow))
	        {
	            Assert.NotNull(context.GetComponentsObject(), "Getting the javascript Components object failed.");
	        }
	    }
	}
}