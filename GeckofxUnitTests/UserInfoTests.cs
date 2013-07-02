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
	[Platform(Exclude="Linux")]
	public class UserInfoTests
	{
		nsIUserInfo m_instance;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			m_instance = Xpcom.CreateInstance<nsIUserInfo>("@mozilla.org/userinfo;1");
			Assert.IsNotNull(m_instance);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			// Doing this combined with how the tests are currently set up may cause memory corruption.
			// Marshal.ReleaseComObject(m_instance);
		}

        [Test]
        [Ignore("may cause memory coruption")]
        public void GetFullnameAttribute_ThrowCOMException()
		{
            Assert.Throws<COMException>(() => m_instance.GetFullnameAttribute());
		}

		[Test]
        [Ignore("may cause memory coruption")]
        public void GetEmailAddressAttribute_ThrowsCOMException()
		{
            Assert.Throws<COMException>(() => m_instance.GetEmailAddressAttribute());
		}

		[Test]
		public void GetDomainAttribute_ReturnsNull()
		{
			Assert.IsNotNull(m_instance.GetDomainAttribute());
		}
	}
}
