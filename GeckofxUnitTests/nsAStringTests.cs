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
	public class nsAStringTests
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
			var objectUnderTest = new nsAString();
			objectUnderTest.SetData(null);

			Assert.AreEqual(null, objectUnderTest.ToString());
		}

		[Test]
		public void SetData_ToEmptyString_ToStringReturnsEmptyString()
		{
			var objectUnderTest = new nsAString();
			objectUnderTest.SetData(String.Empty);

			Assert.AreEqual(String.Empty, objectUnderTest.ToString());
		}

		[Test]
		public void SetData_ToTestValue_ToStringReturnsTestValue()
		{
			var objectUnderTest = new nsAString();
			objectUnderTest.SetData("hello world");

			Assert.AreEqual("hello world", objectUnderTest.ToString());
		}
		
		[Test]
		public void ConstructorWithString_ToTestValue_ToStringReturnsTestValue()
		{
			var objectUnderTest = new nsAString("Hello world");
			Assert.AreEqual("Hello world", objectUnderTest.ToString());
		}
	}
}