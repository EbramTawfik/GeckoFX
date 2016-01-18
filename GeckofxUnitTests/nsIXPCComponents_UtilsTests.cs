using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko;
using NUnit.Framework;

namespace GeckofxUnitTests
{
    [TestFixture]
    public class nsIXPCComponents_UtilsTests
    {
        private GeckoWebBrowser _browser;
        private AutoJSContext _context;

        [SetUp]
        public void BeforeEachTestSetup()
        {
            Xpcom.Initialize(XpComTests.XulRunnerLocation);
            _browser = new GeckoWebBrowser();
            var unused = _browser.Handle;
            Assert.IsNotNull(_browser);
            _browser.LoadHtml("hi");
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            _context = new AutoJSContext(_browser.Window);
        }

        [TearDown]
        public void AfterEachTestTearDown()
        {
            _context.Dispose();
            _browser.Dispose();
        }

        [Ignore("I think this needs backstagepass access.")]
        [Test]
        public void GetWerrorAttribute_DoesNotCrash()
        {
            Assert.AreEqual(false, _context.GetComponentsObject().GetUtilsAttribute().GetWerrorAttribute(_context.ContextPointer));
        }
    }
}
