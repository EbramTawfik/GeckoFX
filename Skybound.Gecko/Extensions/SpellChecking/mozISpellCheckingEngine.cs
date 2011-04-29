using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Runtime.CompilerServices;

namespace Skybound.Gecko.Extensions.SpellChecking
{
	/**
	* This interface represents a SpellChecker.
	*/	
	[Guid("43987F7B-0FAA-4019-811E-42BECAC73FC5"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface mozISpellCheckingEngine : nsISupports
	{
		/**
		 * The name of the current dictionary
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetDictionary([MarshalAs(UnmanagedType.LPStruct)] nsAString dictionary);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetDictionary([MarshalAs(UnmanagedType.LPStruct)] nsAString dictionary);

		/**
		 * The language this spellchecker is using when checking
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetLanguage([MarshalAs(UnmanagedType.LPStruct)] nsAString language);

		/**
		 * Does the engine provide its own personal dictionary?
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool GetProvidesPersonalDictionary();

		/**
		 * Does the engine provide its own word utils?
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool GetProvidesWordUtils();

		/**
		 * The name of the engine
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetName([MarshalAs(UnmanagedType.LPStruct)] nsAString name);

		/** 
		 * a string indicating the copyright of the engine
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetCopyright([MarshalAs(UnmanagedType.LPStruct)] nsAString copyWrite);

		/**
		 * the personal dictionary
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IntPtr/*mozIPersonalDictionary*/ GetPersonalDictionary();

		/**
		 * Get the list of dictionaries
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void getDictionaryList([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] nsAString[] dictionaries, out Int32 count);

		/**
		 * check a word
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool check([MarshalAs(UnmanagedType.LPStruct)] nsAString word);

		/**
		 * get a list of suggestions for a misspelled word
		 */
		void suggest([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] nsAString[] suggestions, out Int32 count);
	};
}

