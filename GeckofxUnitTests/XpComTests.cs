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
	public class XpComTests
	{
		const string XulRunnerLocation = @"C:\Program Files (x86)\Mozilla Firefox";

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XulRunnerLocation);
		}

		[Test]
		public void Alloc_XpcomInitialize_ReturnsValidPointer()
		{			
			IntPtr memory = Xpcom.Alloc(100);
			Assert.IsFalse(memory == IntPtr.Zero);
			Xpcom.Free(memory);			
		}
		
		[Test]
		public void Realloc_XpcomInitialize_ReturnsValidPointer()
		{		
			IntPtr memory = Xpcom.Alloc(100);			
			Xpcom.Realloc(memory, 200);
			Assert.IsFalse(memory == IntPtr.Zero);
			Xpcom.Free(memory);
		}

		[Test]
		public void CreateInstance_CreatingnsWebBrowser_ReturnsValidInstance()
		{
			var webBrowser = Xpcom.CreateInstance<nsIWebBrowser>("@mozilla.org/embedding/browser/nsWebBrowser;1");
			Marshal.ReleaseComObject(webBrowser);
		}
	}
}
