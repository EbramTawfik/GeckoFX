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
		public void AllowPort_TelnetPort_ReturnsUnsafe()
		{
			Assert.IsFalse(m_instance.AllowPort(23, String.Empty));
		}

		[Test]
		public void GetOfflineAttribute_NotOffline_ReturnsFalse()
		{
			Assert.IsFalse(m_instance.GetOfflineAttribute());
		}

		[Test]
		public void GetProtocalFlags_CompareValidAndInvalidProtocoals_ProtocolFlagsDiffer()
		{
			// Expect http to be non zero
			Assert.AreNotEqual(0, m_instance.GetProtocolFlags("http"));
			// Expect http flag values to be different from invalid protocol
			Assert.AreNotEqual(m_instance.GetProtocolFlags("http"), m_instance.GetProtocolFlags("nonexistantprotocaol"));
		}

		[Test]
		public void GetProtocolHandler_HandlerForHttp_ReturnsValidHandlerInstance()
		{
			nsIProtocolHandler handler = m_instance.GetProtocolHandler("http");
			Assert.IsNotNull(handler);
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

		[Test]
		[Ignore("SetOfflineAttribute(true) hangs")]
		public void SetOfflineAttribute_SwitchingAttributeOnAndOff_ShouldChangeState()
		{
			Assert.IsFalse(m_instance.GetOfflineAttribute());
			m_instance.SetOfflineAttribute(true);
			Assert.IsTrue(m_instance.GetOfflineAttribute());
			m_instance.SetOfflineAttribute(false);
			Assert.IsFalse(m_instance.GetOfflineAttribute());
		}
	}
}