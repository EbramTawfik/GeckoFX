#region ***** BEGIN LICENSE BLOCK *****
/* Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Skybound Software code.
 *
 * The Initial Developer of the Original Code is Skybound Software.
 * Portions created by the Initial Developer are Copyright (C) 2008-2009
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 */
#endregion END LICENSE BLOCK

using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Runtime.CompilerServices;

namespace Skybound.Gecko
{
	[Guid("00000000-0000-0000-c000-000000000046"), ComImport]
	public interface nsISupports
	{
		object QueryInterface(ref Guid iid);
		int AddRef();
		int Release();
	}
	
	[Guid("a88e5a60-205a-4bb1-94e1-2628daf51eae"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsInterfaces
	{		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		object GetClassObject(ref Guid aClass, ref Guid aIID);
				
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		object GetClassObjectByContractID(string aContractID, ref Guid aIID);
				
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		object CreateInstance(ref Guid aClass, [MarshalAs(UnmanagedType.Interface)] nsISupports aDelegate, ref Guid aIID);
						
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		object CreateInstanceByContractID([MarshalAs(UnmanagedType.LPStr)] string aContractID, [MarshalAs(UnmanagedType.Interface)] nsISupports aDelegate, ref Guid aIID);
	}
	
	[Guid("8bb35ed9-e332-462d-9155-4a002ab5c958"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIServiceManager
	{
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		object GetService(ref Guid aClass, ref Guid aIID);
		
		[return: MarshalAs(UnmanagedType.Interface)] 		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		object GetServiceByContractID([MarshalAs(UnmanagedType.LPStr)] string aContractID, ref Guid aIID);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsServiceInstantiated(ref Guid aClass, ref Guid aIID);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsServiceInstantiatedByContractID([MarshalAs(UnmanagedType.LPStr)] string aContractID, ref Guid aIID);
	}
	
	[Guid("69E5DF00-7B8B-11d3-AF61-00A024FFC08C"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWebBrowser
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddWebBrowserListener([MarshalAs(UnmanagedType.Interface)] nsIWeakReference aListener, ref Guid aIID);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveWebBrowserListener([MarshalAs(UnmanagedType.Interface)] nsIWeakReference aListener, ref Guid aIID);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebBrowserChrome GetContainerWindow();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContainerWindow([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserChrome containerWindow);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIContentListener GetParentURIContentListener();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParentURIContentListener([MarshalAs(UnmanagedType.IUnknown)] object parentURIContentListener);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetContentDOMWindow();
	}
	
	[Guid("94928ab3-8b63-11d3-989d-001083010e9b"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIURIContentListener
	{
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnStartURIOpen([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool DoContent([MarshalAs(UnmanagedType.LPStr)] string aContentType, bool aIsContentPreferred, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, out IntPtr aContentHandler); // aContentHandler=nsIStreamListener
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsPreferred([MarshalAs(UnmanagedType.LPStr)] string aContentType, [MarshalAs(UnmanagedType.LPStr)] out string aDesiredContentType);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CanHandleContent([MarshalAs(UnmanagedType.LPStr)] string aContentType, [MarshalAs(UnmanagedType.Bool)]bool aIsContentPreferred, [MarshalAs(UnmanagedType.LPStr)] out string aDesiredContentType);
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetLoadCookie();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadCookie([MarshalAs(UnmanagedType.Interface)] nsISupports aLoadCookie);
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIContentListener GetParentContentListener();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParentContentListener([MarshalAs(UnmanagedType.Interface)]nsIURIContentListener aParentContentListener);
	}
	
	static class nsIWebBrowserChromeConstants
	{
		public const int STATUS_SCRIPT = 1;
		public const int STATUS_SCRIPT_DEFAULT = 2;
		public const int STATUS_LINK = 3;
		
		public const int CHROME_DEFAULT = 1;
		public const int CHROME_WINDOW_BORDERS = 2;
		public const int CHROME_WINDOW_CLOSE = 4;
		public const int CHROME_WINDOW_RESIZE = 8;
		public const int CHROME_MENUBAR = 16;
		public const int CHROME_TOOLBAR = 32;
		public const int CHROME_LOCATIONBAR = 64;
		public const int CHROME_STATUSBAR = 128;
		public const int CHROME_PERSONAL_TOOLBAR = 256;
		public const int CHROME_SCROLLBARS = 512;
		public const int CHROME_TITLEBAR = 1024;
		public const int CHROME_EXTRA = 2048;
		public const int CHROME_WITH_SIZE = 4096;
		public const int CHROME_WITH_POSITION = 8192;
		public const int CHROME_WINDOW_MIN = 16384;
		public const int CHROME_WINDOW_POPUP = 32768;
		public const int CHROME_WINDOW_RAISED = 33554432;
		public const int CHROME_WINDOW_LOWERED = 67108864;
		public const int CHROME_CENTER_SCREEN = 134217728;
		public const int CHROME_DEPENDENT = 268435456;
		public const int CHROME_MODAL = 536870912;
		public const int CHROME_OPENAS_DIALOG = 1073741824;
		public const int CHROME_OPENAS_CHROME = unchecked((int)2147483648);
		public const int CHROME_ALL = 4094;
	}
	
	[Guid("ba434c60-9d52-11d3-afb0-00a024ffc08c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWebBrowserChrome
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStatus(int statusType, [MarshalAs(UnmanagedType.LPWStr)] string status);
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebBrowser GetWebBrowser();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWebBrowser([MarshalAs(UnmanagedType.Interface)] nsIWebBrowser webBrowser);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetChromeFlags();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChromeFlags(int flags);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DestroyBrowserWindow();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SizeBrowserTo(int cx, int cy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowAsModal();
		
		[return: MarshalAs(UnmanagedType.Bool)]		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsWindowModal();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExitModalEventLoop(int status);
	}
	
	[Guid("30465632-a777-44cc-90f9-8145475ef999"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWindowCreator
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebBrowserChrome CreateChromeWindow([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserChrome parent, uint chromeFlags);
	}
	
	[Guid("002286a8-494b-43b3-8ddd-49e3fc50622b"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWindowWatcher
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow OpenWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPStr)] string aUrl, [MarshalAs(UnmanagedType.LPStr)] string aName, [MarshalAs(UnmanagedType.LPStr)] string aFeatures, [MarshalAs(UnmanagedType.Interface)] nsISupports aArguments);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterNotification([MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterNotification([MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetWindowEnumerator();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetNewPrompter([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetNewAuthPrompter([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWindowCreator([MarshalAs(UnmanagedType.Interface)] nsIWindowCreator creator);
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebBrowserChrome GetChromeForWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetWindowByName([MarshalAs(UnmanagedType.LPWStr)] string aTargetName, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aCurrentWindow);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetActiveWindow();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetActiveWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aActiveWindow);
	}
	
	[Guid("5119ac7f-81dd-4061-96a7-71f2cf5efee4"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWindowProvider
	{
		[PreserveSig]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int provideWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, uint aChromeFlags, [MarshalAs(UnmanagedType.Bool)] bool aPositionSpecified, [MarshalAs(UnmanagedType.Bool)] bool aSizeSpecified, nsIURI aURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString aName,[MarshalAs(UnmanagedType.LPStruct)] nsAString aFeatures, [MarshalAs(UnmanagedType.Bool)] out bool aWindowIsNew, [MarshalAs(UnmanagedType.Interface)] out nsIDOMWindow ret);
	}
	
	[Guid("b6c2f9e1-53a0-45f2-a2b8-fe37861fe8a8"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIXULWindow
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetDocShell(); // nsIDocShell
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIntrinsicallySized();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIntrinsicallySized([MarshalAs(UnmanagedType.Bool)] bool aIntrinsicallySized);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetPrimaryContentShell();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetContentShellById([MarshalAs(UnmanagedType.LPWStr)] string ID);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddChildWindow([MarshalAs(UnmanagedType.Interface)]nsIXULWindow aChild);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveChildWindow([MarshalAs(UnmanagedType.Interface)]nsIXULWindow aChild);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Center([MarshalAs(UnmanagedType.Interface)]nsIXULWindow aRelative, [MarshalAs(UnmanagedType.Bool)] bool aScreen, [MarshalAs(UnmanagedType.Bool)] bool aAlert);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowModal();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetZLevel();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetZLevel(uint aZLevel);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetContextFlags();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContextFlags(uint aContextFlags);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetChromeFlags();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChromeFlags(uint aChromeFlags);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXULWindow CreateNewWindow(uint aChromeFlags, [MarshalAs(UnmanagedType.IUnknown)] object aAppShell); // aAppShell=nsIAppShell
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetXULBrowserWindow(); // nsIXULBrowserWindow
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXULBrowserWindow(IntPtr aXULBrowserWindow); // nsIXULBrowserWindow
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ApplyChromeFlags();
	}
	
	[Guid("93a28ba2-7e22-11d9-9b6f-000a95d535fa"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIAppShellService
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXULWindow CreateTopLevelWindow([MarshalAs(UnmanagedType.Interface)]nsIXULWindow aParent, [MarshalAs(UnmanagedType.Interface)]nsIURI aUrl, uint aChromeMask, int aInitialWidth, int aInitialHeight, [MarshalAs(UnmanagedType.IUnknown)] object aAppShell);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateHiddenWindow([MarshalAs(UnmanagedType.IUnknown)] object aAppShell); // nsIAppShell
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DestroyHiddenWindow();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXULWindow GetHiddenWindow();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetHiddenDOMWindow(); // nsIDOMWindowInternal
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHiddenWindowAndJSContext(out IntPtr aHiddenDOMWindow, IntPtr aJSContext); // nsIDOMWindowInternal JSContext
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetApplicationProvidedHiddenWindow();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterTopLevelWindow([MarshalAs(UnmanagedType.Interface)]nsIXULWindow aWindow);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterTopLevelWindow([MarshalAs(UnmanagedType.Interface)]nsIXULWindow aWindow);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TopLevelWindowIsModal([MarshalAs(UnmanagedType.Interface)]nsIXULWindow aWindow, [MarshalAs(UnmanagedType.Bool)] bool aModal);
	
	}
	
	[Guid("3aaad312-e09d-4010-a013-78ef653dac99"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsPIWindowWatcher
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddWindow([MarshalAs(UnmanagedType.IUnknown)]nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.IUnknown)]nsIWebBrowserChrome aChrome);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveWindow([MarshalAs(UnmanagedType.IUnknown)]nsIDOMWindow aWindow);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow OpenWindowJS([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPStr)] string aUrl, [MarshalAs(UnmanagedType.LPStr)] string aName, [MarshalAs(UnmanagedType.LPStr)] string aFeatures, [MarshalAs(UnmanagedType.Bool)] bool aDialog, [MarshalAs(UnmanagedType.IUnknown)] object aArgs);

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem FindItemWithName([MarshalAs(UnmanagedType.LPWStr)] string aName, [MarshalAs(UnmanagedType.Interface)]nsIDocShellTreeItem aRequestor, [MarshalAs(UnmanagedType.Interface)]nsIDocShellTreeItem aOriginalRequestor);
	}
	
	[Guid("db242e01-e4d9-11d2-9dde-000064657374"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIObserver
	{		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Observe(nsISupports aSubject, [MarshalAs(UnmanagedType.LPStr)] string aTopic, [MarshalAs(UnmanagedType.LPWStr)] string aData);
	}
	
	[Guid("046bc8a0-8015-11d3-af70-00a024ffc08c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIBaseWindow
	{
		//void InitWindow(nativeWindow parentNativeWindow, nsIWidget * parentWidget, int x, int y, int cx, int cy);
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWindow(IntPtr parentNativeWindow, IntPtr /* nsIWidget */ parentWidget, int x, int y, int cx, int cy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Create();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Destroy();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPosition(int x, int y);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPosition(out int x, out int y);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSize(int cx, int cy, [MarshalAs(UnmanagedType.Bool)] bool fRepaint);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSize(out int cx, out int cy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPositionAndSize(int x, int y, int cx, int cy, [MarshalAs(UnmanagedType.Bool)] bool fRepaint);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPositionAndSize(out int x, out int y, out int cx, out int cy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Repaint([MarshalAs(UnmanagedType.Bool)] bool force);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetParentWidget(); // returns: nsIWidget
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParentWidget(IntPtr aParentWidget);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetParentNativeWindow(); // returns: nativeWindow
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParentNativeWindow(IntPtr aParentNativeWindow);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetVisibility();
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetVisibility(bool aVisibility);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetEnabled();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEnabled([MarshalAs(UnmanagedType.Bool)] bool aEnabled);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBlurSuppression();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBlurSuppression([MarshalAs(UnmanagedType.Bool)]bool aBlurSuppression);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetMainWidget(); // returns: nsIWidget
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFocus();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPWStr)] 
		string GetTitle();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitle([MarshalAs(UnmanagedType.LPWStr)] string aTitle); 
	}
	
	static class nsIWebNavigationConstants
	{
		public const int LOAD_FLAGS_MASK = 65535;
		public const int LOAD_FLAGS_NONE = 0;
		public const int LOAD_FLAGS_IS_REFRESH = 16;
		public const int LOAD_FLAGS_IS_LINK = 32;
		public const int LOAD_FLAGS_BYPASS_HISTORY = 64;
		public const int LOAD_FLAGS_REPLACE_HISTORY = 128;
		public const int LOAD_FLAGS_BYPASS_CACHE = 256;
		public const int LOAD_FLAGS_BYPASS_PROXY = 512;
		public const int LOAD_FLAGS_CHARSET_CHANGE = 1024;
		public const int LOAD_FLAGS_STOP_CONTENT = 2048;
		public const int LOAD_FLAGS_FROM_EXTERNAL = 4096;
		public const int LOAD_FLAGS_ALLOW_THIRD_PARTY_FIXUP = 8192;
		public const int LOAD_FLAGS_FIRST_LOAD = 16384;

		/****************************************************************************
		* The following flags may be passed as the stop flags parameter to the stop
		* method defined on this interface.
		*/
		public const int STOP_NETWORK = 1;
		public const int STOP_CONTENT = 2;
		public const int STOP_ALL = 3;
	}
	
	[Guid("f5d9e7b0-d930-11d3-b057-00a024ffc08c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWebNavigation
	{
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		bool GetCanGoBack();
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCanGoForward();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GoBack();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GoForward();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GotoIndex(int index);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int LoadURI([MarshalAs(UnmanagedType.LPWStr)] string aURI, uint aLoadFlags, [MarshalAs(UnmanagedType.Interface)]nsIURI aReferrer, [MarshalAs(UnmanagedType.Interface)]nsIInputStream aPostData, [MarshalAs(UnmanagedType.Interface)]nsIInputStream aHeaders);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Reload(uint aReloadFlags);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Stop(uint aStopFlags);
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument GetDocument();
				
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr /*nsURI*/ GetCurrentURI();
				
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr /*nsIURI*/ GetReferringURI();
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHistory GetSessionHistory();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSessionHistory([MarshalAs(UnmanagedType.IUnknown)] object aSessionHistory);
	}
	
	[Guid("3b07f591-e8e1-11d4-9882-00c04fa02f40"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsISHistoryListener
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnHistoryNewEntry([MarshalAs(UnmanagedType.Interface)]nsIURI aNewURI);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnHistoryGoBack([MarshalAs(UnmanagedType.Interface)]nsIURI aBackURI);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnHistoryGoForward([MarshalAs(UnmanagedType.Interface)]nsIURI aForwardURI);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnHistoryReload(nsIURI aReloadURI, uint aReloadFlags);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnHistoryGotoIndex(int aIndex, nsIURI aGotoURI);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnHistoryPurge(int aNumEntries);		
	}
	
	[Guid("d1899240-f9d2-11d2-bdd6-000064657374"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsISimpleEnumerator
	{
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasMoreElements();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetNext();
	}
	
	[Guid("9c5d3c58-1dd1-11b2-a1c9-f3699284657a"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIWebBrowserFocus
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Activate();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Deactivate();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFocusAtFirstElement();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFocusAtLastElement();
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetFocusedWindow();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFocusedWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aFocusedWindow);
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetFocusedElement();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFocusedElement([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aFocusedElement);		
	}
	
	[Guid("dd4e0a6a-210f-419a-ad85-40e8543b9465"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWebBrowserPersist
	{
		// nsICancelable:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Cancel(int aReason);

		// nsIWebBrowserPersist:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetPersistFlags();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPersistFlags(uint aPersistFlags);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetCurrentState();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetResult();
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebProgressListener GetProgressListener();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProgressListener([MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener aProgressListener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SaveURI([MarshalAs(UnmanagedType.Interface)]nsIURI aURI, [MarshalAs(UnmanagedType.Interface)]nsISupports aCacheKey, [MarshalAs(UnmanagedType.Interface)]nsIURI aReferrer, IntPtr aPostData, [MarshalAs(UnmanagedType.LPStr)] string aExtraHeaders, [MarshalAs(UnmanagedType.Interface)]nsISupports aFile); // aPostData=nsIInputStream
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SaveChannel(IntPtr aChannel, [MarshalAs(UnmanagedType.Interface)] nsISupports aFile); // aChannel=nsIChannel
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SaveDocument([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aDocument, [MarshalAs(UnmanagedType.IUnknown)] object aFile, [MarshalAs(UnmanagedType.Interface)] nsISupports aDataPath, [MarshalAs(UnmanagedType.LPStr)] string aOutputContentType, uint aEncodingFlags, uint aWrapColumn);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CancelSave();
	}
	
	[Guid("7fb719b3-d804-4964-9596-77cf924ee314"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIContextMenuListener2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnShowContextMenu(uint aContextFlags, nsIContextMenuInfo aUtils); 
	}
	
	[Guid("2f977d56-5485-11d4-87e2-0010a4e75ef2"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIContextMenuInfo
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEvent GetMouseEvent();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetTargetNode();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int GetAssociatedLink([MarshalAs(UnmanagedType.LPStruct)]nsAString aAssociatedLink);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgIContainer GetImageContainer();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int GetImageSrc([MarshalAs(UnmanagedType.Interface)]out nsIURI result);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgIContainer GetBackgroundImageContainer();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int GetBackgroundImageSrc([MarshalAs(UnmanagedType.Interface)]out nsIURI result); 
	}
	
	[Guid("1a6290e6-8285-4e10-963d-d001f8d327b8"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface imgIContainer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init(int aWidth, int aHeight, IntPtr aObserver); // imgIContainerObserver
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetPreferredAlphaChannelFormat(); // gfx_format
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetWidth();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetHeight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetCurrentFrame(); // gfxIImageFrame
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetNumFrames();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetAnimationMode();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAnimationMode(ushort aAnimationMode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetFrameAt(uint index); // gfxIImageFrame
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendFrame(IntPtr item); // gfxIImageFrame
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveFrame(IntPtr item); // gfxIImageFrame
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndFrameDecode(uint framenumber, uint timeout);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DecodingComplete();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Clear();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartAnimation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StopAnimation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetAnimation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLoopCount();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoopCount(int aLoopCount);		
	}
	
	[Guid("033a1470-8b2a-11d3-af88-00a024ffc08c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIInterfaceRequestor
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetInterface(ref Guid uuid);
	}
	
	static class nsIEmbeddingSiteWindowConstants
	{
		public const int DIM_FLAGS_POSITION = 1;
		public const int DIM_FLAGS_SIZE_INNER = 2;
		public const int DIM_FLAGS_SIZE_OUTER = 4;
	}
	
	[Guid("3e5432cd-9568-4bd1-8cbe-d50aba110743"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIEmbeddingSiteWindow
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDimensions(uint flags, int x, int y, int cx, int cy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]	
		void GetDimensions(uint flags, ref int x, ref int y, ref int cx, ref int cy);
				
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void SetFocus();
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetVisibility();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetVisibility([MarshalAs(UnmanagedType.Bool)] bool aVisibility);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPWStr)] string GetTitle();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitle([MarshalAs(UnmanagedType.LPWStr)] string aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetSiteWindow();
	}
	
	[Guid("e932bf55-0a64-4beb-923a-1f32d3661044"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIEmbeddingSiteWindow2 : nsIEmbeddingSiteWindow
	{	
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDimensions(uint flags, int x, int y, int cx, int cy);
				
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		new void GetDimensions(uint flags, ref int x, ref int y, ref int cx, ref int cy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetFocus();
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetVisibility();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetVisibility([MarshalAs(UnmanagedType.Bool)] bool aVisibility);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPWStr)] new string GetTitle();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTitle([MarshalAs(UnmanagedType.LPWStr)] string aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr GetSiteWindow();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Blur();
	}
	
	[Guid("29fb2a18-1dd2-11b2-8dd9-a6fd5d5ad12f"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOM3Node
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBaseURI([MarshalAs(UnmanagedType.LPStruct)] nsAString aBaseURI);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort CompareDocumentPosition(nsIDOMNode other);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextContent([MarshalAs(UnmanagedType.LPStruct)] nsAString aTextContent);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextContent([MarshalAs(UnmanagedType.LPStruct)] nsAString aTextContent);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSameNode([MarshalAs(UnmanagedType.Interface)]nsIDOMNode other);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LookupPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsDefaultNamespace([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LookupNamespaceURI([MarshalAs(UnmanagedType.LPStruct)] nsAString prefix,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsEqualNode(nsIDOMNode arg);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetFeature([MarshalAs(UnmanagedType.LPStruct)]nsAString feature,[MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr SetUserData([MarshalAs(UnmanagedType.LPStr)] string key, IntPtr data, IntPtr handler); // data=nsIVariant, handler=nsIDOMUserDataHandler, returns nsIVariant
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetUserData([MarshalAs(UnmanagedType.LPStr)] string key); // returns nsIVariant
	}
	
	[Guid("9188bc86-f92e-11d2-81ef-0060083a0bcf"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsISupportsWeakReference
	{
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWeakReference GetWeakReference();
	}
	
	[Guid("9188bc85-f92e-11d2-81ef-0060083a0bcf"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWeakReference
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr QueryReferent(ref Guid uuid);
	}
	
	[Guid("7d935d63-6d2a-4600-afb5-9a4f7d68b825"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDocShellTreeItem
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPWStr)] string GetName();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetName([MarshalAs(UnmanagedType.LPWStr)] string aName);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool NameEquals([MarshalAs(UnmanagedType.LPWStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetItemType();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemType(int aItemType);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetParent();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetSameTypeParent();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetRootTreeItem();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetSameTypeRootTreeItem();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem FindItemWithName([MarshalAs(UnmanagedType.LPWStr)] string name, [MarshalAs(UnmanagedType.IUnknown)] object aRequestor, [MarshalAs(UnmanagedType.Interface)]nsIDocShellTreeItem aOriginalRequestor);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetTreeOwner(); // nsIDocShellTreeOwner
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTreeOwner(IntPtr treeOwner);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetChildOffset();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChildOffset(int aChildOffset); 		
	}
	
	[Guid("09b54ec1-d98a-49a9-bc95-3219e8b55089"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDocShellTreeItem19
	{
		// nsIDocShellTreeNode:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetChildCount();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddChild([MarshalAs(UnmanagedType.Interface)]nsIDocShellTreeItem child);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveChild([MarshalAs(UnmanagedType.Interface)]nsIDocShellTreeItem child);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetChildAt(int index);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem FindChildWithName([MarshalAs(UnmanagedType.LPWStr)] string aName, [MarshalAs(UnmanagedType.Bool)] bool aRecurse, [MarshalAs(UnmanagedType.Bool)]bool aSameType, [MarshalAs(UnmanagedType.Interface)]nsIDocShellTreeItem aRequestor, [MarshalAs(UnmanagedType.Interface)]nsIDocShellTreeItem aOriginalRequestor);

		// nsIDocShellTreeItem:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPWStr)] string GetName();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetName([MarshalAs(UnmanagedType.LPWStr)] string aName);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool NameEquals([MarshalAs(UnmanagedType.LPWStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetItemType();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemType(int aItemType);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetParent();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetSameTypeParent();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetRootTreeItem();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetSameTypeRootTreeItem();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem FindItemWithName([MarshalAs(UnmanagedType.LPWStr)] string name, [MarshalAs(UnmanagedType.Interface)]nsISupports aRequestor, [MarshalAs(UnmanagedType.Interface)]nsIDocShellTreeItem aOriginalRequestor);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetTreeOwner(); // nsIDocShellTreeOwner
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTreeOwner(IntPtr treeOwner); // nsIDocShellTreeOwner
	}
	
	static class nsIDocShellTreeItemConstants
	{
		public const int typeChrome = 0;
		public const int typeContent = 1;
		public const int typeContentWrapper = 2;
		public const int typeChromeWrapper = 3;
		public const int typeAll = 2147483647;
	}
	
	static class nsIWebProgressListenerConstants
	{
		public const int STATE_START = 1;
		public const int STATE_REDIRECTING = 2;
		public const int STATE_TRANSFERRING = 4;
		public const int STATE_NEGOTIATING = 8;
		public const int STATE_STOP = 16;
		public const int STATE_IS_REQUEST = 65536;
		public const int STATE_IS_DOCUMENT = 131072;
		public const int STATE_IS_NETWORK = 262144;
		public const int STATE_IS_WINDOW = 524288;
		public const int STATE_RESTORING = 16777216;
		public const int STATE_IS_INSECURE = 4;
		public const int STATE_IS_BROKEN = 1;
		public const int STATE_IS_SECURE = 2;
		public const int STATE_SECURE_HIGH = 262144;
		public const int STATE_SECURE_MED = 65536;
		public const int STATE_SECURE_LOW = 131072;
	}
	
	[Guid("570f39d1-efd0-11d3-b093-00a024ffc08c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIWebProgressListener
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStateChange([MarshalAs(UnmanagedType.Interface)]nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)]nsIRequest aRequest, int aStateFlags, int aStatus);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnProgressChange([MarshalAs(UnmanagedType.Interface)]nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)]nsIRequest aRequest, int aCurSelfProgress, int aMaxSelfProgress, int aCurTotalProgress, int aMaxTotalProgress);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnLocationChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsIURI aLocation);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStatusChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, int aStatus, [MarshalAs(UnmanagedType.LPWStr)] string aMessage);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnSecurityChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, int aState); 
	}
	
	[Guid("ef6bfbd2-fd46-48d8-96b7-9f8f0fd387fe"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIRequest
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetName([MarshalAs(UnmanagedType.LPStruct)]nsACString aName);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsPending();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetStatus();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Cancel(int aStatus);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Suspend();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Resume();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetLoadGroup(); // nsILoadGroup
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadGroup(IntPtr aLoadGroup);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLoadFlags();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadFlags(int aLoadFlags);
	}
	
	[Guid("570f39d0-efd0-11d3-b093-00a024ffc08c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIWebProgress
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddProgressListener([MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener aListener, int aNotifyMask);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveProgressListener([MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener aListener);
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetDOMWindow();
		
		[return: MarshalAs(UnmanagedType.Bool)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsLoadingDocument();
	}
	
	[Guid("07a22cc0-0ce5-11d3-9331-00104ba0fd40"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIURI
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSpec([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String outSpec);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSpec([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String inSpec);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPrePath([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String outPrePath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetScheme([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String outScheme);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScheme([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String inScheme);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUserPass([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String outUserPass);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUserPass([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String inUserPass);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUsername([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String outUsername);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUsername([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aUsername);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPassword([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aUsername);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPassword([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aPassword);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHostPort([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aHostPort);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHostPort([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aHostPort);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHost([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aHost);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHost([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aHost);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPort();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPort(int aPort);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPath([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aPath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPath([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aPath);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals(nsIURI other);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SchemeIs([MarshalAs(UnmanagedType.LPStr)] string scheme);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI Clone();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Resolve([MarshalAs(UnmanagedType.LPStruct)]nsACString relativePath, [MarshalAs(UnmanagedType.LPStruct)]nsACString resolved);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAsciiSpec([MarshalAs(UnmanagedType.LPStruct)]nsACString spec);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAsciiHost([MarshalAs(UnmanagedType.LPStruct)]nsACString spec);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOriginCharset([MarshalAs(UnmanagedType.LPStruct)]nsACString charset); 
	}
	
	[Guid("df31c120-ded6-11d1-bd85-00805f8ae3f4"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMEventListener
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent e);
	}
	
	[Guid("a66b7b80-ff46-bd97-0080-5f8ae38add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMEvent
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetType([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget GetTarget();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget GetCurrentTarget();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetEventPhase();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBubbles();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCancelable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetTimeStamp(); // DOMTimeStamp
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StopPropagation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PreventDefault();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitEvent([MarshalAs(UnmanagedType.LPStruct)]nsACString eventTypeArg, bool canBubbleArg, bool cancelableArg);
	}
	
	[Guid("a6cf90c3-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMUIEvent : nsIDOMEvent
	{
		// nsIDOMEvent:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetType([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetTarget();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetCurrentTarget();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetEventPhase();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetBubbles();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetCancelable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr GetTimeStamp(); // DOMTimeStamp
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void StopPropagation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PreventDefault();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitEvent([MarshalAs(UnmanagedType.LPStruct)]nsACString eventTypeArg, bool canBubbleArg, bool cancelableArg);
		
		// nsIDOMUIEvent:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetView(); // nsIDOMAbstractView
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetDetail();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitUIEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString typeArg, bool canBubbleArg, bool cancelableArg, IntPtr /*nsIDOMAbstractView*/ viewArg, int detailArg); 
	}
	
	[Guid("028e0e6e-8b01-11d3-aae7-0010838a3123"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMKeyEvent : nsIDOMUIEvent
	{
		// nsIDOMEvent:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetType([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetTarget();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetCurrentTarget();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetEventPhase();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetBubbles();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetCancelable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr GetTimeStamp(); // DOMTimeStamp
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void StopPropagation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PreventDefault();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitEvent([MarshalAs(UnmanagedType.LPStruct)]nsACString eventTypeArg, bool canBubbleArg, bool cancelableArg);
		
		// nsIDOMUIEvent:
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr GetView(); // nsIDOMAbstractView
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetDetail();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitUIEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString typeArg, bool canBubbleArg, bool cancelableArg, IntPtr /*nsIDOMAbstractView*/ viewArg, int detailArg); 
		
		// nsIDOMKeyEvent:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetCharCode();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetKeyCode();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAltKey();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCtrlKey();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShiftKey();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMetaKey();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitKeyEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString typeArg, bool canBubbleArg, bool cancelableArg, IntPtr /*nsIDOMAbstractView*/ viewArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, uint keyCodeArg, uint charCodeArg); 
	}
	
	[Guid("ff751edc-8b02-aae7-0010-8301838a3123"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMMouseEvent : nsIDOMUIEvent
	{
		// nsIDOMEvent:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetType([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetTarget();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetCurrentTarget();
				
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		new ushort GetEventPhase();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetBubbles();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetCancelable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		new UInt64 GetTimeStamp(); // DOMTimeStamp
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void StopPropagation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PreventDefault();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitEvent([MarshalAs(UnmanagedType.LPStruct)]nsACString eventTypeArg, bool canBubbleArg, bool cancelableArg);
				
		// nsIDOMUIEvent:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		
		new IntPtr GetView(); // nsIDOMAbstractView
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		new int GetDetail();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitUIEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString typeArg, bool canBubbleArg, bool cancelableArg, IntPtr /*nsIDOMAbstractView*/ viewArg, int detailArg); 
		
		// nsIDOMMouseEvent:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetScreenX();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetScreenY();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetClientX();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetClientY();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCtrlKey();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShiftKey();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAltKey();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetMetaKey();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetButton();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget GetRelatedTarget();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitMouseEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString typeArg, bool canBubbleArg, bool cancelableArg, IntPtr /*nsIDOMAbstractView*/ viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, ushort buttonArg, [MarshalAs(UnmanagedType.Interface)]nsIDOMEventTarget relatedTargetArg); 
	}
	
	[Guid("a6cf906b-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMWindow
	{
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument GetDocument();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetParent();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetTop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		IntPtr GetScrollbars(); // nsIDOMBarProp
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		IntPtr GetFrames(); // nsIDOMWindowCollection
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void GetName([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetName([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetTextZoom();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextZoom(float aTextZoom);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetScrollX();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetScrollY();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollTo(int xScroll, int yScroll);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollBy(int xScrollDif, int yScrollDif);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISelection GetSelection(); // nsISelection
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollByLines(int numLines);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollByPages(int numPages);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SizeToContent(); 
	}
	

	[Guid("73c5fa35-3add-4c87-a303-a850ccf4d65a"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMWindow2 : nsIDOMWindow
	{
		// nsIDOMWindow:
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument GetDocument();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		new nsIDOMWindow GetParent();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMWindow GetTop();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr GetScrollbars(); // nsIDOMBarProp
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMWindowCollection GetFrames();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetName([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetName([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new float GetTextZoom();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTextZoom(float aTextZoom);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetScrollX();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetScrollY();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ScrollTo(int xScroll, int yScroll);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ScrollBy(int xScrollDif, int yScrollDif);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISelection GetSelection(); // nsISelection
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ScrollByLines(int numLines);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ScrollByPages(int numPages);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SizeToContent();

		// nsIDOMWindow2:
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget GetWindowRoot();
	}
	
	[Guid("b2c7ed59-8634-4352-9e37-5484c8b6e4e1"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsISelection
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetAnchorNode();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		int GetAnchorOffset();
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		nsIDOMNode GetFocusNode();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetFocusOffset();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsCollapsed();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetRangeCount();
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMRange GetRangeAt(int index);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Collapse([MarshalAs(UnmanagedType.Interface)]nsIDOMNode parentNode, int offset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Extend([MarshalAs(UnmanagedType.Interface)]nsIDOMNode parentNode, int offset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CollapseToStart();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CollapseToEnd();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ContainsNode(nsIDOMNode node, bool partlyContained);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectAllChildren([MarshalAs(UnmanagedType.Interface)]nsIDOMNode parentNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddRange([MarshalAs(UnmanagedType.Interface)]nsIDOMRange range);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveRange([MarshalAs(UnmanagedType.Interface)]nsIDOMRange range);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAllRanges();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteFromDocument();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectionLanguageChange(bool langRTL);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPWStr)] string ToString();
	}

	[Guid("7b9badc6-c9bc-447a-8670-dbd195aed24b"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMDocumentRange
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		nsIDOMRange CreateRange();	
	}
	
	[Guid("a6cf90ce-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMRange
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		nsIDOMNode GetStartContainer();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetStartOffset();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		nsIDOMNode GetEndContainer();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetEndOffset();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCollapsed();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetCommonAncestorContainer();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStart([MarshalAs(UnmanagedType.Interface)]nsIDOMNode refNode, int offset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEnd([MarshalAs(UnmanagedType.Interface)]nsIDOMNode refNode, int offset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartBefore([MarshalAs(UnmanagedType.Interface)]nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartAfter([MarshalAs(UnmanagedType.Interface)]nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEndBefore([MarshalAs(UnmanagedType.Interface)]nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEndAfter([MarshalAs(UnmanagedType.Interface)]nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Collapse(bool toStart);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectNode([MarshalAs(UnmanagedType.Interface)]nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectNodeContents([MarshalAs(UnmanagedType.Interface)]nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short CompareBoundaryPoints(ushort how, [MarshalAs(UnmanagedType.Interface)]nsIDOMRange sourceRange);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteContents();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode ExtractContents();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode CloneContents();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertNode([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SurroundContents([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newParent);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMRange CloneRange();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ToString([MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Detach();
	}
	
	/* GECKO 1.9
	[Guid("73c5fa35-3add-4c87-a303-a850ccf4d65a"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMWindow2
	{
		// nsIDOMWindow:
		nsIDOMDocument GetDocument();
		nsIDOMWindow GetParent();
		nsIDOMWindow GetTop();
		IntPtr GetScrollbars(); // nsIDOMBarProp
		nsIDOMWindowCollection GetFrames();
		void GetName([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		void SetName([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		float GetTextZoom();
		void SetTextZoom(float aTextZoom);
		int GetScrollX();
		int GetScrollY();
		void ScrollTo(int xScroll, int yScroll);
		void ScrollBy(int xScrollDif, int yScrollDif);
		IntPtr GetSelection(); // nsISelection
		void ScrollByLines(int numLines);
		void ScrollByPages(int numPages);
		void SizeToContent();

		// nsIDOMWindow2:
		nsIDOMEventTarget GetWindowRoot();
		IntPtr GetApplicationCache(); // nsIDOMOfflineResourceList
	}
	*/
	
	[Guid("a6cf906f-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMWindowCollection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLength();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow Item(uint index);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow NamedItem([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
	}
	
	[Guid("1c773b30-d1cf-11d2-bd95-00805f8ae3f4"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMEventTarget
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, bool useCapture);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, bool useCapture);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool DispatchEvent([MarshalAs(UnmanagedType.Interface)]nsIDOMEvent evt);
	}
	
	static class nsIDOMNodeConstants
	{
		public const int ELEMENT_NODE = 1;
		public const int ATTRIBUTE_NODE = 2;
		public const int TEXT_NODE = 3;
		public const int CDATA_SECTION_NODE = 4;
		public const int ENTITY_REFERENCE_NODE = 5;
		public const int ENTITY_NODE = 6;
		public const int PROCESSING_INSTRUCTION_NODE = 7;
		public const int COMMENT_NODE = 8;
		public const int DOCUMENT_NODE = 9;
		public const int DOCUMENT_TYPE_NODE = 10;
		public const int DOCUMENT_FRAGMENT_NODE = 11;
		public const int NOTATION_NODE = 12;
	}
	
	[Guid("a6cf907b-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMNamedNodeMap
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetNamedItem([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode SetNamedItem([MarshalAs(UnmanagedType.Interface)]nsIDOMNode arg);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode RemoveNamedItem([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode Item(int index);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLength();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetNamedItemNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode SetNamedItemNS([MarshalAs(UnmanagedType.Interface)]nsIDOMNode arg);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode RemoveNamedItemNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
	}
	
	[Guid("a6cf907c-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMNode
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNodeName([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetNodeType();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetParentNode();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetFirstChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetLastChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetPreviousSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetNextSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNamedNodeMap GetAttributes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument GetOwnerDocument();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode refChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode CloneNode(bool deep);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Normalize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAString feature,[MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNamespaceURI([MarshalAs(UnmanagedType.LPStruct)] nsAString aNamespaceURI);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLocalName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocalName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasAttributes(); 
	}
	
	[Guid("a6cf907d-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMNodeList
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode Item(int index);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLength(); 
	}
	
	[Guid("a6cf9070-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMAttr : nsIDOMNode
	{
		// nsIDOMNode:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeName([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetNodeType();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetParentNode();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetFirstChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetLastChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetPreviousSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetNextSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNamedNodeMap GetAttributes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument GetOwnerDocument();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode refChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode CloneNode(bool deep);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAString feature,[MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNamespaceURI([MarshalAs(UnmanagedType.LPStruct)] nsAString aNamespaceURI);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLocalName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocalName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributes(); 
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetName([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSpecified();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aValue);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetOwnerElement();
	}
	
	[Guid("a6cf9078-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMElement : nsIDOMNode
	{
		// nsIDOMNode:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeName([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetNodeType();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetParentNode();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetFirstChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetLastChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetPreviousSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetNextSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNamedNodeMap GetAttributes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument GetOwnerDocument();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode refChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode CloneNode(bool deep);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAString feature,[MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNamespaceURI([MarshalAs(UnmanagedType.LPStruct)] nsAString aNamespaceURI);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLocalName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocalName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributes(); 
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTagName([MarshalAs(UnmanagedType.LPStruct)] nsAString aTagName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name,[MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMAttr GetAttributeNode([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMAttr SetAttributeNode([MarshalAs(UnmanagedType.Interface)]nsIDOMAttr newAttr);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMAttr RemoveAttributeNode([MarshalAs(UnmanagedType.Interface)]nsIDOMAttr oldAttr);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByTagName([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName,[MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMAttr GetAttributeNodeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAttributeNodeNS([MarshalAs(UnmanagedType.Interface)]nsIDOMAttr newAttr);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByTagNameNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName); 
	}
	
	[Guid("a6cf9075-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMDocument : nsIDOMNode
	{
		// nsIDOMNode:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeName([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetNodeType();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetParentNode();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetFirstChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetLastChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetPreviousSibling();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetNextSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNamedNodeMap GetAttributes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument GetOwnerDocument();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode refChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode CloneNode(bool deep);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAString feature,[MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNamespaceURI([MarshalAs(UnmanagedType.LPStruct)] nsAString aNamespaceURI);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLocalName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocalName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributes(); 
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetDoctype(); // nsIDOMDocumentType
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetImplementation(); // nsIDOMDOMImplementation
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetDocumentElement();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement CreateElement([MarshalAs(UnmanagedType.LPStruct)] nsAString tagName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr CreateDocumentFragment(); // nsIDOMDocumentFragment
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode CreateTextNode([MarshalAs(UnmanagedType.LPStruct)] nsAString data); // nsIDOMText
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr CreateComment([MarshalAs(UnmanagedType.LPStruct)] nsAString data); // nsIDOMComment
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr CreateCDATASection([MarshalAs(UnmanagedType.LPStruct)] nsAString data); // nsIDOMCDATASection
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr CreateProcessingInstruction([MarshalAs(UnmanagedType.LPStruct)] nsAString target,[MarshalAs(UnmanagedType.LPStruct)] nsAString data); // nsIDOMProcessingInstruction
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMAttr CreateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr CreateEntityReference([MarshalAs(UnmanagedType.LPStruct)] nsAString name); // nsIDOMEntityReference
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByTagName([MarshalAs(UnmanagedType.LPStruct)] nsAString tagname);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode ImportNode(nsIDOMNode importedNode, bool deep);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement CreateElementNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMAttr CreateAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByTagNameNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetElementById([MarshalAs(UnmanagedType.LPStruct)] nsAString elementId); 
	}
	
	[Guid("a6cf9085-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLElement : nsIDOMElement
	{
		// nsIDOMNode:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeName([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetNodeType();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetParentNode();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetFirstChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetLastChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetPreviousSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetNextSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNamedNodeMap GetAttributes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument GetOwnerDocument();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode refChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode CloneNode(bool deep);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAString feature,[MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNamespaceURI([MarshalAs(UnmanagedType.LPStruct)] nsAString aNamespaceURI);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLocalName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocalName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributes(); 

		// nsIDOMElement:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTagName([MarshalAs(UnmanagedType.LPStruct)] nsAString aTagName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name,[MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr GetAttributeNode([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr SetAttributeNode([MarshalAs(UnmanagedType.Interface)]nsIDOMAttr newAttr);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr RemoveAttributeNode([MarshalAs(UnmanagedType.Interface)]nsIDOMAttr oldAttr);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagName([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName,[MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr GetAttributeNodeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr SetAttributeNodeNS([MarshalAs(UnmanagedType.Interface)]nsIDOMAttr newAttr);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagNameNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		// nsIDOMHTMLElement:		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetId([MarshalAs(UnmanagedType.LPStruct)] nsAString aId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetId([MarshalAs(UnmanagedType.LPStruct)] nsAString aId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLang([MarshalAs(UnmanagedType.LPStruct)] nsAString aLang);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLang([MarshalAs(UnmanagedType.LPStruct)] nsAString aLang);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDir([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDir([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetClassName([MarshalAs(UnmanagedType.LPStruct)] nsAString aClassName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetClassName([MarshalAs(UnmanagedType.LPStruct)] nsAString aClassName);
	}
	
	[Guid("a6cf9084-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLDocument : nsIDOMDocument 
	{
		// nsIDOMNode:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeName([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetNodeType();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetParentNode();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetFirstChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetLastChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetPreviousSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetNextSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNamedNodeMap GetAttributes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument GetOwnerDocument();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode refChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode CloneNode(bool deep);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAString feature,[MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNamespaceURI([MarshalAs(UnmanagedType.LPStruct)] nsAString aNamespaceURI);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLocalName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocalName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributes(); 

		// nsIDOMDocument:
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocumentType GetDoctype();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr GetImplementation();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetDocumentElement();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement CreateElement([MarshalAs(UnmanagedType.LPStruct)] nsAString tagName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr CreateDocumentFragment();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr CreateTextNode([MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr CreateComment([MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr CreateCDATASection([MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr CreateProcessingInstruction([MarshalAs(UnmanagedType.LPStruct)] nsAString target,[MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr CreateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr CreateEntityReference([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagName([MarshalAs(UnmanagedType.LPStruct)] nsAString tagname);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ImportNode([MarshalAs(UnmanagedType.Interface)]nsIDOMNode importedNode, bool deep);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement CreateElementNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr CreateAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagNameNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetElementById([MarshalAs(UnmanagedType.LPStruct)] nsAString elementId);

		// nsIDOMHTMLDocument:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetReferrer([MarshalAs(UnmanagedType.LPStruct)] nsAString aReferrer);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDomain([MarshalAs(UnmanagedType.LPStruct)] nsAString aDomain);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetURL([MarshalAs(UnmanagedType.LPStruct)] nsAString aURL);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLElement GetBody();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBody([MarshalAs(UnmanagedType.Interface)]nsIDOMHTMLElement aBody);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLCollection GetImages();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLCollection GetApplets();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLCollection GetLinks();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLCollection GetForms();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLCollection GetAnchors();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCookie([MarshalAs(UnmanagedType.LPStruct)] nsAString aCookie);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCookie([MarshalAs(UnmanagedType.LPStruct)]nsAString aCookie);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Open();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Write([MarshalAs(UnmanagedType.LPStruct)] nsAString text);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Writeln([MarshalAs(UnmanagedType.LPStruct)] nsAString text);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByName([MarshalAs(UnmanagedType.LPStruct)] nsAString elementName);
	}
	
	[Guid("a6cf9077-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMDocumentType : nsIDOMNode
	{
		// nsIDOMNode
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeName([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		new void GetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetNodeType();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetParentNode();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetFirstChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetLastChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetPreviousSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetNextSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNamedNodeMap GetAttributes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument GetOwnerDocument();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode refChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode CloneNode(bool deep);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAString feature,[MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNamespaceURI([MarshalAs(UnmanagedType.LPStruct)] nsAString aNamespaceURI);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLocalName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocalName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributes();
		
		// nsIDOMDocumentType:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetName([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNamedNodeMap GetEntities();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNamedNodeMap GetNotations();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPublicId([MarshalAs(UnmanagedType.LPStruct)] nsAString aPublicId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSystemId([MarshalAs(UnmanagedType.LPStruct)] nsAString aSystemId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetInternalSubset([MarshalAs(UnmanagedType.LPStruct)] nsAString aInternalSubset);		
	}
	
	[Guid("a6cf9083-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLCollection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLength();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode Item(int index);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode NamedItem([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
	}

	[Guid("7F142F9A-FBA7-4949-93D6-CF08A974AC51"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMNSHTMLElement
	{		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOffsetTop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOffsetLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOffsetWidth();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOffsetHeight();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetOffsetParent();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetInnerHTML([MarshalAs(UnmanagedType.LPStruct)] nsAString aInnerHTML);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInnerHTML([MarshalAs(UnmanagedType.LPStruct)] nsAString aInnerHTML);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetTabIndex();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTabIndex(int aTabIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentEditable([MarshalAs(UnmanagedType.LPStruct)] nsAString aContentEditable);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentEditable([MarshalAs(UnmanagedType.LPStruct)] nsAString aContentEditable);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Blur();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Focus();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollIntoView(bool top);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSpellcheck();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSpellcheck(bool aSpellcheck);
	}

	
	[Guid("3d9f4973-dd2e-48f5-b5f7-2634e09eadd9"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMDocumentStyle
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStyleSheetList GetStyleSheets();
	}
	
	[Guid("a6cf9081-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMStyleSheetList
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLength();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStyleSheet Item(int index);
	}
	
	[Guid("a6cf9080-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMStyleSheet
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetType([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDisabled();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisabled(bool aDisabled);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetOwnerNode();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStyleSheet GetParentStyleSheet();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHref([MarshalAs(UnmanagedType.LPStruct)] nsAString aHref);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMMediaList GetMedia();
	}
	
	[Guid("9b0c2ed7-111c-4824-adf9-ef0da6dad371"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMMediaList
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMediaText([MarshalAs(UnmanagedType.LPStruct)] nsAString aMediaText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMediaText([MarshalAs(UnmanagedType.LPStruct)] nsAString aMediaText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLength();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Item(int index,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteMedium([MarshalAs(UnmanagedType.LPStruct)] nsAString oldMedium);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendMedium([MarshalAs(UnmanagedType.LPStruct)] nsAString newMedium);
	}
	
	[Guid("a6cf90c2-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMCSSStyleSheet
	{
		// nsIDOMStyleSheet:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetType([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDisabled();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisabled(bool aDisabled);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetOwnerNode();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStyleSheet GetParentStyleSheet();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHref([MarshalAs(UnmanagedType.LPStruct)] nsAString aHref);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMMediaList GetMedia();
		
		// nsIDOMCSSStyleSheet:
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSRule GetOwnerRule();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int GetCssRules([MarshalAs(UnmanagedType.Interface)]out nsIDOMCSSRuleList ret); // 0x8053000F
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int InsertRule([MarshalAs(UnmanagedType.LPStruct)] nsAString rule, int index, out int result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteRule(int index);
	}
	
	[Guid("a6cf90c1-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMCSSRule
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetType();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSStyleSheet GetParentStyleSheet();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSRule GetParentRule();
	}
	
	[Guid("a6cf90bf-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMCSSStyleRule : nsIDOMCSSRule
	{
		// nsIDOMCSSRule:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetType();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMCSSStyleSheet GetParentStyleSheet();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMCSSRule GetParentRule();

		// nsIDOMCSSStyleRule:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSelectorText([MarshalAs(UnmanagedType.LPStruct)] nsAString aSelectorText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectorText([MarshalAs(UnmanagedType.LPStruct)] nsAString aSelectorText);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSStyleDeclaration GetStyle();
	}
	
	[Guid("a6cf90cf-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMCSSImportRule
	{
		// nsIDOMCSSRule:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetType();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSStyleSheet GetParentStyleSheet();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSRule GetParentRule();
		
		// nsIDOMCSSImportRule:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHref([MarshalAs(UnmanagedType.LPStruct)] nsAString str);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMMediaList GetMedia();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSStyleSheet GetStyleSheet();
	}
	
	[Guid("a6cf90c0-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMCSSRuleList
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLength();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSRule Item(int index);
	}
	
	[Guid("a6cf90be-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMCSSStyleDeclaration
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPropertyValue([MarshalAs(UnmanagedType.LPStruct)] nsAString propertyName,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSValue GetPropertyCSSValue([MarshalAs(UnmanagedType.LPStruct)] nsAString propertyName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveProperty([MarshalAs(UnmanagedType.LPStruct)] nsAString propertyName,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPropertyPriority([MarshalAs(UnmanagedType.LPStruct)] nsAString propertyName,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProperty([MarshalAs(UnmanagedType.LPStruct)] nsAString propertyName,[MarshalAs(UnmanagedType.LPStruct)] nsAString value,[MarshalAs(UnmanagedType.LPStruct)] nsAString priority);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLength();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Item(int index,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSRule GetParentRule();
	}
	
	[Guid("009f7ea5-9e80-41be-b008-db62f10823f2"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMCSSValue
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetCssValueType();
	}
	
	class PRUnicharMarshaler : ICustomMarshaler
	{
		public static ICustomMarshaler GetInstance(string cookie)
		{
			return (_Instance == null) ? (_Instance = new PRUnicharMarshaler()) : _Instance;
		}
		static PRUnicharMarshaler _Instance;
		
		public void CleanUpManagedData(object ManagedObj) { }
		public void CleanUpNativeData(IntPtr pNativeData) { }
		public int GetNativeDataSize() { return 0; }

		public IntPtr MarshalManagedToNative(object ManagedObj)
		{
			byte [] bytes = Encoding.Unicode.GetBytes(ManagedObj.ToString() + "\0");
			IntPtr alloc = Xpcom.Alloc(bytes.Length + 2);
			Marshal.Copy(bytes, 0, alloc, bytes.Length);
			return alloc;
		}

		public object MarshalNativeToManaged(IntPtr pNativeData)
		{
			return Marshal.PtrToStringUni(pNativeData);
		}
	}
	
	#if !NO_CUSTOM_PROMPT_SERVICE
	[Guid("1630c61a-325e-49ca-8759-a31b16c47aa5"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIPromptService
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Alert([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] void AlertCheck([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, ref bool aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Confirm([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] bool ConfirmCheck(nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, ref bool aCheckState);
		int ConfirmEx([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, uint aButtonFlags, [MarshalAs(UnmanagedType.LPWStr)] string aButton0Title, [MarshalAs(UnmanagedType.LPWStr)] string aButton1Title, [MarshalAs(UnmanagedType.LPWStr)] string aButton2Title, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, out bool aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Prompt([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(PRUnicharMarshaler))] ref string aValue, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, IntPtr aCheckState);
		//[PreserveSig] int Prompt(IntPtr aParent, IntPtr aDialogTitle, IntPtr aText, IntPtr aValue, IntPtr aCheckMsg, IntPtr aCheckState, out bool result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PromptUsernameAndPassword([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(PRUnicharMarshaler))] ref string aUsername, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(PRUnicharMarshaler))] ref string aPassword, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, IntPtr aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PromptPassword([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(PRUnicharMarshaler))] ref string aPassword, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, IntPtr aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Select([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, uint aCount, IntPtr aSelectList, out int aOutSelection);
	}
	
	static class nsIPromptServiceConstants
	{
		public const int BUTTON_POS_0 = 1;
		public const int BUTTON_POS_1 = 256;
		public const int BUTTON_POS_2 = 65536;

		public const int BUTTON_TITLE_OK = 1;
		public const int BUTTON_TITLE_CANCEL = 2;
		public const int BUTTON_TITLE_YES = 3;
		public const int BUTTON_TITLE_NO = 4;
		public const int BUTTON_TITLE_SAVE = 5;
		public const int BUTTON_TITLE_DONT_SAVE = 6;
		public const int BUTTON_TITLE_REVERT = 7;
		public const int BUTTON_TITLE_IS_STRING = 127;

		public const int BUTTON_POS_0_DEFAULT = 0;
		public const int BUTTON_POS_1_DEFAULT = 16777216;
		public const int BUTTON_POS_2_DEFAULT = 33554432;
		
		public const int BUTTON_DELAY_ENABLE = 67108864;
		public const int STD_OK_CANCEL_BUTTONS = 513;
		public const int STD_YES_NO_BUTTONS = 1027;
	}
	
	[Guid("e800ef97-ae37-46b7-a46c-31fbe79657ea"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsINonBlockingAlertService
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowNonBlockingAlert([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText);
	}

	[Guid("cf86d196-dbee-4482-9dfa-3477aa128319"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIPromptService2 : nsIPromptService
	{
		// nsIPromptService:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Alert([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] new void AlertCheck([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, ref bool aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Confirm([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] new bool ConfirmCheck([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, ref bool aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int ConfirmEx([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, uint aButtonFlags, [MarshalAs(UnmanagedType.LPWStr)] string aButton0Title, [MarshalAs(UnmanagedType.LPWStr)] string aButton1Title, [MarshalAs(UnmanagedType.LPWStr)] string aButton2Title, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, out bool aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Prompt([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(PRUnicharMarshaler))] ref string aValue, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, IntPtr aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool PromptUsernameAndPassword([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(PRUnicharMarshaler))] ref string aUsername, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(PRUnicharMarshaler))] ref string aPassword, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, IntPtr aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool PromptPassword([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(PRUnicharMarshaler))] ref string aPassword, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, IntPtr aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Select([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, uint aCount, IntPtr aSelectList, out int aOutSelection);

		// nsIPromptService2:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PromptAuth([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, IntPtr aChannel, int level, nsIAuthInformation authInfo, [MarshalAs(UnmanagedType.LPWStr)] string checkboxLabel, IntPtr checkValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		nsICancelable AsyncPromptAuth(nsIDOMWindow aParent, IntPtr aChannel, nsIAuthPromptCallback aCallback, nsISupports aContext, uint level, nsIAuthInformation authInfo, [MarshalAs(UnmanagedType.LPWStr)] string checkboxLabel, IntPtr checkValue);
	}
	
	[Guid("0d73639c-2a92-4518-9f92-28f71fea5f20"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIAuthInformation
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetFlags();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRealm([MarshalAs(UnmanagedType.LPStruct)] nsAString aRealm);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAuthenticationScheme([MarshalAs(UnmanagedType.LPStruct)]nsACString aAuthenticationScheme);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUsername([MarshalAs(UnmanagedType.LPStruct)] nsAString aUsername);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUsername([MarshalAs(UnmanagedType.LPStruct)] nsAString aUsername);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPassword([MarshalAs(UnmanagedType.LPStruct)] nsAString aPassword);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPassword([MarshalAs(UnmanagedType.LPStruct)] nsAString aPassword);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDomain([MarshalAs(UnmanagedType.LPStruct)] nsAString aDomain);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDomain([MarshalAs(UnmanagedType.LPStruct)] nsAString aDomain);
	}
	
	[Guid("bdc387d7-2d29-4cac-92f1-dd75d786631d"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIAuthPromptCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnAuthAvailable([MarshalAs(UnmanagedType.Interface)]nsISupports aContext, [MarshalAs(UnmanagedType.Interface)]nsIAuthInformation aAuthInfo);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnAuthCancelled([MarshalAs(UnmanagedType.Interface)]nsISupports aContext, bool userCancel);
	}
	
	[Guid("d94ac0a0-bb18-46b8-844e-84159064b0bd"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsICancelable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Cancel(int aReason);
	}
	
	#endif
	
	[Guid("decb9cc7-c08f-4ea5-be91-a8fc637ce2d2"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIPrefService
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReadUserPrefs([MarshalAs(UnmanagedType.Interface)]nsIFile aFile);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetPrefs();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetUserPrefs();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SavePrefFile([MarshalAs(UnmanagedType.Interface)]nsIFile aFile);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		nsIPrefBranch GetBranch([MarshalAs(UnmanagedType.LPStr)] string aPrefRoot);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		nsIPrefBranch GetDefaultBranch([MarshalAs(UnmanagedType.LPStr)] string aPrefRoot);
	}
	
	[Guid("56c35506-f14b-11d3-99d3-ddbfac2ccf65"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIPrefBranch
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPStr)] string GetRoot();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPrefType([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBoolPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBoolPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName, int aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPStr)] string GetCharPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCharPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName, [MarshalAs(UnmanagedType.LPStr)] string aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetIntPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIntPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName, int aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetComplexValue([MarshalAs(UnmanagedType.LPStr)] string aPrefName, ref Guid aType, IntPtr aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetComplexValue([MarshalAs(UnmanagedType.LPStr)] string aPrefName, ref Guid aType, nsISupports aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearUserPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LockPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PrefHasUserValue([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PrefIsLocked([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnlockPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteBranch([MarshalAs(UnmanagedType.LPStr)] string aStartingAt);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetChildList([MarshalAs(UnmanagedType.LPStr)] string aStartingAt, out uint aCount, [MarshalAs(UnmanagedType.LPArray, ArraySubType=UnmanagedType.LPStr)] string [] aChildArray);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetBranch([MarshalAs(UnmanagedType.LPStr)] string aStartingAt);
	}
	
	[Guid("00000001-0000-0000-c000-000000000046"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateInstance([MarshalAs(UnmanagedType.Interface)]nsISupports aOuter, ref Guid iid, [MarshalAs(UnmanagedType.IUnknown)] out object result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LockFactory(bool @lock);
	}
	
	[Guid("2417cbfe-65ad-48a6-b4b6-eb84db174392"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIComponentRegistrar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AutoRegister(IntPtr aSpec); // nsIFile
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AutoUnregister(IntPtr aSpec); // nsIFile
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterFactory(ref Guid aClass, [MarshalAs(UnmanagedType.LPStr)] string aClassName, [MarshalAs(UnmanagedType.LPStr)] string aContractID, nsIFactory aFactory);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterFactory(ref Guid aClass, nsIFactory aFactory);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterFactoryLocation(ref Guid aClass, [MarshalAs(UnmanagedType.LPStr)] string aClassName, [MarshalAs(UnmanagedType.LPStr)] string aContractID, IntPtr aFile, [MarshalAs(UnmanagedType.LPStr)] string aLoaderStr, [MarshalAs(UnmanagedType.LPStr)] string aType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterFactoryLocation(ref Guid aClass, IntPtr aFile);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsCIDRegistered(ref Guid aClass);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsContractIDRegistered([MarshalAs(UnmanagedType.LPStr)] string aContractID);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr EnumerateCIDs(); // nsISimpleEnumerator
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr EnumerateContractIDs(); // nsISimpleEnumerator
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPStr)] string CIDToContractID(ref Guid aClass);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] void ContractIDToCID([MarshalAs(UnmanagedType.LPStr)] string aContractID, out Guid cid);
	}
	
	[Guid("57a66a60-d43a-11d3-8cc2-00609792278c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDirectoryService
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterProvider(nsIDirectoryServiceProvider provider);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterProvider(nsIDirectoryServiceProvider provider);
	}
	
	[Guid("bbf8cab0-d43a-11d3-8cc2-00609792278c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDirectoryServiceProvider
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetFile([MarshalAs(UnmanagedType.LPStr)] string prop, out bool persistent);
	}
	
	[Guid("78650582-4e93-4b60-8e85-26ebd3eb14ca"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIProperties
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr Get([MarshalAs(UnmanagedType.LPStr)] string prop, ref Guid iid);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Set([MarshalAs(UnmanagedType.LPStr)] string prop, nsISupports value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Has([MarshalAs(UnmanagedType.LPStr)] string prop);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Undefine([MarshalAs(UnmanagedType.LPStr)] string prop);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void STUB_GetKeys();
	}
	
	[Guid("c8c0a080-0868-11d3-915f-d9d889d48e3c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIFile
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Append([MarshalAs(UnmanagedType.LPStruct)] nsAString node);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendNative([MarshalAs(UnmanagedType.LPStruct)]nsACString node);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Normalize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Create(uint type, uint permissions);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLeafName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLeafName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNativeLeafName([MarshalAs(UnmanagedType.LPStruct)]nsACString aNativeLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNativeLeafName([MarshalAs(UnmanagedType.LPStruct)]nsACString aNativeLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyTo([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir,[MarshalAs(UnmanagedType.LPStruct)] nsAString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyToNative([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)]nsACString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyToFollowingLinks([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir,[MarshalAs(UnmanagedType.LPStruct)] nsAString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyToFollowingLinksNative([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)]nsACString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MoveTo([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir,[MarshalAs(UnmanagedType.LPStruct)] nsAString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MoveToNative([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)]nsACString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Remove(bool recursive);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetPermissions();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPermissions(uint aPermissions);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetPermissionsOfLink();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPermissionsOfLink(uint aPermissionsOfLink);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetLastModifiedTime();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLastModifiedTime(long aLastModifiedTime);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetLastModifiedTimeOfLink();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLastModifiedTimeOfLink(long aLastModifiedTimeOfLink);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetFileSize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFileSize(long aFileSize);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetFileSizeOfLink();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTarget([MarshalAs(UnmanagedType.LPStruct)] nsAString aTarget);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNativeTarget([MarshalAs(UnmanagedType.LPStruct)]nsACString aNativeTarget);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPath([MarshalAs(UnmanagedType.LPStruct)] nsAString aPath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNativePath([MarshalAs(UnmanagedType.LPStruct)]nsACString aNativePath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Exists();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsWritable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsReadable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsExecutable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsHidden();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsDirectory();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsFile();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSymlink();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSpecial();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateUnique(uint type, uint permissions);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile Clone();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals(nsIFile inFile);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Contains(nsIFile inFile, bool recur);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetParent();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetDirectoryEntries();
	}
	
	[Guid("aa610f20-a889-11d3-8c81-000064657374"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsILocalFile : nsIFile
	{
		// nsIFile:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Append([MarshalAs(UnmanagedType.LPStruct)]nsAString node);
				
		new void AppendNative([MarshalAs(UnmanagedType.LPStruct)]nsACString node);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Create(uint type, uint permissions);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLeafName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLeafName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNativeLeafName([MarshalAs(UnmanagedType.LPStruct)]nsACString aNativeLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNativeLeafName([MarshalAs(UnmanagedType.LPStruct)]nsACString aNativeLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CopyTo([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir,[MarshalAs(UnmanagedType.LPStruct)] nsAString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CopyToNative([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)]nsACString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CopyToFollowingLinks([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir,[MarshalAs(UnmanagedType.LPStruct)] nsAString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CopyToFollowingLinksNative([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)]nsACString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void MoveTo([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir,[MarshalAs(UnmanagedType.LPStruct)] nsAString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void MoveToNative([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)]nsACString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Remove(bool recursive);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetPermissions();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPermissions(uint aPermissions);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetPermissionsOfLink();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPermissionsOfLink(uint aPermissionsOfLink);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new long GetLastModifiedTime();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLastModifiedTime(long aLastModifiedTime);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new long GetLastModifiedTimeOfLink();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLastModifiedTimeOfLink(long aLastModifiedTimeOfLink);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new long GetFileSize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetFileSize(long aFileSize);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new long GetFileSizeOfLink();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTarget([MarshalAs(UnmanagedType.LPStruct)] nsAString aTarget);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNativeTarget([MarshalAs(UnmanagedType.LPStruct)]nsACString aNativeTarget);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPath([MarshalAs(UnmanagedType.LPStruct)] nsAString aPath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNativePath([MarshalAs(UnmanagedType.LPStruct)]nsACString aNativePath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Exists();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsWritable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsReadable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsExecutable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsHidden();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsDirectory();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsFile();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSymlink();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSpecial();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CreateUnique(uint type, uint permissions);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIFile Clone();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Equals([MarshalAs(UnmanagedType.Interface)]nsIFile inFile);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Contains([MarshalAs(UnmanagedType.Interface)]nsIFile inFile, bool recur);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIFile GetParent();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISimpleEnumerator GetDirectoryEntries();

		// nsILocalFile:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWithPath([MarshalAs(UnmanagedType.LPStruct)] nsAString filePath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWithNativePath([MarshalAs(UnmanagedType.LPStruct)]nsACString filePath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void InitWithFile(nsILocalFile aFile);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetFollowLinks();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFollowLinks(bool aFollowLinks);
		//PRFileDesc OpenNSPRFileDesc(int flags, int mode);
		//FILE OpenANSIFileDesc([MarshalAs(UnmanagedType.LPStr)] string mode);
		//PRLibrary Load();
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr OpenNSPRFileDesc(int flags, int mode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr OpenANSIFileDesc([MarshalAs(UnmanagedType.LPStr)] string mode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr Load();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetDiskSpaceAvailable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendRelativePath([MarshalAs(UnmanagedType.LPStruct)] nsAString relativeFilePath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendRelativeNativePath([MarshalAs(UnmanagedType.LPStruct)]nsACString relativeFilePath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPersistentDescriptor([MarshalAs(UnmanagedType.LPStruct)]nsACString aPersistentDescriptor);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPersistentDescriptor([MarshalAs(UnmanagedType.LPStruct)]nsACString aPersistentDescriptor);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Reveal();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Launch();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRelativeDescriptor([MarshalAs(UnmanagedType.Interface)]nsILocalFile fromFile, [MarshalAs(UnmanagedType.LPStruct)] nsACString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRelativeDescriptor([MarshalAs(UnmanagedType.Interface)]nsILocalFile fromFile, [MarshalAs(UnmanagedType.LPStruct)] nsACString relativeDesc);
	}
	
	[Guid("bddeda3f-9020-4d12-8c70-984ee9f7935e"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIIOService
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetProtocolHandler([MarshalAs(UnmanagedType.LPStr)] string aScheme); // nsIProtocolHandler
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetProtocolFlags([MarshalAs(UnmanagedType.LPStr)] string aScheme);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI NewURI(nsACString aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, [MarshalAs(UnmanagedType.Interface)]nsIURI aBaseURI);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI NewFileURI(nsIFile aFile);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr NewChannelFromURI(nsIURI aURI); // returns: nsIChannel
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr NewChannel(nsACString aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, nsIURI aBaseURI); // returns: nsIChannel
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetOffline();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOffline(bool aOffline);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool AllowPort(int aPort, [MarshalAs(UnmanagedType.LPStr)] string aScheme);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExtractScheme([MarshalAs(UnmanagedType.LPStruct)] nsACString urlString, [MarshalAs(UnmanagedType.LPStruct)] nsACString _retval);
	}
	
	[Guid("b8100c90-73be-11d2-92a5-00105a1b0d64"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIClipboardCommands
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int CanCutSelection(out bool result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int CanCopySelection(out bool result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int CanCopyLinkLocation(out bool result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int CanCopyImageLocation(out bool result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int CanCopyImageContents(out bool result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int CanPaste(out bool result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CutSelection();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopySelection();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyLinkLocation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyImageLocation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyImageContents();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Paste();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectAll();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectNone();
	}
	
	[Guid("080d2001-f91e-11d4-a73c-f9242928207c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsICommandManager
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddCommandObserver(nsIObserver aCommandObserver, [MarshalAs(UnmanagedType.LPStr)] string aCommandToObserve);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveCommandObserver(nsIObserver aCommandObserver, [MarshalAs(UnmanagedType.LPStr)] string aCommandObserved);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsCommandSupported([MarshalAs(UnmanagedType.LPStr)] string aCommandName, nsIDOMWindow aTargetWindow);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsCommandEnabled([MarshalAs(UnmanagedType.LPStr)] string aCommandName, nsIDOMWindow aTargetWindow);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCommandState([MarshalAs(UnmanagedType.LPStr)] string aCommandName, nsIDOMWindow aTargetWindow, nsICommandParams aCommandParams);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoCommand([MarshalAs(UnmanagedType.LPStr)] string aCommandName, nsICommandParams aCommandParams, nsIDOMWindow aTargetWindow);
	}
	
	[Guid("83f892cf-7ed3-490e-967a-62640f3158e1"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsICommandParams
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetValueType([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBooleanValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLongValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetDoubleValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStringValue([MarshalAs(UnmanagedType.LPStr)] string name,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPStr)] string GetCStringValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetISupportsValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBooleanValue([MarshalAs(UnmanagedType.LPStr)] string name, bool value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLongValue([MarshalAs(UnmanagedType.LPStr)] string name, int value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDoubleValue([MarshalAs(UnmanagedType.LPStr)] string name, double value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStringValue([MarshalAs(UnmanagedType.LPStr)] string name,[MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCStringValue([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetISupportsValue([MarshalAs(UnmanagedType.LPStr)] string name, nsISupports value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasMoreElements();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void First();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPStr)] string GetNext();
	}
	
	[Guid("44b78386-1dd2-11b2-9ad2-e4eee2ca1916"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsITooltipListener
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnShowTooltip(int aXCoords, int aYCoords, [MarshalAs(UnmanagedType.LPWStr)] string aTipText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnHideTooltip();
	}
	
	[Guid("fa9c7f6c-61b3-11d4-9877-00c04fa0cf4a"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIInputStream
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int Available();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int Read(IntPtr aBuf, uint aCount);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int ReadSegments(IntPtr aWriter, IntPtr aClosure, uint aCount);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		bool IsNonBlocking();
	}
	
	delegate int nsWriteSegmentFun(nsIInputStream aInStream, IntPtr aClosure, IntPtr aFromSegment, int aToOffset, int aCount, out int aWriteCount);
	
	//[Guid("b128a1e6-44f3-4331-8fbe-5af360ff21ee"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	//interface nsITooltipTextProvider
	//{
	//      bool GetNodeText(nsIDOMNode aNode, [MarshalAs(UnmanagedType.LPWStr)] out string aText);
	//}
	
	// 1.9.2
	[Guid("09a439ad-4079-46d5-a050-4d7015d1a108"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]	
	interface nsIDOMNSDocument
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCharacterSet([MarshalAs(UnmanagedType.LPStruct)] nsAString aCharacterSet);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDir([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDir([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetLocation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentType([MarshalAs(UnmanagedType.LPStruct)] nsAString aContentType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLastModified([MarshalAs(UnmanagedType.LPStruct)] nsAString aLastModified);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetReferrer([MarshalAs(UnmanagedType.LPStruct)] nsAString aReferrer);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetBoxObjectFor([MarshalAs(UnmanagedType.Interface)]nsIDOMElement elt);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasFocus();
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetActiveElement();
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByClassName([MarshalAs(UnmanagedType.LPStruct)] nsAString classes);
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement ElementFromPoint(int x, int y);
	}
	
	[Guid("c9da11bc-32d4-425e-A91f-7e0939c39251"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMNSElement
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByClassName([MarshalAs(UnmanagedType.LPStruct)] nsAString classes);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMClientRectList GetClientRects();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMClientRect GetBoundingClientRect();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetScrollTop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScrollTop(int value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetScrollLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScrollLeft(int value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetScrollHeight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetScrollWidth();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetClientTop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetClientLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetClientHeight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetClientWidth();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetFirstElementChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetLastElementChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetPreviousElementSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetNextElementSibling();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetChildElementCount();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetChildren();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		/* nsIDOMDOMTokenList */ IntPtr GetClassList();
	}
	

	[Guid("B2F824C4-D9D3-499B-8D3B-45C8245497C6"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMClientRect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetTop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetRight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetBottom();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetWidth();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetHeight();
	}
	
	[Guid("917da19d-62f5-441d-b47e-9e35f05639c9"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMClientRectList
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLength();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMClientRect Item(int index);
	}
	
	[Guid("75d1553d-63bf-4b5d-a8f7-e4e4cac21ba4"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIPrintingPromptService
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPrintDialog([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow parent, [MarshalAs(UnmanagedType.Interface)]nsIWebBrowserPrint webBrowserPrint, [MarshalAs(UnmanagedType.Interface)]nsIPrintSettings printSettings);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowProgress([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent, [MarshalAs(UnmanagedType.Interface)] nsIWebBrowserPrint webBrowserPrint, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings, nsIObserver openDialogObserver, bool isForPrinting, [MarshalAs(UnmanagedType.Interface)] out nsIWebProgressListener webProgressListener, [MarshalAs(UnmanagedType.Interface)] out nsIPrintProgressParams printProgressParams, bool notifyOnOpen);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPageSetup([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow parent, [MarshalAs(UnmanagedType.Interface)]nsIPrintSettings printSettings, [MarshalAs(UnmanagedType.Interface)]nsIObserver aObs);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPrinterProperties([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow parent, [MarshalAs(UnmanagedType.LPWStr)] string printerName, [MarshalAs(UnmanagedType.Interface)]nsIPrintSettings printSettings);
	}
	
	[Guid("ca89b55b-6faf-4051-9645-1c03ef5108f8"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIPrintProgressParams
	{
		[return: MarshalAs(UnmanagedType.LPWStr)] string GetDocTitle();
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocTitle([MarshalAs(UnmanagedType.LPWStr)] string aDocTitle);
				
		[return: MarshalAs(UnmanagedType.LPWStr)] string GetDocURL();
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocURL([MarshalAs(UnmanagedType.LPWStr)] string aDocURL);

	}
	
	[Guid("9a7ca4b0-fbba-11d4-a869-00105a183419"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWebBrowserPrint
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrintSettings GetGlobalPrintSettings();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrintSettings GetCurrentPrintSettings();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetCurrentChildDOMWindow();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDoingPrint();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDoingPrintPreview();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsFramesetDocument();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsFramesetFrameSelected();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsIFrameSelected();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsRangeSelection();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPrintPreviewNumPages();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Print([MarshalAs(UnmanagedType.Interface)]nsIPrintSettings aThePrintSettings, [MarshalAs(UnmanagedType.Interface)]nsIWebProgressListener aWPListener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PrintPreview([MarshalAs(UnmanagedType.Interface)]nsIPrintSettings aThePrintSettings, [MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aChildDOMWin, [MarshalAs(UnmanagedType.Interface)]nsIWebProgressListener aWPListener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PrintPreviewNavigate(short aNavType, int aPageNum);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Cancel();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnumerateDocumentNames(out uint aCount, IntPtr aResult);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExitPrintPreview();
	}
	
	[Guid("2f977d52-5485-11d4-87e2-0010a4e75ef2"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIPrintSession
	{
	}
	
	[Guid("5af07661-6477-4235-8814-4a45215855b8"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIPrintSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintOptions(int aType, bool aTurnOnOff);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPrintOptions(int aType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPrintOptionsBits();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEffectivePageSize(out double aWidth, double aHeight);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrintSettings Clone();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Assign([MarshalAs(UnmanagedType.Interface)]nsIPrintSettings aPS);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrintSession GetPrintSession();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintSession([MarshalAs(UnmanagedType.Interface)]nsIPrintSession aPrintSession);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		int GetStartPageRange();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartPageRange(int aStartPageRange);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetEndPageRange();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void SetEndPageRange(int aEndPageRange);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetEdgeTop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEdgeTop(double aEdgeTop);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetEdgeLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEdgeLeft(double aEdgeLeft);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetEdgeBottom();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEdgeBottom(double aEdgeBottom);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetEdgeRight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEdgeRight(double aEdgeRight);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetMarginTop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginTop(double aMarginTop);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetMarginLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginLeft(double aMarginLeft);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetMarginBottom();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginBottom(double aMarginBottom);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetMarginRight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginRight(double aMarginRight);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetUnwriteableMarginTop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUnwriteableMarginTop(double aUnwriteableMarginTop);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetUnwriteableMarginLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUnwriteableMarginLeft(double aUnwriteableMarginLeft);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetUnwriteableMarginBottom();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUnwriteableMarginBottom(double aUnwriteableMarginBottom);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetUnwriteableMarginRight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUnwriteableMarginRight(double aUnwriteableMarginRight);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetScaling();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScaling(double aScaling);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPrintBGColors();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintBGColors(bool aPrintBGColors);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPrintBGImages();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintBGImages(bool aPrintBGImages);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPrintRange();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintRange(short aPrintRange);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetTitle();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitle( string aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetDocURL();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocURL( string aDocURL);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetHeaderStrLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeaderStrLeft( string aHeaderStrLeft);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetHeaderStrCenter();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeaderStrCenter( string aHeaderStrCenter);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetHeaderStrRight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeaderStrRight( string aHeaderStrRight);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetFooterStrLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFooterStrLeft( string aFooterStrLeft);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetFooterStrCenter();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFooterStrCenter( string aFooterStrCenter);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetFooterStrRight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFooterStrRight( string aFooterStrRight);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetHowToEnableFrameUI();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHowToEnableFrameUI(short aHowToEnableFrameUI);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsCancelled();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsCancelled(bool aIsCancelled);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPrintFrameTypeUsage();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintFrameTypeUsage(short aPrintFrameTypeUsage);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPrintFrameType();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintFrameType(short aPrintFrameType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPrintSilent();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintSilent(bool aPrintSilent);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShrinkToFit();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShrinkToFit(bool aShrinkToFit);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShowPrintProgress();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShowPrintProgress(bool aShowPrintProgress);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetPaperName();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void SetPaperName( string aPaperName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPaperSizeType();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void SetPaperSizeType(short aPaperSizeType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPaperData();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void SetPaperData(short aPaperData);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetPaperWidth();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPaperWidth(double aPaperWidth);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetPaperHeight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void SetPaperHeight(double aPaperHeight);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPaperSizeUnit();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPaperSizeUnit(short aPaperSizeUnit);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		string GetPlexName();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPlexName( string aPlexName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		string GetColorspace();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetColorspace( string aColorspace);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetResolutionName();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetResolutionName( string aResolutionName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDownloadFonts();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void SetDownloadFonts(bool aDownloadFonts);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPrintReversed();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintReversed(bool aPrintReversed);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPrintInColor();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintInColor(bool aPrintInColor);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOrientation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOrientation(int aOrientation);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetPrintCommand();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintCommand( string aPrintCommand);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetNumCopies();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNumCopies(int aNumCopies);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetPrinterName();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrinterName( string aPrinterName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPrintToFile();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void SetPrintToFile(bool aPrintToFile);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetToFileName();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetToFileName( string aToFileName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetOutputFormat();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOutputFormat(short aOutputFormat);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPrintPageDelay();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintPageDelay(int aPrintPageDelay);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsInitializedFromPrinter();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsInitializedFromPrinter(bool aIsInitializedFromPrinter);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsInitializedFromPrefs();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsInitializedFromPrefs(bool aIsInitializedFromPrefs);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginInTwips(ref nsMargin aMargin);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEdgeInTwips(ref nsMargin aEdge);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMarginInTwips(ref nsMargin aMargin);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEdgeInTwips(ref nsMargin aEdge);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetupSilentPrinting();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUnwriteableMarginInTwips(ref nsMargin aEdge);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUnwriteableMarginInTwips(ref nsMargin aEdge);
	}
	
	public struct nsMargin
	{
	}
}
