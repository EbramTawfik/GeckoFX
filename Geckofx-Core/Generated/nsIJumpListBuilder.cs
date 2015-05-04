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
// Generated by IDLImporter from file nsIJumpListBuilder.idl
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
	[Guid("1FE6A9CD-2B18-4dd5-A176-C2B32FA4F683")]
	public interface nsIJumpListBuilder
	{
		
		/// <summary>
        /// Indicates whether jump list taskbar features are supported by the current
        /// host.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetAvailableAttribute();
		
		/// <summary>
        /// Indicates if a commit has already occurred in this session.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsListCommittedAttribute();
		
		/// <summary>
        /// The maximum number of jump list items the current desktop can support.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetMaxListItemsAttribute();
		
		/// <summary>
        /// Initializes a jump list build and returns a list of items the user removed
        /// since the last time a jump list was committed. Removed items can become state
        /// after initListBuild is called, lists should be built in single-shot fasion.
        ///
        /// @param removedItems
        /// A list of items that were removed by the user since the last commit.
        ///
        /// @returns true if the operation completed successfully.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool InitListBuild([MarshalAs(UnmanagedType.Interface)] nsIMutableArray removedItems);
		
		/// <summary>
        /// Adds a list and if required, a set of items for the list.
        ///
        /// @param aCatType
        /// The type of list to add.
        /// @param items
        /// An array of nsIJumpListItem items to add to the list.
        /// @param catName
        /// For custom lists, the title of the list.
        ///
        /// @returns true if the operation completed successfully.
        ///
        /// @throw NS_ERROR_INVALID_ARG if incorrect parameters are passed for
        /// a particular category or item type.
        /// @throw NS_ERROR_ILLEGAL_VALUE if an item is added that was removed
        /// since the last commit.
        /// @throw NS_ERROR_UNEXPECTED on internal errors.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool AddListToBuild(short aCatType, [MarshalAs(UnmanagedType.Interface)] nsIArray items, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase catName);
		
		/// <summary>
        /// Aborts and clears the current jump list build.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AbortListBuild();
		
		/// <summary>
        /// Commits the current jump list build to the Taskbar.
        ///
        /// @returns true if the operation completed successfully.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CommitListBuild();
		
		/// <summary>
        /// Deletes any currently applied taskbar jump list for this application.
        /// Common uses would be the enabling of a privacy mode and uninstallation.
        ///
        /// @returns true if the operation completed successfully.
        ///
        /// @throw NS_ERROR_UNEXPECTED on internal errors.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool DeleteActiveList();
	}
	
	/// <summary>nsIJumpListBuilderConsts </summary>
	public class nsIJumpListBuilderConsts
	{
		
		// <summary>
        // Task List
        //
        // Tasks are common actions performed by users within the application. A task
        // can be represented by an application shortcut and associated command line
        // parameters or a URI. Task lists should generally be static lists that do not
        // change often, if at all - similar to an application menu.
        //
        // Tasks are given the highest priority of all lists when space is limited.
        // </summary>
		public const short JUMPLIST_CATEGORY_TASKS = 0;
		
		// <summary>
        // Recent or Frequent list
        //
        // Recent and frequent lists are based on Window's recent document lists. The
        // lists are generated automatically by Windows. Applications that use recent
        // or frequent lists should keep document use tracking up to date by calling
        // the SHAddToRecentDocs shell api.
        // </summary>
		public const short JUMPLIST_CATEGORY_RECENT = 1;
		
		// 
		public const short JUMPLIST_CATEGORY_FREQUENT = 2;
		
		// <summary>
        // Custom Lists
        //
        // Custom lists can be made up of tasks, links, and separators. The title of
        // of the list is passed through the optional string parameter of addBuildList.
        // </summary>
		public const short JUMPLIST_CATEGORY_CUSTOMLIST = 3;
	}
}
