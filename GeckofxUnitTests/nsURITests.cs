using System.IO;
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
	}
}
