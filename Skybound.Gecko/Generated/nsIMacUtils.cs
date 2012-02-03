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
// Generated by IDLImporter from file nsIMacUtils.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>
    /// nsIMacUtils: Generic globally-available Mac-specific utilities.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5E9072D7-FF95-455E-9466-8AF9841A72EC")]
	public interface nsIMacUtils
	{
		
		/// <summary>
        /// True when the main executable is a fat file supporting at least
        /// ppc and x86 (universal binary).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsUniversalBinaryAttribute();
		
		/// <summary>
        /// Returns a string containing a list of architectures delimited
        /// by "-". Architecture sets are always in the same order:
        /// ppc > i386 > ppc64 > x86_64 > (future additions)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetArchitecturesInBinaryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aArchitecturesInBinary);
		
		/// <summary>
        /// True when running under binary translation (Rosetta).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsTranslatedAttribute();
	}
}
