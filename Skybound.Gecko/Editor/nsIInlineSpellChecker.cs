using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Runtime.CompilerServices;

namespace Skybound.Gecko.Editor
{
	[Guid("07be036a-2355-4a92-b150-5c9b7e9fdf2f"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]	
	public interface nsIInlineSpellChecker : nsISupports
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		nsIEditorSpellCheck GetSpellChecker();
 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)]nsIEditor aEditor);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Cleanup(bool aDestroyingFrames);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool GetEnableRealTimeSpell();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetEnableRealTimeSpell(bool enable);
 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SpellCheckAfterEditorChange(long aAction,
										[MarshalAs(UnmanagedType.Interface)]nsISelection aSelection,
										[MarshalAs(UnmanagedType.Interface)]nsIDOMNode aPreviousSelectedNode,
										long aPreviousSelectedOffset,
										[MarshalAs(UnmanagedType.Interface)]nsIDOMNode aStartNode,
										long aStartOffset,
										[MarshalAs(UnmanagedType.Interface)]nsIDOMNode aEndNode,
										long aEndOffset);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SpellCheckRange([MarshalAs(UnmanagedType.Interface)]nsIDOMRange aSelection);
 
		[return: MarshalAs(UnmanagedType.Interface)]
		nsIDOMRange GetMisspelledWord([MarshalAs(UnmanagedType.Interface)]nsIDOMNode aNode, long aOffset);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ReplaceWord([MarshalAs(UnmanagedType.Interface)]nsIDOMNode aNode, long aOffset, [MarshalAs(UnmanagedType.LPStruct)]nsAString aNewword);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddWordToDictionary([MarshalAs(UnmanagedType.LPStruct)]nsAString aWord);
   
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void IgnoreWord([MarshalAs(UnmanagedType.LPStruct)]nsAString aWord);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void IgnoreWords([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]nsACString aWordsToIgnore, ulong aCount);
	};
}

