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
// Generated by IDLImporter from file nsIFIXptr.idl
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
    /// nsIFIXptrEvaluator resolves a FIXptr expression
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("50D28211-8FB8-4323-B93D-08A6E80E559E")]
	public interface nsIFIXptrEvaluator
	{
		
		/// <summary>
        /// Evaluate a FIXptr expression.
        ///
        /// @param aDocument   The document in which to evaluate.
        /// @param aExpression The FIXptr expression string to evaluate.
        /// @return            The result.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMRange Evaluate([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument  aDocument, [MarshalAs(UnmanagedType.LPStruct)] nsAString aExpression);
	}
}
