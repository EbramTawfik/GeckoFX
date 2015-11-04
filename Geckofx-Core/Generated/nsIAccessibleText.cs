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
// Generated by IDLImporter from file nsIAccessibleText.idl
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
    ///-*- Mode: C++; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
    ///
    /// This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("88789f40-54c9-494a-846d-3acaaf4cf46a")]
	public interface nsIAccessibleText
	{
		
		/// <summary>
        /// The current current caret offset.
        /// If set < 0 then caret will be placed  at the end of the text
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetCaretOffsetAttribute();
		
		/// <summary>
        /// The current current caret offset.
        /// If set < 0 then caret will be placed  at the end of the text
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCaretOffsetAttribute(int aCaretOffset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetCharacterCountAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetSelectionCountAttribute();
		
		/// <summary>
        /// String methods may need to return multibyte-encoded strings,
        /// since some locales can't be encoded using 16-bit chars.
        /// So the methods below might return UTF-16 strings, or they could
        /// return "string" values which are UTF-8.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetText(int startOffset, int endOffset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextAfterOffset(int offset, AccessibleTextBoundary boundaryType, ref int startOffset, ref int endOffset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextAtOffset(int offset, AccessibleTextBoundary boundaryType, ref int startOffset, ref int endOffset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextBeforeOffset(int offset, AccessibleTextBoundary boundaryType, ref int startOffset, ref int endOffset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// It would be better to return an unsigned long here,
        /// to allow unicode chars > 16 bits
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		char GetCharacterAtOffset(int offset);
		
		/// <summary>
        /// Get the accessible start/end offsets around the given offset,
        /// return the text attributes for this range of text.
        ///
        /// @param  includeDefAttrs   [in] points whether text attributes applied to
        /// the entire accessible should be included or not.
        /// @param  offset            [in] text offset
        /// @param  rangeStartOffset  [out] start offset of the range of text
        /// @param  rangeEndOffset    [out] end offset of the range of text
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPersistentProperties GetTextAttributes([MarshalAs(UnmanagedType.U1)] bool includeDefAttrs, int offset, ref int rangeStartOffset, ref int rangeEndOffset);
		
		/// <summary>
        /// Return the text attributes that apply to the entire accessible.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPersistentProperties GetDefaultTextAttributesAttribute();
		
		/// <summary>
        /// Returns the bounding box of the specified position.
        ///
        /// The virtual character after the last character of the represented text,
        /// i.e. the one at position length is a special case. It represents the
        /// current input position and will therefore typically be queried by AT more
        /// often than other positions. Because it does not represent an existing
        /// character its bounding box is defined in relation to preceding characters.
        /// It should be roughly equivalent to the bounding box of some character when
        /// inserted at the end of the text. Its height typically being the maximal
        /// height of all the characters in the text or the height of the preceding
        /// character, its width being at least one pixel so that the bounding box is
        /// not degenerate.
        ///
        /// @param offset - Index of the character for which to return its bounding
        /// box. The valid range is 0..length.
        /// @param x - X coordinate of the bounding box of the referenced character.
        /// @param y - Y coordinate of the bounding box of the referenced character.
        /// @param width - Width of the bounding box of the referenced character.
        /// @param height - Height of the bounding box of the referenced character.
        /// @param coordType - Specifies if the coordinates are relative to the screen
        /// or to the parent window (see constants declared in
        /// nsIAccessibleCoordinateType).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCharacterExtents(int offset, ref int x, ref int y, ref int width, ref int height, uint coordType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRangeExtents(int startOffset, int endOffset, ref int x, ref int y, ref int width, ref int height, uint coordType);
		
		/// <summary>
        /// Get the text offset at the given point, or return -1
        /// if no character exists at that point
        ///
        /// @param x - The position's x value for which to look up the index of the
        /// character that is rendered on to the display at that point.
        /// @param y - The position's y value for which to look up the index of the
        /// character that is rendered on to the display at that point.
        /// @param coordType - Screen coordinates or window coordinates (see constants
        /// declared in nsIAccessibleCoordinateType).
        /// @return offset - Index of the character under the given point or -1 if
        /// the point is invalid or there is no character under
        /// the point.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOffsetAtPoint(int x, int y, uint coordType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSelectionBounds(int selectionNum, ref int startOffset, ref int endOffset);
		
		/// <summary>
        /// Set the bounds for the given selection range
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectionBounds(int selectionNum, int startOffset, int endOffset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddSelection(int startOffset, int endOffset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveSelection(int selectionNum);
		
		/// <summary>
        /// Makes a specific part of string visible on screen.
        ///
        /// @param startIndex  0-based character offset
        /// @param endIndex    0-based character offset - the offset of the
        /// character just past the last character of the
        /// string
        /// @param scrollType  defines how to scroll (see nsIAccessibleScrollType for
        /// available constants)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollSubstringTo(int startIndex, int endIndex, uint scrollType);
		
		/// <summary>
        /// Moves the top left of a substring to a specified location.
        ///
        /// @param startIndex      0-based character offset
        /// @param endIndex        0-based character offset - the offset of the
        /// character just past the last character of
        /// the string
        /// @param coordinateType  specifies the coordinates origin (for available
        /// constants refer to nsIAccessibleCoordinateType)
        /// @param x               defines the x coordinate
        /// @param y               defines the y coordinate
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollSubstringToPoint(int startIndex, int endIndex, uint coordinateType, int x, int y);
		
		/// <summary>
        /// Return a range that encloses this text control or otherwise the document
        /// this text accessible belongs to.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessibleTextRange GetEnclosingRangeAttribute();
		
		/// <summary>
        /// Return an array of disjoint ranges for selected text within the text control
        /// or otherwise the document this accessible belongs to.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetSelectionRangesAttribute();
		
		/// <summary>
        /// Return an array of disjoint ranges of visible text within the text control
        /// or otherwise the document this accessible belongs to.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetVisibleRangesAttribute();
		
		/// <summary>
        /// Return a range containing the given accessible.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessibleTextRange GetRangeByChild([MarshalAs(UnmanagedType.Interface)] nsIAccessible child);
		
		/// <summary>
        /// Return a range containing an accessible at the given point.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessibleTextRange GetRangeAtPoint(int x, int y);
	}
	
	/// <summary>nsIAccessibleTextConsts </summary>
	public class nsIAccessibleTextConsts
	{
		
		// <summary>
        //  -2 will be treated as the caret position
        // </summary>
		public const long TEXT_OFFSET_END_OF_TEXT = -1;
		
		// 
		public const long TEXT_OFFSET_CARET = -2;
		
		// 
		public const long BOUNDARY_CHAR = 0;
		
		// 
		public const long BOUNDARY_WORD_START = 1;
		
		// 
		public const long BOUNDARY_WORD_END = 2;
		
		// 
		public const long BOUNDARY_SENTENCE_START = 3;
		
		// <summary>
        // don't use, deprecated
        // </summary>
		public const long BOUNDARY_SENTENCE_END = 4;
		
		// <summary>
        // don't use, deprecated
        // </summary>
		public const long BOUNDARY_LINE_START = 5;
		
		// 
		public const long BOUNDARY_LINE_END = 6;
	}
}
