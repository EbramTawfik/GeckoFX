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
// Generated by IDLImporter from file nsISSLCertErrorDialog.idl
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
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0729ce8e-8935-4989-ba72-a2d6307f2365")]
	public interface nsISSLCertErrorDialog
	{
		
		/// <summary>
        /// Called when an SSL connection aborts because of a bad certificate,
        /// and no other code is in place for reporting the problem.
        /// Should bring up a dialog to inform the user and display the certificate.
        ///
        /// @param status Might be used to query additional information
        /// @param cert The certificate that this error is about
        /// @param textErrorMessage An error message with whitespace formatting
        /// @param htmlErrorMessage Optional, might either be empty,
        ///                              or might contain the same message as in
        ///                              textErrorMessage plus some html formatting.
        /// @param hostName The error occurred when connecting to this hostName.
        /// @param portNumber The error occurred when connecting to this portNumber.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowCertError([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx, [MarshalAs(UnmanagedType.Interface)] nsISSLStatus status, [MarshalAs(UnmanagedType.Interface)] nsIX509Cert cert, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase textErrorMessage, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase htmlErrorMessage, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase hostName, uint portNumber);
	}
}
