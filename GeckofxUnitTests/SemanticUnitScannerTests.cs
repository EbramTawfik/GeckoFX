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
	public class SemanticUnitScannerTests
	{
		nsISemanticUnitScanner m_instance;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			m_instance = Xpcom.CreateInstance<nsISemanticUnitScanner>("@mozilla.org/intl/semanticunitscanner;1");
			Assert.IsNotNull(m_instance);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			Marshal.ReleaseComObject(m_instance);
		}

		[Test]
		public void Start_NullCharaterSet_DoesNotCrash()
		{
			m_instance.Start(String.Empty);			
		}

		[Test]
		public void Next_SimpleText_FindFirstWord()
		{
			int begin = 0, end = 0;
			string text = "hello world";
			m_instance.Start(String.Empty);
			Assert.IsTrue(m_instance.Next(text, text.Length, 0, true, ref begin, ref end));
			Assert.AreEqual(0, begin);
			Assert.AreEqual(5, end);
		}
	}
}