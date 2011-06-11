// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIInterfaceInfoManager.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    ///this is NOT intended to be scriptable </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8B161900-BE2B-11d2-9831-006008962422")]
	public interface nsIInterfaceInfoManager
	{
		
		/// <summary>
        ///this is NOT intended to be scriptable </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInterfaceInfo GetInfoForIID(System.Guid iid);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInterfaceInfo GetInfoForName([MarshalAs(UnmanagedType.LPStr)] System.String  name);
		
		System.Guid GetIIDForName([MarshalAs(UnmanagedType.LPStr)] System.String  name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetNameForIID(System.Guid iid);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIEnumerator EnumerateInterfaces();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AutoRegisterInterfaces();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIEnumerator EnumerateInterfacesWhoseNamesStartWith([MarshalAs(UnmanagedType.LPStr)] System.String  prefix);
	}
	
	/// <summary>nsIInterfaceInfoSuperManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0ee22850-bc6a-11d5-9134-0010a4e73d9a")]
	public interface nsIInterfaceInfoSuperManager : nsIInterfaceInfoManager
	{
		
		/// <summary>
        ///this is NOT intended to be scriptable </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIInterfaceInfo GetInfoForIID(System.Guid iid);
		
		/// <summary>Member GetInfoForName </summary>
		/// <param name='name'> </param>
		/// <returns>A nsIInterfaceInfo</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIInterfaceInfo GetInfoForName([MarshalAs(UnmanagedType.LPStr)] System.String  name);
		
		/// <summary>Member GetIIDForName </summary>
		/// <param name='name'> </param>
		/// <returns>A System.Guid</returns>
		new System.Guid GetIIDForName([MarshalAs(UnmanagedType.LPStr)] System.String  name);
		
		/// <summary>Member GetNameForIID </summary>
		/// <param name='iid'> </param>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string GetNameForIID(System.Guid iid);
		
		/// <summary>Member EnumerateInterfaces </summary>
		/// <returns>A nsIEnumerator</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIEnumerator EnumerateInterfaces();
		
		/// <summary>Member AutoRegisterInterfaces </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AutoRegisterInterfaces();
		
		/// <summary>Member EnumerateInterfacesWhoseNamesStartWith </summary>
		/// <param name='prefix'> </param>
		/// <returns>A nsIEnumerator</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIEnumerator EnumerateInterfacesWhoseNamesStartWith([MarshalAs(UnmanagedType.LPStr)] System.String  prefix);
		
		/// <summary>Member AddAdditionalManager </summary>
		/// <param name='manager'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddAdditionalManager([MarshalAs(UnmanagedType.Interface)] nsIInterfaceInfoManager  manager);
		
		/// <summary>Member RemoveAdditionalManager </summary>
		/// <param name='manager'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAdditionalManager([MarshalAs(UnmanagedType.Interface)] nsIInterfaceInfoManager  manager);
		
		/// <summary>Member HasAdditionalManagers </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasAdditionalManagers();
		
		/// <summary>Member EnumerateAdditionalManagers </summary>
		/// <returns>A nsISimpleEnumerator</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator EnumerateAdditionalManagers();
	}
}
