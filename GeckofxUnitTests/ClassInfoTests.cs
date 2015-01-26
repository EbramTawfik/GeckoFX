using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko;
using GeckofxUnitTests.Common;
using NUnit.Framework;

namespace GeckofxUnitTests
{
	/// <summary>
	/// Tests for GetClassInfo (working ONLY for some classes)
	/// </summary>
	[TestFixture]
	public class ClassInfoTests
		: BaseXulrunnerTest
	{
		private const string ClassInfoTestsCategory = "nsIClassInfo";

		[Test]
		[Category(ClassInfoTestsCategory)]
		public void TestClassInfoException()
		{
			var item = Xpcom.CreateInstance2<nsIException>(Contracts.Exception);
			
			var classInfo= item.GetClassInfo();

			Assert.IsNotNull( classInfo );

		}

		[Test]
		[Category(ClassInfoTestsCategory)]
		public void TestClassInfoSystemPrincipal()
		{
			var item = Xpcom.CreateInstance2<nsIPrincipal>(Contracts.SystemPrincipal);

			var classInfo = item.GetClassInfo();

			Assert.IsNotNull(classInfo);
		}
	}
}
