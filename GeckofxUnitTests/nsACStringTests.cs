using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using NUnit.Framework;
using Gecko;
using Gecko.Plugins;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class nsACStringTests
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
		public void SetData_ToNull_ToStringReturnsNull()
		{
			var objectUnderTest = new nsACString();
			objectUnderTest.SetData(null);

			Assert.AreEqual(null, objectUnderTest.ToString());
		}

		[Test]
		public void SetData_ToEmptyString_ToStringReturnsEmptyString()
		{
			var objectUnderTest = new nsACString();
			objectUnderTest.SetData(String.Empty);

			Assert.AreEqual(String.Empty, objectUnderTest.ToString());
		}

		[Test]
		public void SetData_ToTestValue_ToStringReturnsTestValue()
		{
			var objectUnderTest = new nsACString();
			objectUnderTest.SetData("hello world");

			Assert.AreEqual("hello world", objectUnderTest.ToString());
		}
		
		[Test]
		public void GetRawData_OfTestValue_ReturnsExpectedByteString()
		{
			var objectUnderTest = new nsACString();
			objectUnderTest.SetData("hello world");	
			
			byte[] bytes = objectUnderTest.GetRawData();
			Assert.AreEqual(new byte[] { 104, 101, 108, 108, 111, 32, 119, 111, 114, 108, 100}, bytes);
		}
		
		[Test]
		public void ConstructorWithString_ToTestValue_ToStringReturnsTestValue()
		{
			var objectUnderTest = new nsACString("Hello world");
			Assert.AreEqual("Hello world", objectUnderTest.ToString());
		}

		[Test]
		public void ConstructorWithString_UnicodeValueLargerThanWillFitInSingleByte_ToStringReturnsExpectedTestValue()
		{			
			string testValue = "Hello 中文 world";
			var objectUnderTest = new nsACString(testValue);
			Assert.AreEqual(testValue, objectUnderTest.ToString());
		}
	}
}