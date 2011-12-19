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
	public class ControllersTests
	{
		nsIControllers m_instance;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			m_instance = Xpcom.GetService<nsIControllers>("@mozilla.org/xul/xul-controllers;1");
			Assert.IsNotNull(m_instance);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			Marshal.ReleaseComObject(m_instance);
		}

		[Test]
		public void GetControllerCount_ReturnsZero()
		{
			m_instance.GetControllerCount();
			Assert.AreEqual(0, m_instance.GetControllerCount());
		}		
	}
}