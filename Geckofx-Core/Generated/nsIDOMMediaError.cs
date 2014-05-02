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
// Generated by IDLImporter from file nsIDOMMediaError.idl
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
	[Guid("7bd8c29f-8a76-453f-9373-79f820f2dc01")]
	public interface nsIDOMMediaError
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetCodeAttribute();
	}
	
	/// <summary>nsIDOMMediaErrorConsts </summary>
	public class nsIDOMMediaErrorConsts
	{
		
		// <summary>
        //The download of the media resource was aborted by
        //     the user agent at the user's requet </summary>
		public const ulong MEDIA_ERR_ABORTED = 1;
		
		// <summary>
        //A network error of some description caused the
        //     user agent to stop downloading the media resource </summary>
		public const ulong MEDIA_ERR_NETWORK = 2;
		
		// <summary>
        //An error of some description occurred while decoding
        //     the media resource </summary>
		public const ulong MEDIA_ERR_DECODE = 3;
		
		// <summary>
        //No suitable media resource could be found </summary>
		public const ulong MEDIA_ERR_SRC_NOT_SUPPORTED = 4;
	}
}
