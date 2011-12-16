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

		public nsIDOMCSSStyleDeclaration GetComputedStyle(nsIDOMElement elt, nsAString pseudoElt)
		{
			throw new NotImplementedException();
		}

		public nsIDOMOfflineResourceList GetApplicationCacheAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMEventTarget GetWindowRootAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMWindow GetWindowAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMWindow GetSelfAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMLocation GetLocationAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMHistory GetHistoryAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMBarProp GetLocationbarAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMBarProp GetMenubarAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMBarProp GetPersonalbarAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMBarProp GetStatusbarAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMBarProp GetToolbarAttribute()
		{
			throw new NotImplementedException();
		}

		public void GetStatusAttribute(nsAString aStatus)
		{
			throw new NotImplementedException();
		}

		public void SetStatusAttribute(nsAString aStatus)
		{
			throw new NotImplementedException();
		}

		public void Close()
		{
			throw new NotImplementedException();
		}

		public void Stop()
		{
			throw new NotImplementedException();
		}

		public void Focus()
		{
			throw new NotImplementedException();
		}

		public void Blur()
		{
			throw new NotImplementedException();
		}

		public uint GetLengthAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMWindow GetOpenerAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOpenerAttribute(nsIDOMWindow aOpener)
		{
			throw new NotImplementedException();
		}

		public nsIDOMElement GetFrameElementAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMNavigator GetNavigatorAttribute()
		{
			throw new NotImplementedException();
		}

		public void Alert(nsAString text)
		{
			throw new NotImplementedException();
		}

		public bool Confirm(nsAString text)
		{
			throw new NotImplementedException();
		}

		public void Prompt(nsAString aMessage, nsAString aInitial, nsAString retval)
		{
			throw new NotImplementedException();
		}

		public void Print()
		{
			throw new NotImplementedException();
		}

		public nsIVariant ShowModalDialog(nsAString aURI, nsIVariant aArgs, nsAString aOptions)
		{
			throw new NotImplementedException();
		}

		public void PostMessage(IntPtr message, nsAString targetOrigin)
		{
			throw new NotImplementedException();
		}

		public void Atob(nsAString aAsciiString, nsAString retval)
		{
			throw new NotImplementedException();
		}

		public void Btoa(nsAString aBase64Data, nsAString retval)
		{
			throw new NotImplementedException();
		}

		public nsIDOMStorage GetSessionStorageAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMStorage GetLocalStorageAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMMediaQueryList MatchMedia(nsAString media_query_list)
		{
			throw new NotImplementedException();
		}

		public nsIDOMScreen GetScreenAttribute()
		{
			throw new NotImplementedException();
		}

		public int GetInnerWidthAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetInnerWidthAttribute(int aInnerWidth)
		{
			throw new NotImplementedException();
		}

		public int GetInnerHeightAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetInnerHeightAttribute(int aInnerHeight)
		{
			throw new NotImplementedException();
		}

		public int GetPageXOffsetAttribute()
		{
			throw new NotImplementedException();
		}

		public int GetPageYOffsetAttribute()
		{
			throw new NotImplementedException();
		}

		public void Scroll(int xScroll, int yScroll)
		{
			throw new NotImplementedException();
		}

		public int GetScreenXAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetScreenXAttribute(int aScreenX)
		{
			throw new NotImplementedException();
		}

		public int GetScreenYAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetScreenYAttribute(int aScreenY)
		{
			throw new NotImplementedException();
		}

		public int GetOuterWidthAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOuterWidthAttribute(int aOuterWidth)
		{
			throw new NotImplementedException();
		}

		public int GetOuterHeightAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOuterHeightAttribute(int aOuterHeight)
		{
			throw new NotImplementedException();
		}

		public nsIDOMWindow GetContentAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIPrompt GetPrompterAttribute()
		{
			throw new NotImplementedException();
		}

		public bool GetClosedAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMCrypto GetCryptoAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMPkcs11 GetPkcs11Attribute()
		{
			throw new NotImplementedException();
		}

		public nsIControllers GetControllersAttribute()
		{
			throw new NotImplementedException();
		}

		public void GetDefaultStatusAttribute(nsAString aDefaultStatus)
		{
			throw new NotImplementedException();
		}

		public void SetDefaultStatusAttribute(nsAString aDefaultStatus)
		{
			throw new NotImplementedException();
		}

		public float GetMozInnerScreenXAttribute()
		{
			throw new NotImplementedException();
		}

		public float GetMozInnerScreenYAttribute()
		{
			throw new NotImplementedException();
		}

		public int GetScrollMaxXAttribute()
		{
			throw new NotImplementedException();
		}

		public int GetScrollMaxYAttribute()
		{
			throw new NotImplementedException();
		}

		public bool GetFullScreenAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetFullScreenAttribute(bool aFullScreen)
		{
			throw new NotImplementedException();
		}

		public void Back()
		{
			throw new NotImplementedException();
		}

		public void Forward()
		{
			throw new NotImplementedException();
		}

		public void Home()
		{
			throw new NotImplementedException();
		}

		public void MoveTo(int xPos, int yPos)
		{
			throw new NotImplementedException();
		}

		public void MoveBy(int xDif, int yDif)
		{
			throw new NotImplementedException();
		}

		public void ResizeTo(int width, int height)
		{
			throw new NotImplementedException();
		}

		public void ResizeBy(int widthDif, int heightDif)
		{
			throw new NotImplementedException();
		}

		public nsIDOMWindow Open(nsAString url, nsAString name, nsAString options)
		{
			throw new NotImplementedException();
		}

		public nsIDOMWindow OpenDialog(nsAString url, nsAString name, nsAString options, nsISupports aExtraArgument)
		{
			throw new NotImplementedException();
		}

		public void UpdateCommands(nsAString action)
		{
			throw new NotImplementedException();
		}

		public bool Find(nsAString str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames, bool showDialog)
		{
			throw new NotImplementedException();
		}

		public uint GetMozPaintCountAttribute()
		{
			throw new NotImplementedException();
		}

		public void MozRequestAnimationFrame(nsIAnimationFrameListener aListener)
		{
			throw new NotImplementedException();
		}

		public int GetMozAnimationStartTimeAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMMozURLProperty GetURLAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMStorageList GetGlobalStorageAttribute()
		{
			throw new NotImplementedException();
		}


		public IntPtr GetOnafterprintAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOnafterprintAttribute(IntPtr aOnafterprint)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnbeforeprintAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOnbeforeprintAttribute(IntPtr aOnbeforeprint)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnbeforeunloadAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOnbeforeunloadAttribute(IntPtr aOnbeforeunload)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnhashchangeAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOnhashchangeAttribute(IntPtr aOnhashchange)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnmessageAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOnmessageAttribute(IntPtr aOnmessage)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnofflineAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOnofflineAttribute(IntPtr aOnoffline)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnonlineAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOnonlineAttribute(IntPtr aOnonline)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnpopstateAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOnpopstateAttribute(IntPtr aOnpopstate)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnpagehideAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOnpagehideAttribute(IntPtr aOnpagehide)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnpageshowAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOnpageshowAttribute(IntPtr aOnpageshow)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnresizeAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOnresizeAttribute(IntPtr aOnresize)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnunloadAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOnunloadAttribute(IntPtr aOnunload)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOndevicemotionAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOndevicemotionAttribute(IntPtr aOndevicemotion)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOndeviceorientationAttribute()
		{
			throw new NotImplementedException();
		}

		public void SetOndeviceorientationAttribute(IntPtr aOndeviceorientation)
		{
			throw new NotImplementedException();
		}
	}
	#endregion
}