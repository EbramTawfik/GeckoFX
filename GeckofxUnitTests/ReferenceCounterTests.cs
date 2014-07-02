using System.Diagnostics;
using System.Runtime.InteropServices;
using Gecko;
using Gecko.Interop;
using GeckofxUnitTests.Common;
using NUnit.Framework;

namespace GeckofxUnitTests
{
	/// <summary>
	/// Main task for this test - do detect diffs between platforms (.NET on Windows,Mono on Windows,Mono on Linux, etc)
	/// </summary>
	[TestFixture]
	public class ReferenceCounterTests
		: BaseXulrunnerTest
	{
		public const string XulRuntimeTestsCategory = "GeckoFx : Core";


		private static object[] TestingContracts = new object[]
		{
			new object[] {Contracts.Exception},
			new object[] {Contracts.Array}

		};

		/// <summary>
		/// Test for counting objects when it is created
		/// </summary>
		/// <remarks>
		/// ComDebug class is exist ONLY in DEBUG configuration
		/// </remarks>
		[Test]
		[Category( XulRuntimeTestsCategory )]
		[Conditional( "DEBUG" )]
		[TestCaseSource( "TestingContracts" )]
		public void CreatationRefCounterTest( string contract )
		{
			var item = Xpcom.CreateInstance<nsISupports>( contract );

			int comCount = ComDebug.GetComRefCount( item );
			int runtimeWrappersCount = ComDebug.GetRcwRefCount( item );

			int freeCount = Marshal.ReleaseComObject( item );

			Assert.AreEqual( 2, comCount );
			Assert.AreEqual( 1, runtimeWrappersCount );
			Assert.AreEqual( 0, freeCount );
		}

		[Test]
		[Category( XulRuntimeTestsCategory )]
		[Conditional( "DEBUG" )]
		public void QueryInterfaceRefCounterTest()
		{
			var item1 = Xpcom.CreateInstance<nsISupports>( Contracts.Array );

			int comCount1 = ComDebug.GetComRefCount( item1 );
			int rcwCount1 = ComDebug.GetRcwRefCount( item1 );

			var item2 = Xpcom.QueryInterface<nsIArray>( item1 );

			int comCount2 = ComDebug.GetComRefCount( item2 );
			int rcwCount2 = ComDebug.GetRcwRefCount( item2 );


			int free1 = Marshal.ReleaseComObject( item2 );
			int free2 = Marshal.ReleaseComObject( item1 );

			Assert.AreEqual( 0, comCount2 - comCount1 );
			Assert.AreEqual( 1, rcwCount2 - rcwCount1 );
			Assert.AreEqual( 1, free1 );
			Assert.AreEqual( 0, free2 );
		}

		[Test]
		[Category( XulRuntimeTestsCategory )]
		[Conditional( "DEBUG" )]
		public void IsOperatorRefCounterTest()
		{
			// operator is is NOT increment counters
			var item1 = Xpcom.CreateInstance<nsISupports>( Contracts.Array );

			int comCount1 = ComDebug.GetComRefCount( item1 );
			int rcwCount1 = ComDebug.GetRcwRefCount( item1 );

			bool test = item1 is nsIArray;

			int comCount2 = ComDebug.GetComRefCount( item1 );
			int rcwCount2 = ComDebug.GetRcwRefCount( item1 );

			int free = Marshal.ReleaseComObject(item1);

			Assert.AreEqual( 0, comCount2 - comCount1 );
			Assert.AreEqual(0, rcwCount2 - rcwCount1);
			Assert.AreEqual( 0, free );
		}

		[Test]
		[Category( XulRuntimeTestsCategory )]
		[Conditional( "DEBUG" )]
		public void AsOperatorRefCounterTest()
		{
			// operator as is NOT increment counters
			var item1 = Xpcom.CreateInstance<nsISupports>( Contracts.Array );

			int comCount = ComDebug.GetComRefCount( item1 );
			int rcwCount = ComDebug.GetRcwRefCount( item1 );

			nsIArray item2 = item1 as nsIArray;

			int comCount1 = ComDebug.GetComRefCount( item1 );
			int rcwCount1 = ComDebug.GetRcwRefCount( item1 );
			int comCount2 = ComDebug.GetComRefCount( item2 );
			int rcwCount2 = ComDebug.GetRcwRefCount( item2 );

			int free = Marshal.ReleaseComObject(item2);

			Assert.AreEqual( 0, comCount2 - comCount1 );
			Assert.AreEqual( 0, rcwCount2 - rcwCount1 );
			Assert.AreEqual( 0, comCount2 - comCount );
			Assert.AreEqual( 0, rcwCount2 - rcwCount );
			Assert.AreEqual( 0, free );
		}

		[Test]
		[Category( XulRuntimeTestsCategory )]
		[Conditional( "DEBUG" )]
		public void ExplicitOperatorRefCounterTest()
		{
			// operator explicit is NOT increment counters
			var item1 = Xpcom.CreateInstance<nsISupports>( Contracts.Array );

			int comCount = ComDebug.GetComRefCount( item1 );
			int rcwCount = ComDebug.GetRcwRefCount( item1 );

			nsIArray item2 = (nsIArray) item1;

			int comCount1 = ComDebug.GetComRefCount( item1 );
			int rcwCount1 = ComDebug.GetRcwRefCount( item1 );
			int comCount2 = ComDebug.GetComRefCount( item2 );
			int rcwCount2 = ComDebug.GetRcwRefCount( item2 );

			int free = Marshal.ReleaseComObject( item2 );

			Assert.AreEqual( 0, comCount2 - comCount1 );
			Assert.AreEqual( 0, rcwCount2 - rcwCount1 );
			Assert.AreEqual( 0, comCount2 - comCount );
			Assert.AreEqual( 0, rcwCount2 - rcwCount );
			Assert.AreEqual( 0, free );
		}

		[Test]
		[Category(XulRuntimeTestsCategory)]
		[Conditional("DEBUG")]
		public void GetStringCounter()
		{
			var service=Xpcom.GetService2<nsIXULRuntime>(Contracts.XulRuntime);
			int comCount = ComDebug.GetComRefCount(service.Instance);
			int rcwCount = ComDebug.GetRcwRefCount(service.Instance);

			var os=nsString.Get(service.Instance.GetOSAttribute);

			int comCount1 = ComDebug.GetComRefCount(service.Instance);
			int rcwCount1 = ComDebug.GetRcwRefCount(service.Instance);
		}
	}
}