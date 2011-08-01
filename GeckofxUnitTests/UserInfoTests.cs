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
			Marshal.ReleaseComObject(m_instance);
		}

		[Test]
		public void GetUsernameAttribute_ReturnsNonEmptyUsername()
		{
			Assert.False(string.IsNullOrEmpty(m_instance.GetUsernameAttribute()));
		}

		[Test]
		public void GetFullnameAttribute_ThrowsNotImplementException()
		{
			Assert.Throws<NotImplementedException>(() => m_instance.GetFullnameAttribute());
		}

		[Test]
		public void GetEmailAddressAttribute_ThrowsNotImplementException()
		{
			Assert.Throws<NotImplementedException>(() => m_instance.GetEmailAddressAttribute());
		}

		[Test]
		public void GetDomainAttribute_ThrowsNotImplementedException()
		{
			Assert.Throws<NotImplementedException>(() => m_instance.GetDomainAttribute());			
		}
	}
}