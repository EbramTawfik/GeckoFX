using System.IO;
using System.Runtime.InteropServices;
using NUnit.Framework;
using Gecko;
using System;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class nsURITests
	{		
		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);			
		}

		[TearDownAttribute]
		public void AfterEachTestTearDown()
		{
			
		}

		[Test]
		public void Create_HttpUrl_ValidnsUriReturned()
		{
			nsURI temp = nsURI.Create("http://www.google.com");
			Assert.AreEqual("http", temp.Scheme);
			Assert.AreEqual("www.google.com", temp.AsciiHost);			
		}

		[Test]
		public void UrlTest()
		{
			var service = Xpcom.GetService<nsIIOService>(Contracts.NetworkIOService);

			nsIURI ret;
			using (var str = new nsAUTF8String("http://www.google.com"))
			{
				ret = service.NewURI(str, null, null);
			}

			var ret2=Xpcom.QueryInterface<nsIURL>( ret );

			var counter=Marshal.ReleaseComObject( ret );
			Assert.AreEqual( counter,1 );
			var serviceCounter=Marshal.ReleaseComObject( service );

			// Xpcom.GetService ref + 1
			// IOService static contrustor ref + 1
#if false
			Assert.AreEqual(serviceCounter, 0);
#endif
		}
	}
}
