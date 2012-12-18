using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Gecko;
using Gecko.Utils;
using NUnit.Framework;

// this test is for testing COM RCW counters 
// each Gecko FX service wrappers must contains only one reference to RCW object.
// each call of Xpcom.GetService<T> increments counter of RCW object
//
// all services must be used as singletons
namespace GeckofxUnitTests
{
	[TestFixture]
	class ServiceBehaviorTest
	{

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize( XpComTests.XulRunnerLocation );
		}

		[TearDownAttribute]
		public void AfterEachTestTearDown()
		{

		}

		[Test]
		public void ManualCreateAndFree()
		{
			// create 3 instances
			var categoryManager1 = Xpcom.GetService<nsICategoryManager>(Contracts.CategoryManager);
			var categoryManager2 = Xpcom.GetService<nsICategoryManager>(Contracts.CategoryManager);
			var categoryManager3 = Xpcom.GetService<nsICategoryManager>(Contracts.CategoryManager);

			// they are equals
			Assert.AreEqual( categoryManager1,categoryManager2 );
			Assert.AreEqual( categoryManager2,categoryManager3 );

			// release ONE instance
			int count=Marshal.ReleaseComObject( categoryManager3 );
			// we must have 2 instances
			Assert.AreEqual( count, 2 );

			count=Marshal.ReleaseComObject( categoryManager2 );
			Assert.AreEqual(count, 1);
			count=Marshal.ReleaseComObject( categoryManager1 );
			Assert.AreEqual(count,0);
		}

		[Test]
		public void CreateVersionComparer()
		{
			var versionComparerNative = Xpcom.GetService<nsIVersionComparator>( Contracts.VersionComparator );

			Gecko.Utils.VersionComparer[] array=new VersionComparer[100];
			for (int i = 0; i < 100; i++)
			{
				array[i]=new VersionComparer();
				array[i].Compare("a", "a");
			}


			int count=Marshal.ReleaseComObject(versionComparerNative);
			// must be only one singleton :)
			Assert.AreEqual(count, 1);
		}
	}
}
