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
// Generated by IDLImporter from file nsICommandParams.idl
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
    /// nsICommandParams is used to pass parameters to commands executed
    /// via nsICommandManager, and to get command state.
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("83f892cf-7ed3-490e-967a-62640f3158e1")]
	public interface nsICommandParams
	{
		
		/// <summary>
        /// getValueType
        ///
        /// Get the type of a specified parameter
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetValueType([MarshalAs(UnmanagedType.LPStr)] System.String  name);
		
		/// <summary>
        /// get_Value
        ///
        /// Get the value of a specified parameter. Will return
        /// an error if the parameter does not exist, or if the value
        /// is of the wrong type (no coercion is performed for you).
        ///
        /// nsISupports values can contain any XPCOM interface,
        /// as documented for the command. It is permissible
        /// for it to contain nsICommandParams, but not *this*
        /// one (i.e. self-containing is not allowed).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBooleanValue([MarshalAs(UnmanagedType.LPStr)] System.String  name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLongValue([MarshalAs(UnmanagedType.LPStr)] System.String  name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetDoubleValue([MarshalAs(UnmanagedType.LPStr)] System.String  name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetStringValue([MarshalAs(UnmanagedType.LPStr)] System.String  name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetCStringValue([MarshalAs(UnmanagedType.LPStr)] System.String  name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetISupportsValue([MarshalAs(UnmanagedType.LPStr)] System.String  name);
		
		/// <summary>
        /// set_Value
        ///
        /// Set the value of a specified parameter (thus creating
        /// an entry for it).
        ///
        /// nsISupports values can contain any XPCOM interface,
        /// as documented for the command. It is permissible
        /// for it to contain nsICommandParams, but not *this*
        /// one (i.e. self-containing is not allowed).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBooleanValue([MarshalAs(UnmanagedType.LPStr)] System.String  name, System.Boolean  value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLongValue([MarshalAs(UnmanagedType.LPStr)] System.String  name, System.Int32  value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDoubleValue([MarshalAs(UnmanagedType.LPStr)] System.String  name, double value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStringValue([MarshalAs(UnmanagedType.LPStr)] System.String  name, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCStringValue([MarshalAs(UnmanagedType.LPStr)] System.String  name, [MarshalAs(UnmanagedType.LPStr)] System.String  value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetISupportsValue([MarshalAs(UnmanagedType.LPStr)] System.String  name, [MarshalAs(UnmanagedType.Interface)] nsISupports  value);
		
		/// <summary>
        /// removeValue
        ///
        /// Remove the specified parameter from the list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveValue([MarshalAs(UnmanagedType.LPStr)] System.String  name);
		
		/// <summary>
        /// Enumeration methods
        ///
        /// Use these to enumerate over the contents of a parameter
        /// list. For each name that getNext() returns, use
        /// getValueType() and then getMumbleValue to get its
        /// value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasMoreElements();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void First();
		
		/// <summary>
        /// GetNext()
        ///
        /// @return string pointer that will be allocated and is up
        /// to the caller to free
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetNext();
	}
}
