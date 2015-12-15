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
// Generated by IDLImporter from file nsIBrowserProfileMigrator.idl
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
	[Guid("22b56ffc-3149-43c5-b5a9-b3a6b678de93")]
	public interface nsIBrowserProfileMigrator
	{
		
		/// <summary>
        /// Copy user profile information to the current active profile.
        /// @param aItems   list of data items to migrate. see above for values.
        /// @param aStartup helper interface which is non-null if called during startup.
        /// @param aProfile profile to migrate from, if there is more than one.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Migrate(ushort aItems, [MarshalAs(UnmanagedType.Interface)] nsIProfileStartup aStartup, ref Gecko.JsVal aProfile);
		
		/// <summary>
        /// A bit field containing profile items that this migrator
        /// offers for import.
        /// @param   aProfile the profile that we are looking for available data
        /// to import
        /// @param   aDoingStartup "true" if the profile is not currently being used.
        /// @return  bit field containing profile items (see above)
        /// @note    a return value of 0 represents no items rather than ALL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMigrateData(ref Gecko.JsVal aProfile, [MarshalAs(UnmanagedType.U1)] bool aDoingStartup);
		
		/// <summary>
        /// Whether or not there is any data that can be imported from this
        /// browser (i.e. whether or not it is installed, and there exists
        /// a user profile)
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSourceExistsAttribute();
		
		/// <summary>
        /// An enumeration of available profiles. If the import source does
        /// not support profiles, this attribute is null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetSourceProfilesAttribute();
		
		/// <summary>
        /// The import source homepage.  Returns null if not present/available
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSourceHomePageURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSourceHomePageURL);
		
		/// <summary>
        /// Whether the source browser data is locked/in-use meaning migration likely
        /// won't succeed and the user should be warned.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSourceLockedAttribute();
	}
	
	/// <summary>nsIBrowserProfileMigratorConsts </summary>
	public class nsIBrowserProfileMigratorConsts
	{
		
		// <summary>
        // profile items to migrate. use with migrate().
        // </summary>
		public const ushort ALL = 0x0000;
		
		// 
		public const ushort SETTINGS = 0x0001;
		
		// 
		public const ushort COOKIES = 0x0002;
		
		// 
		public const ushort HISTORY = 0x0004;
		
		// 
		public const ushort FORMDATA = 0x0008;
		
		// 
		public const ushort PASSWORDS = 0x0010;
		
		// 
		public const ushort BOOKMARKS = 0x0020;
		
		// 
		public const ushort OTHERDATA = 0x0040;
		
		// 
		public const ushort SESSION = 0x0080;
	}
}
