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
	}
}