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
		public void GetLastFocusMethod_OfStubbedDOMWindow_ReturnsZero()
		{
			var stubDOMWindow = new StubDOMWindow();
			Assert.AreEqual(0, m_instance.GetLastFocusMethod(stubDOMWindow));			
		}

		[Test]
		public void GetActiveWindowAttribute_ActiveWindowIsNull_ReturnsNull()
		{			
			Assert.IsNull(m_instance.GetActiveWindowAttribute());
		}
	}

	#region Stubs
	internal class StubDOMWindow : nsIDOMWindow
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

		public void GetNameAttribute(nsAStringBase aName)
		{
			throw new NotImplementedException();
		}

		public void SetNameAttribute(nsAStringBase aName)
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

		public nsIDOMCSSStyleDeclaration GetComputedStyle(nsIDOMElement elt, nsAStringBase pseudoElt)
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

		public void GetStatusAttribute(nsAStringBase aStatus)
		{
			throw new NotImplementedException();
		}

		public void SetStatusAttribute(nsAStringBase aStatus)
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

		public void Alert(nsAStringBase text)
		{
			throw new NotImplementedException();
		}

		public bool Confirm(nsAStringBase text)
		{
			throw new NotImplementedException();
		}

		public void Prompt(nsAStringBase aMessage, nsAStringBase aInitial, nsAStringBase retval)
		{
			throw new NotImplementedException();
		}

		public void Print()
		{
			throw new NotImplementedException();
		}

		public nsIVariant ShowModalDialog(nsAStringBase aURI, nsIVariant aArgs, nsAStringBase aOptions)
		{
			throw new NotImplementedException();
		}

		public void PostMessage(IntPtr message, nsAString targetOrigin)
		{
			throw new NotImplementedException();
		}

		public void Atob(nsAStringBase aAsciiString, nsAStringBase retval)
		{
			throw new NotImplementedException();
		}

		public void Btoa(nsAStringBase aBase64Data, nsAStringBase retval)
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

		public nsIDOMMediaQueryList MatchMedia(nsAStringBase media_query_list)
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

		public void GetDefaultStatusAttribute(nsAStringBase aDefaultStatus)
		{
			throw new NotImplementedException();
		}

		public void SetDefaultStatusAttribute(nsAStringBase aDefaultStatus)
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

		public nsIDOMWindow Open(nsAStringBase url, nsAStringBase name, nsAStringBase options)
		{
			throw new NotImplementedException();
		}

		public nsIDOMWindow OpenDialog(nsAStringBase url, nsAStringBase name, nsAStringBase options, nsISupports aExtraArgument)
		{
			throw new NotImplementedException();
		}

		public void UpdateCommands(nsAStringBase action)
		{
			throw new NotImplementedException();
		}

		public bool Find(nsAStringBase str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames, bool showDialog)
		{
			throw new NotImplementedException();
		}

		public ulong GetMozPaintCountAttribute()
		{
			throw new NotImplementedException();
		}

		public int MozRequestAnimationFrame(nsIFrameRequestCallback callback)
		{
			throw new NotImplementedException();
		}

		public void MozCancelRequestAnimationFrame(int frame)
		{
			throw new NotImplementedException();
		}

		public void MozCancelAnimationFrame(int frame)
		{
			throw new NotImplementedException();
		}

		public long GetMozAnimationStartTimeAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMMozURLProperty GetURLAttribute()
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


		public void PostMessage(IntPtr message, nsAStringBase targetOrigin, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnafterprintAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnafterprintAttribute(IntPtr aOnafterprint, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnbeforeprintAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnbeforeprintAttribute(IntPtr aOnbeforeprint, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnbeforeunloadAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnbeforeunloadAttribute(IntPtr aOnbeforeunload, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnhashchangeAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnhashchangeAttribute(IntPtr aOnhashchange, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnmessageAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnmessageAttribute(IntPtr aOnmessage, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnofflineAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnofflineAttribute(IntPtr aOnoffline, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnonlineAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnonlineAttribute(IntPtr aOnonline, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnpopstateAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnpopstateAttribute(IntPtr aOnpopstate, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnpagehideAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnpagehideAttribute(IntPtr aOnpagehide, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnpageshowAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnpageshowAttribute(IntPtr aOnpageshow, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnresizeAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnresizeAttribute(IntPtr aOnresize, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnunloadAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnunloadAttribute(IntPtr aOnunload, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOndevicemotionAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOndevicemotionAttribute(IntPtr aOndevicemotion, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOndeviceorientationAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOndeviceorientationAttribute(IntPtr aOndeviceorientation, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}


		public IntPtr GetOnmouseenterAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnmouseenterAttribute(IntPtr aOnmouseenter, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public IntPtr GetOnmouseleaveAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnmouseleaveAttribute(IntPtr aOnmouseleave, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}


		public void PostMessage(JsVal message, nsAStringBase targetOrigin, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		JsVal nsIDOMWindow.GetOnafterprintAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnafterprintAttribute(JsVal aOnafterprint, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		JsVal nsIDOMWindow.GetOnbeforeprintAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnbeforeprintAttribute(JsVal aOnbeforeprint, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		JsVal nsIDOMWindow.GetOnbeforeunloadAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnbeforeunloadAttribute(JsVal aOnbeforeunload, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		JsVal nsIDOMWindow.GetOnhashchangeAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnhashchangeAttribute(JsVal aOnhashchange, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		JsVal nsIDOMWindow.GetOnmessageAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnmessageAttribute(JsVal aOnmessage, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		JsVal nsIDOMWindow.GetOnofflineAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnofflineAttribute(JsVal aOnoffline, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		JsVal nsIDOMWindow.GetOnonlineAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnonlineAttribute(JsVal aOnonline, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		JsVal nsIDOMWindow.GetOnpopstateAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnpopstateAttribute(JsVal aOnpopstate, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		JsVal nsIDOMWindow.GetOnpagehideAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnpagehideAttribute(JsVal aOnpagehide, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		JsVal nsIDOMWindow.GetOnpageshowAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnpageshowAttribute(JsVal aOnpageshow, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		JsVal nsIDOMWindow.GetOnresizeAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnresizeAttribute(JsVal aOnresize, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		JsVal nsIDOMWindow.GetOnunloadAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnunloadAttribute(JsVal aOnunload, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		JsVal nsIDOMWindow.GetOndevicemotionAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOndevicemotionAttribute(JsVal aOndevicemotion, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		JsVal nsIDOMWindow.GetOndeviceorientationAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOndeviceorientationAttribute(JsVal aOndeviceorientation, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		JsVal nsIDOMWindow.GetOnmouseenterAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnmouseenterAttribute(JsVal aOnmouseenter, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		JsVal nsIDOMWindow.GetOnmouseleaveAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnmouseleaveAttribute(JsVal aOnmouseleave, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}


		public nsIDOMWindow GetRealTopAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMWindow GetRealParentAttribute()
		{
			throw new NotImplementedException();
		}

		public nsIDOMElement GetRealFrameElementAttribute()
		{
			throw new NotImplementedException();
		}


		public JsVal GetOndeviceproximityAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOndeviceproximityAttribute(JsVal aOndeviceproximity, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public JsVal GetOnuserproximityAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOnuserproximityAttribute(JsVal aOnuserproximity, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public JsVal GetOndevicelightAttribute(IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		public void SetOndevicelightAttribute(JsVal aOndevicelight, IntPtr jsContext)
		{
			throw new NotImplementedException();
		}

		#region nsIDOMWindow Members


		public float GetDevicePixelRatioAttribute()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
	#endregion
}