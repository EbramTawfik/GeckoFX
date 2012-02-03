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
// Generated by IDLImporter from file nsIAccessible.idl
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
    /// A cross-platform interface that supports platform-specific
    /// accessibility APIs like MSAA and ATK. Contains the sum of what's needed
    /// to support IAccessible as well as ATK's generic accessibility objects.
    /// Can also be used by in-process accessibility clients to get information
    /// about objects in the accessible tree. The accessible tree is a subset of
    /// nodes in the DOM tree -- such as documents, focusable elements and text.
    /// Mozilla creates the implementations of nsIAccessible on demand.
    /// See http://www.mozilla.org/projects/ui/accessibility for more information.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3126544c-826c-4694-a2ed-67bfe56a1f37")]
	public interface nsIAccessible
	{
		
		/// <summary>
        /// Parent node in accessible tree.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetParentAttribute();
		
		/// <summary>
        /// Next sibling in accessible tree
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetNextSiblingAttribute();
		
		/// <summary>
        /// Previous sibling in accessible tree
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetPreviousSiblingAttribute();
		
		/// <summary>
        /// First child in accessible tree
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetFirstChildAttribute();
		
		/// <summary>
        /// Last child in accessible tree
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetLastChildAttribute();
		
		/// <summary>
        /// Array of all this element's children.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetChildrenAttribute();
		
		/// <summary>
        /// Number of accessible children
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetChildCountAttribute();
		
		/// <summary>
        /// The 0-based index of this accessible in its parent's list of children,
        /// or -1 if this accessible does not have a parent.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetIndexInParentAttribute();
		
		/// <summary>
        /// Accessible name -- the main text equivalent for this node. The name is
        /// specified by ARIA or by native markup. Example of ARIA markup is
        /// aria-labelledby attribute placed on element of this accessible. Example
        /// of native markup is HTML label linked with HTML element of this accessible.
        ///
        /// Value can be string or null. A null value indicates that AT may attempt to
        /// compute the name. Any string value, including the empty string, should be
        /// considered author-intentional, and respected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aName);
		
		/// <summary>
        /// Accessible name -- the main text equivalent for this node. The name is
        /// specified by ARIA or by native markup. Example of ARIA markup is
        /// aria-labelledby attribute placed on element of this accessible. Example
        /// of native markup is HTML label linked with HTML element of this accessible.
        ///
        /// Value can be string or null. A null value indicates that AT may attempt to
        /// compute the name. Any string value, including the empty string, should be
        /// considered author-intentional, and respected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aName);
		
		/// <summary>
        /// Accessible value -- a number or a secondary text equivalent for this node
        /// Widgets that use role attribute can force a value using the valuenow attribute
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue);
		
		/// <summary>
        /// Accessible description -- long text associated with this node
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDescription);
		
		/// <summary>
        /// Provides localized string of accesskey name, such as Alt+D.
        /// The modifier may be affected by user and platform preferences.
        /// Usually alt+letter, or just the letter alone for menu items.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetKeyboardShortcutAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aKeyboardShortcut);
		
		/// <summary>
        /// Provides localized string of global keyboard accelerator for default
        /// action, such as Ctrl+O for Open file
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDefaultKeyBindingAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDefaultKeyBinding);
		
		/// <summary>
        /// Provides array of localized string of global keyboard accelerator for
        /// the given action index supported by accessible.
        ///
        /// @param aActionIndex - index of the given action
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetKeyBindings(byte aActionIndex);
		
		/// <summary>
        /// Enumerated accessible role (see the constants defined in nsIAccessibleRole).
        ///
        /// @note  The values might depend on platform because of variations. Widgets
        /// can use ARIA role attribute to force the final role.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetRoleAttribute();
		
		/// <summary>
        /// Accessible states -- bit fields which describe boolean properties of node.
        /// Many states are only valid given a certain role attribute that supports
        /// them.
        ///
        /// @param aState - the first bit field (see nsIAccessibleStates::STATE_*
        /// constants)
        /// @param aExtraState - the second bit field
        /// (see nsIAccessibleStates::EXT_STATE_* constants)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetState(ref uint aState, ref uint aExtraState);
		
		/// <summary>
        /// Help text associated with node
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHelpAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aHelp);
		
		/// <summary>
        /// Focused accessible child of node
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetFocusedChildAttribute();
		
		/// <summary>
        /// Attributes of accessible
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPersistentProperties GetAttributesAttribute();
		
		/// <summary>
        /// Returns grouping information. Used for tree items, list items, tab panel
        /// labels, radio buttons, etc. Also used for collectons of non-text objects.
        ///
        /// @param groupLevel - 1-based, similar to ARIA 'level' property
        /// @param similarItemsInGroup - 1-based, similar to ARIA 'setsize' property,
        /// inclusive of the current item
        /// @param positionInGroup - 1-based, similar to ARIA 'posinset' property
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GroupPosition(ref int aGroupLevel, ref int aSimilarItemsInGroup, ref int aPositionInGroup);
		
		/// <summary>
        /// Accessible child which contains the coordinate at (x, y) in screen pixels.
        /// If the point is in the current accessible but not in a child, the
        /// current accessible will be returned.
        /// If the point is in neither the current accessible or a child, then
        /// null will be returned.
        ///
        /// @param x  screen's x coordinate
        /// @param y  screen's y coordinate
        /// @return   the deepest accessible child containing the given point
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetChildAtPoint(int x, int y);
		
		/// <summary>
        /// Deepest accessible child which contains the coordinate at (x, y) in screen
        /// pixels. If the point is in the current accessible but not in a child, the
        /// current accessible will be returned. If the point is in neither the current
        /// accessible or a child, then null will be returned.
        ///
        /// @param x  screen's x coordinate
        /// @param y  screen's y coordinate
        /// @return   the deepest accessible child containing the given point
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetDeepestChildAtPoint(int x, int y);
		
		/// <summary>
        /// Nth accessible child using zero-based index or last child if index less than zero
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetChildAt(int aChildIndex);
		
		/// <summary>
        /// Return accessible relation by the given relation type (see.
        /// constants defined in nsIAccessibleRelation).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessibleRelation GetRelationByType(uint aRelationType);
		
		/// <summary>
        /// Returns multiple accessible relations for this object.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetRelations();
		
		/// <summary>
        /// Return accessible's x and y coordinates relative to the screen and
        /// accessible's width and height.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBounds(ref int x, ref int y, ref int width, ref int height);
		
		/// <summary>
        /// Add or remove this accessible to the current selection
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelected([MarshalAs(UnmanagedType.Bool)] bool isSelected);
		
		/// <summary>
        /// Extend the current selection from its current accessible anchor node
        /// to this accessible
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExtendSelection();
		
		/// <summary>
        /// Select this accessible node only
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TakeSelection();
		
		/// <summary>
        /// Focus this accessible node,
        /// The state STATE_FOCUSABLE indicates whether this node is normally focusable.
        /// It is the callers responsibility to determine whether this node is focusable.
        /// accTakeFocus on a node that is not normally focusable (such as a table),
        /// will still set focus on that node, although normally that will not be visually
        /// indicated in most style sheets.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TakeFocus();
		
		/// <summary>
        /// The number of accessible actions associated with this accessible
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		byte GetNumActionsAttribute();
		
		/// <summary>
        /// The name of the accessible action at the given zero-based index
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetActionName(byte index, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// The description of the accessible action at the given zero-based index
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetActionDescription(byte aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Perform the accessible action at the given zero-based index
        /// Action number 0 is the default action
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoAction(byte index);
		
		/// <summary>
        /// Get a pointer to accessibility interface for this node, which is specific
        /// to the OS/accessibility toolkit we're running on.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNativeInterface(ref System.IntPtr aOutAccessible);
	}
}
