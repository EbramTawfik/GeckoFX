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
	public class RandomGeneratorTests
	{		

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);			
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			
		}
		
		[Test]
		public void GenerateRandomBytes_Generate100Bytes_ReturnsArrayOf1000Bytes()
		{
			byte[] bytes = RandomGenerator.GenerateRandomBytes(1000);
						 
			Assert.AreEqual(1000, bytes.Length);			
		}
	}
}