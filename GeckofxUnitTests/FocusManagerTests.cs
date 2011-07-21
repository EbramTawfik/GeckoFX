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
	public class FocusManagerTests
	{
		nsIFocusManager m_instance;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			m_instance = Xpcom.CreateInstance<nsIFocusManager>("@mozilla.org/focus-manager;1");
			Assert.IsNotNull(m_instance);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			Marshal.ReleaseComObject(m_instance);
		}

		[Test]
		public void GetLastFocusMethod_OfMockedDOMWindow_ReturnsZero()
		{
			var mockDOMWindow = new MockDOMWindow();			
			Assert.AreEqual(0, m_instance.GetLastFocusMethod(mockDOMWindow));			
		}
	}

	#region Mocks
	internal class MockDOMWindow : nsIDOMWindow
	{

		public nsIDOMDocument GetDocumentAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMWindow GetParentAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMWindow GetTopAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMBarProp GetScrollbarsAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMWindowCollection GetFramesAttribute()
		{
			throw new NotImplementedException();
		}

		public void GetNameAttribute(nsAString aName)
		{
			throw new NotImplementedException();
		}

		public void SetNameAttribute(nsAString aName)
		{
			throw new NotImplementedException();
		}

		public float GetTextZoomAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetTextZoomAttribute(float aTextZoom)
		{
			throw new NotImplementedException();
		}

		public int GetScrollXAttribute()
		{
			throw new NotImplementedException();
		}

		public int GetScrollYAttribute()
		{
			throw new NotImplementedException();
		}

		public void ScrollTo(int xScroll, int yScroll)
		{
			throw new NotImplementedException();
		}

		public void ScrollBy(int xScrollDif, int yScrollDif)
		{
			throw new NotImplementedException();
		}

		public nsISelection GetSelection()
		{
			throw new NotImplementedException();
		}

		public void ScrollByLines(int numLines)
		{
			throw new NotImplementedException();
		}

		public void ScrollByPages(int numPages)
		{
			throw new NotImplementedException();
		}

		public void SizeToContent()
		{
			throw new NotImplementedException();
		}
	}
	#endregion
}