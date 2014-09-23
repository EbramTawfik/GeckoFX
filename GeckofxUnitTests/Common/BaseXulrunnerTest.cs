using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko;
using NUnit.Framework;

namespace GeckofxUnitTests.Common
{
	/// <summary>
	/// Base Xulrunner test class
	/// </summary>
	public class BaseXulrunnerTest
	{
		[SetUp]
		public void TestSetup()
		{
			BeforeEachTestSetup();
		}

		[TearDown]
		public void TestShutdown()
		{
			AfterEachTestTearDown();
		}

		/// <summary>
		/// If you need override this method 
		/// </summary>
		protected virtual void BeforeEachTestSetup()
		{
			Xpcom.Initialize( XpComTests.XulRunnerLocation );
		}

		/// <summary>
		/// If you need override this method 
		/// </summary>
		protected virtual void AfterEachTestTearDown()
		{

		}
	}
}
