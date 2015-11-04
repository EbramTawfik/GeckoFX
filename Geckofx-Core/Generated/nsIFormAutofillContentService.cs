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
// Generated by IDLImporter from file nsIFormAutofillContentService.idl
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
    /// Defines a service used by DOM content to request Form Autofill, in particular
    /// when the requestAutocomplete method of Form objects is invoked.
    ///
    /// This service lives in the process that hosts the requesting DOM content.
    /// This means that, in a multi-process (e10s) environment, there can be an
    /// instance of the service for each content process, in addition to an instance
    /// for the chrome process.
    ///
    /// @remarks The service implementation uses a child-side message manager to
    /// communicate with a parent-side message manager living in the chrome
    /// process, where most of the processing is located.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1db29340-99df-4845-9102-0c5d281b2fe8")]
	public interface nsIFormAutofillContentService
	{
		
		/// <summary>
        /// Invoked by the requestAutocomplete method of the DOM Form object.
        ///
        /// The application is expected to display a user interface asking for the
        /// details that are relevant to the form being filled in.  The application
        /// should use the "autocomplete" attributes on the input elements as hints
        /// about which type of information is being requested.
        ///
        /// The processing will result in either an "autocomplete" simple DOM Event or
        /// an AutocompleteErrorEvent being fired on the form.
        ///
        /// @param aForm
        /// The form on which the requestAutocomplete method was invoked.
        /// @param aWindow
        /// The window where the form is located.  This must be specified even
        /// for elements that are not in a document, and is used to generate the
        /// DOM events resulting from the operation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RequestAutocomplete([MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLFormElement aForm, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
	}
}
