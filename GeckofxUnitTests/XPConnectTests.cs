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
	public class XPConnectTests
	{
		nsIXPConnect m_instance;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			// defined in nsIXPConent.idl
			// CB6593E0-F9B2-11d2-BDD6-000064657374
			var ptr = (IntPtr)Xpcom.GetService(new Guid("CB6593E0-F9B2-11d2-BDD6-000064657374"));
			Assert.IsNotNull(ptr);
			m_instance = (nsIXPConnect)Marshal.GetObjectForIUnknown(ptr);			
			Assert.IsNotNull(m_instance);			
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

		[Ignore("randomly crashes")]
		[Test]
		public void GarbageCollect_ShouldNotThrowException()
		{
			m_instance.GarbageCollect(true);
		}
	}
}