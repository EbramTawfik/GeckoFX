using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko;
using NUnit.Framework;

namespace GeckofxUnitTests.Common
{
	public class BaseXulrunnerTestWithWinFormsBrowser
		: BaseXulrunnerTest
	{
		private GeckoWebBrowser _browser;

		protected override void BeforeEachTestSetup()
		{
			base.BeforeEachTestSetup();
			_browser = new GeckoWebBrowser();
			IntPtr unusedHandle = _browser.Handle;
			Assert.IsNotNull( _browser );
		}

		protected override void AfterEachTestTearDown()
		{
			base.AfterEachTestTearDown();
			_browser.Dispose();
		}

		protected GeckoWebBrowser Browser
		{
			get { return _browser; }
		}
	}
}
