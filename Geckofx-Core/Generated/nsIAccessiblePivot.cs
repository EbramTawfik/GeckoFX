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
// Generated by IDLImporter from file nsIAccessiblePivot.idl
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
    /// The pivot interface encapsulates a reference to a single place in an accessible
    /// subtree. The pivot is a point or a range in the accessible tree. This interface
    /// provides traversal methods to move the pivot to next/prev state that complies
    /// to a given rule.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c2938033-e240-4fe5-9cb6-e7ad649ccd10")]
	public interface nsIAccessiblePivot
	{
		
		/// <summary>
        /// The accessible the pivot is currently pointed at.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetPositionAttribute();
		
		/// <summary>
        /// The accessible the pivot is currently pointed at.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPositionAttribute([MarshalAs(UnmanagedType.Interface)] nsIAccessible aPosition);
		
		/// <summary>
        /// The root of the subtree in which the pivot traverses.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetRootAttribute();
		
		/// <summary>
        /// The temporary modal root to which traversal is limited to.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetModalRootAttribute();
		
		/// <summary>
        /// The temporary modal root to which traversal is limited to.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetModalRootAttribute([MarshalAs(UnmanagedType.Interface)] nsIAccessible aModalRoot);
		
		/// <summary>
        /// The start offset of the text range the pivot points at, otherwise -1.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetStartOffsetAttribute();
		
		/// <summary>
        /// The end offset of the text range the pivot points at, otherwise -1.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetEndOffsetAttribute();
		
		/// <summary>
        /// Set the pivot's text range in a text accessible.
        ///
        /// @param aTextAccessible [in] the text accessible that contains the desired
        /// range.
        /// @param aStartOffset    [in] the start offset to set.
        /// @param aEndOffset      [in] the end offset to set.
        /// @throws NS_ERROR_INVALID_ARG when the offset exceeds the accessible's
        /// character count.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextRange([MarshalAs(UnmanagedType.Interface)] nsIAccessibleText aTextAccessible, int aStartOffset, int aEndOffset);
		
		/// <summary>
        /// Move pivot to next object, from current position or given anchor,
        /// complying to given traversal rule.
        ///
        /// @param aRule         [in] traversal rule to use.
        /// @param aAnchor       [in] accessible to start search from, if not provided,
        /// current position will be used.
        /// @param aIncludeStart [in] include anchor accessible in search.
        /// @return true on success, false if there are no new nodes to traverse to.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool MoveNext([MarshalAs(UnmanagedType.Interface)] nsIAccessibleTraversalRule aRule, [MarshalAs(UnmanagedType.Interface)] nsIAccessible aAnchor, [MarshalAs(UnmanagedType.U1)] bool aIncludeStart, int argc);
		
		/// <summary>
        /// Move pivot to previous object, from current position or given anchor,
        /// complying to given traversal rule.
        ///
        /// @param aRule         [in] traversal rule to use.
        /// @param aAnchor       [in] accessible to start search from, if not provided,
        /// current position will be used.
        /// @param aIncludeStart [in] include anchor accessible in search.
        /// @return true on success, false if there are no new nodes to traverse to.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool MovePrevious([MarshalAs(UnmanagedType.Interface)] nsIAccessibleTraversalRule aRule, [MarshalAs(UnmanagedType.Interface)] nsIAccessible aAnchor, [MarshalAs(UnmanagedType.U1)] bool aIncludeStart, int argc);
		
		/// <summary>
        /// Move pivot to first object in subtree complying to given traversal rule.
        ///
        /// @param aRule [in] traversal rule to use.
        /// @return true on success, false if there are no new nodes to traverse to.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool MoveFirst([MarshalAs(UnmanagedType.Interface)] nsIAccessibleTraversalRule aRule);
		
		/// <summary>
        /// Move pivot to last object in subtree complying to given traversal rule.
        ///
        /// @param aRule [in] traversal rule to use.
        /// @return true on success, false if there are no new nodes to traverse to.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool MoveLast([MarshalAs(UnmanagedType.Interface)] nsIAccessibleTraversalRule aRule);
		
		/// <summary>
        /// Move pivot to next text range.
        ///
        /// @param aBoundary [in] type of boundary for next text range, character, word,
        /// etc.
        /// @return true on success, false if there are is no more text.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool MoveNextByText(TextBoundaryType aBoundary);
		
		/// <summary>
        /// Move pivot to previous text range.
        ///
        /// @param aBoundary [in] type of boundary for previous text range, character,
        /// word, etc.
        /// @return true on success, false if there are is no more text.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool MovePreviousByText(TextBoundaryType aBoundary);
		
		/// <summary>
        /// Move pivot to given coordinate in screen pixels.
        ///
        /// @param aRule          [in]  raversal rule to use.
        /// @param aX             [in]  screen's x coordinate
        /// @param aY             [in]  screen's y coordinate
        /// @param aIgnoreNoMatch [in]  don't unset position if no object was found at
        /// point.
        /// @return true on success, false if the pivot has not been moved.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool MoveToPoint([MarshalAs(UnmanagedType.Interface)] nsIAccessibleTraversalRule aRule, int aX, int aY, [MarshalAs(UnmanagedType.U1)] bool aIgnoreNoMatch);
		
		/// <summary>
        /// Add an observer for pivot changes.
        ///
        /// @param aObserver [in] the observer object to be notified of pivot changes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIAccessiblePivotObserver aObserver);
		
		/// <summary>
        /// Remove an observer for pivot changes.
        ///
        /// @param aObserver [in] the observer object to remove from being notified.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIAccessiblePivotObserver aObserver);
	}
	
	/// <summary>nsIAccessiblePivotConsts </summary>
	public class nsIAccessiblePivotConsts
	{
		
		// <summary>
        // The pivot interface encapsulates a reference to a single place in an accessible
        // subtree. The pivot is a point or a range in the accessible tree. This interface
        // provides traversal methods to move the pivot to next/prev state that complies
        // to a given rule.
        // </summary>
		public const long CHAR_BOUNDARY = 0;
		
		// 
		public const long WORD_BOUNDARY = 1;
		
		// 
		public const long LINE_BOUNDARY = 2;
		
		// 
		public const long ATTRIBUTE_RANGE_BOUNDARY = 3;
		
		// 
		public const long REASON_NONE = 0;
		
		// 
		public const long REASON_NEXT = 1;
		
		// 
		public const long REASON_PREV = 2;
		
		// 
		public const long REASON_FIRST = 3;
		
		// 
		public const long REASON_LAST = 4;
		
		// 
		public const long REASON_TEXT = 5;
		
		// 
		public const long REASON_POINT = 6;
	}
	
	/// <summary>
    /// An observer interface for pivot changes.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b6508c5e-c081-467d-835c-613eedf9ee9b")]
	public interface nsIAccessiblePivotObserver
	{
		
		/// <summary>
        /// Called when the pivot changes.
        ///
        /// @param aPivot         [in] the pivot that has changed.
        /// @param aOldAccessible [in] the old pivot position before the change, or null.
        /// @param aOldStart      [in] the old start offset, or -1.
        /// @param aOldEnd        [in] the old end offset, or -1.
        /// @param aReason        [in] the reason for the pivot change.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnPivotChanged([MarshalAs(UnmanagedType.Interface)] nsIAccessiblePivot aPivot, [MarshalAs(UnmanagedType.Interface)] nsIAccessible aOldAccessible, int aOldStart, int aOldEnd, PivotMoveReason aReason);
	}
	
	/// <summary>nsIAccessibleTraversalRule </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4d9c4352-20f5-4c54-9580-0c77bb6b1115")]
	public interface nsIAccessibleTraversalRule
	{
		
		/// <summary>
        /// Pre-filter bitfield to filter out obviously ignorable nodes and lighten
        /// the load on match().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetPreFilterAttribute();
		
		/// <summary>
        /// Retrieve a list of roles that the traversal rule should test for. Any node
        /// with a role not in this list will automatically be ignored. An empty list
        /// will match all roles. It should be assumed that this method is called once
        /// at the start of a traversal, so changing the method's return result after
        /// that would have no affect.
        ///
        /// @param aRoles [out] an array of the roles to match.
        /// @param aCount [out] the length of the array.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMatchRoles([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref uint[] aRoles);
		
		/// <summary>
        /// Determines if a given accessible is to be accepted in our traversal rule
        ///
        /// @param aAccessible [in] accessible to examine.
        /// @return a bitfield of FILTER_MATCH and FILTER_IGNORE_SUBTREE.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint Match([MarshalAs(UnmanagedType.Interface)] nsIAccessible aAccessible);
	}
	
	/// <summary>nsIAccessibleTraversalRuleConsts </summary>
	public class nsIAccessibleTraversalRuleConsts
	{
		
		// <summary>
        //Ignore this accessible object </summary>
		public const ushort FILTER_IGNORE = 0x0;
		
		// <summary>
        //Accept this accessible object </summary>
		public const ushort FILTER_MATCH = 0x1;
		
		// <summary>
        //Don't traverse accessibles children </summary>
		public const ushort FILTER_IGNORE_SUBTREE = 0x2;
		
		// <summary>
        //Pre-filters </summary>
		public const ulong PREFILTER_INVISIBLE = 0x00000001;
		
		// 
		public const ulong PREFILTER_OFFSCREEN = 0x00000002;
		
		// 
		public const ulong PREFILTER_NOT_FOCUSABLE = 0x00000004;
		
		// 
		public const ulong PREFILTER_ARIA_HIDDEN = 0x00000008;
		
		// 
		public const ulong PREFILTER_TRANSPARENT = 0x00000010;
	}
}
