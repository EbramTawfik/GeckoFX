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
// Generated by IDLImporter from file txIEXSLTRegExFunctions.idl
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
	
	
	/// <summary>txIEXSLTRegExFunctions </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c180e993-aced-4839-95a0-ecd5ff138be9")]
	public interface txIEXSLTRegExFunctions
	{
		
		/// <summary>Member Match </summary>
		/// <param name='aContext'> </param>
		/// <param name='aString'> </param>
		/// <param name='aRegEx'> </param>
		/// <param name='aFlags'> </param>
		/// <returns>A txINodeSet</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		txINodeSet Match(txIFunctionEvaluationContext  aContext, [MarshalAs(UnmanagedType.LPStruct)] nsAString aString, [MarshalAs(UnmanagedType.LPStruct)] nsAString aRegEx, [MarshalAs(UnmanagedType.LPStruct)] nsAString aFlags);
		
		/// <summary>Member Replace </summary>
		/// <param name='aString'> </param>
		/// <param name='aRegEx'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aReplace'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString Replace([MarshalAs(UnmanagedType.LPStruct)] nsAString aString, [MarshalAs(UnmanagedType.LPStruct)] nsAString aRegEx, [MarshalAs(UnmanagedType.LPStruct)] nsAString aFlags, [MarshalAs(UnmanagedType.LPStruct)] nsAString aReplace);
		
		/// <summary>Member Test </summary>
		/// <param name='aString'> </param>
		/// <param name='aRegEx'> </param>
		/// <param name='aFlags'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Test([MarshalAs(UnmanagedType.LPStruct)] nsAString aString, [MarshalAs(UnmanagedType.LPStruct)] nsAString aRegEx, [MarshalAs(UnmanagedType.LPStruct)] nsAString aFlags);
	}
}
