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
// Generated by IDLImporter from file nsIDOMCSSGroupingRule.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// Interface for at-rules that have child rules in the CSS OM.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ab013eed-fa21-4c6a-bba3-79e8780f583e")]
	public interface nsIDOMCSSGroupingRule : nsIDOMCSSRule
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetCssTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCssTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase aCssText);
		
		/// <summary>
        /// raises(DOMException) on setting
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMCSSStyleSheet GetParentStyleSheetAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMCSSRule GetParentRuleAttribute();
		
		/// <summary>
        /// Interface for at-rules that have child rules in the CSS OM.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSRuleList GetCssRulesAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint InsertRule([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase rule, uint index);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteRule(uint index);
	}
}
