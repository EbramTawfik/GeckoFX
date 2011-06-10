using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using NUnit.Framework;
using Skybound.Gecko;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class IOServiceTests
	{
		nsIIOService m_instance;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			m_instance = Xpcom.GetService<nsIIOService>("@mozilla.org/network/io-service;1");
			Assert.IsNotNull(m_instance);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			Marshal.ReleaseComObject(m_instance);
		}

		[Test]
		public void NewURI_BadUri_ThrowsMalformedUriException()
		{
			string referrer = "somejunk";
			Assert.Throws<COMException>(() => m_instance.NewURI(new nsAUTF8String(referrer), null, null));	
		}

		[Test]
		public void NewURI_ValidUri_ReturnsValidUriInstance()
		{
			string referrer = "http://www.google.co.uk";
			nsIURI result = m_instance.NewURI(new nsAUTF8String(referrer), null, null);
		}
	}
}