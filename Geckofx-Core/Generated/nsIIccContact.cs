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
// Generated by IDLImporter from file nsIIccContact.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0f3dbcd1-9f7b-40a8-aa3c-b5701978ec53")]
	public interface nsIIccContact
	{
		
		/// <summary>
        /// The unique identifier of this ICC Contact.
        ///
        /// Note: This id is composed of the iccid and its record index of EF_ADN.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);
		
		/// <summary>
        /// Name list.
        ///
        /// The container of Alpha-Id in EF_ADN and Second Name in EF_SNE of this contact,
        /// where EF_SNE provides the possibility to store a name in different language.
        ///
        /// @see 10.2.1 Support of two name fields per entry, 3GPP TS 21.111.
        ///
        /// @param aCount
        /// The number of names.
        ///
        /// @returns the array of names.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNames(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] aNames);
		
		/// <summary>
        /// Phone number list.
        ///
        /// The container of the dialing numbers of this contact in EF_ADN and EF_ANR.
        ///
        /// @see 10.2.2 Support of multiple phone numbers per entry, 3GPP TS 21.111.
        ///
        /// @param aCount
        /// The number of phone numbers.
        ///
        /// @returns the array of phone numbers.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNumbers(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] aNumbers);
		
		/// <summary>
        /// Email list.
        ///
        /// The container of the emails of this contact in EF_EMAIL.
        ///
        /// @param aCount
        /// The number of emails.
        ///
        /// @returns the array of emails.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEmails(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] aEmails);
	}
}