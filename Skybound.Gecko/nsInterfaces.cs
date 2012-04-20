#region ***** BEGIN LICENSE BLOCK *****
/* Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Skybound Software code.
 *
 * The Initial Developer of the Original Code is Skybound Software.
 * Portions created by the Initial Developer are Copyright (C) 2008-2009
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 */
#endregion END LICENSE BLOCK

using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Runtime.CompilerServices;

namespace Gecko
{	
	public enum nsDirection 
	{
		eDirNext = 0,
		eDirPrevious = 1
	};

	static class nsIWebBrowserChromeConstants
	{
		public const int STATUS_SCRIPT = 1;
		public const int STATUS_SCRIPT_DEFAULT = 2;
		public const int STATUS_LINK = 3;
		
		public const int CHROME_DEFAULT = 1;
		public const int CHROME_WINDOW_BORDERS = 2;
		public const int CHROME_WINDOW_CLOSE = 4;
		public const int CHROME_WINDOW_RESIZE = 8;
		public const int CHROME_MENUBAR = 16;
		public const int CHROME_TOOLBAR = 32;
		public const int CHROME_LOCATIONBAR = 64;
		public const int CHROME_STATUSBAR = 128;
		public const int CHROME_PERSONAL_TOOLBAR = 256;
		public const int CHROME_SCROLLBARS = 512;
		public const int CHROME_TITLEBAR = 1024;
		public const int CHROME_EXTRA = 2048;
		public const int CHROME_WITH_SIZE = 4096;
		public const int CHROME_WITH_POSITION = 8192;
		public const int CHROME_WINDOW_MIN = 16384;
		public const int CHROME_WINDOW_POPUP = 32768;
		public const int CHROME_WINDOW_RAISED = 33554432;
		public const int CHROME_WINDOW_LOWERED = 67108864;
		public const int CHROME_CENTER_SCREEN = 134217728;
		public const int CHROME_DEPENDENT = 268435456;
		public const int CHROME_MODAL = 536870912;
		public const int CHROME_OPENAS_DIALOG = 1073741824;
		public const int CHROME_OPENAS_CHROME = unchecked((int)2147483648);
		public const int CHROME_ALL = 4094;
	}

	static class nsIXulWindowConstants
	{
		public const uint lowestZ = 0;
		public const uint loweredZ = 4;	// "alwaysLowered" attribute
		public const uint normalZ = 5;
		public const uint raisedZ = 6;	// "alwaysRaised" attribute
		public const uint highestZ = 9;
	}
	
	static class nsIWebNavigationConstants
	{
		/****************************************************************************
		 * The following flags may be bitwise combined to form the load flags
		 * parameter passed to either the loadURI or reload method.  Some of these
		 * flags are only applicable to loadURI.
		 */
		public const int LOAD_FLAGS_MASK = 65535;
		public const int LOAD_FLAGS_NONE = 0;
		public const int LOAD_FLAGS_IS_REFRESH = 16;
		public const int LOAD_FLAGS_IS_LINK = 32;
		public const int LOAD_FLAGS_BYPASS_HISTORY = 64;
		public const int LOAD_FLAGS_REPLACE_HISTORY = 128;
		public const int LOAD_FLAGS_BYPASS_CACHE = 256;
		public const int LOAD_FLAGS_BYPASS_PROXY = 512;
		public const int LOAD_FLAGS_CHARSET_CHANGE = 1024;
		public const int LOAD_FLAGS_STOP_CONTENT = 2048;
		public const int LOAD_FLAGS_FROM_EXTERNAL = 4096;
		public const int LOAD_FLAGS_ALLOW_THIRD_PARTY_FIXUP = 8192;
		public const int LOAD_FLAGS_FIRST_LOAD = 16384;

		/****************************************************************************
		* The following flags may be passed as the stop flags parameter to the stop
		* method defined on this interface.
		*/
		public const int STOP_NETWORK = 1;
		public const int STOP_CONTENT = 2;
		public const int STOP_ALL = 3;
	}

	static class nsIWebBrowserPersistConstants
	{
		public const uint PERSIST_FLAGS_NONE = 0;
		public const uint PERSIST_FLAGS_FROM_CACHE = 1;
		public const uint PERSIST_FLAGS_BYPASS_CACHE = 2;
		public const uint PERSIST_FLAGS_IGNORE_REDIRECTED_DATA = 4;
		public const uint PERSIST_FLAGS_IGNORE_IFRAMES = 8;
		public const uint PERSIST_FLAGS_NO_CONVERSION = 16;
		public const uint PERSIST_FLAGS_REPLACE_EXISTING_FILES = 32;
		public const uint PERSIST_FLAGS_NO_BASE_TAG_MODIFICATIONS = 64;
		public const uint PERSIST_FLAGS_FIXUP_ORIGINAL_DOM = 128;
		public const uint PERSIST_FLAGS_FIXUP_LINKS_TO_DESTINATION = 256;
		public const uint PERSIST_FLAGS_DONT_FIXUP_LINKS = 512;
		public const uint PERSIST_FLAGS_SERIALIZE_OUTPUT = 1024;
		public const uint PERSIST_FLAGS_DONT_CHANGE_FILENAMES = 2048;
		public const uint PERSIST_FLAGS_FAIL_ON_BROKEN_LINKS = 4096;
		public const uint PERSIST_FLAGS_CLEANUP_ON_FAILURE = 8192;
		public const uint PERSIST_FLAGS_AUTODETECT_APPLY_CONVERSION = 16384;
		public const uint PERSIST_FLAGS_APPEND_TO_FILE = 32768;
		public const uint PERSIST_FLAGS_FORCE_ALLOW_COOKIES = 65536;

		public const uint PERSIST_STATE_READY = 1;
		public const uint PERSIST_STATE_SAVING = 2;
		public const uint PERSIST_STATE_FINISHED = 3;

		public const uint ENCODE_FLAGS_SELECTION_ONLY = 1;
		public const uint ENCODE_FLAGS_FORMATTED = 2;
		public const uint ENCODE_FLAGS_RAW = 4;
		public const uint ENCODE_FLAGS_BODY_ONLY = 8;
		public const uint ENCODE_FLAGS_PREFORMATTED = 16;
		public const uint ENCODE_FLAGS_WRAP = 32;
		public const uint ENCODE_FLAGS_FORMAT_FLOWED = 64;
		public const uint ENCODE_FLAGS_ABSOLUTE_LINKS = 128;
		public const uint ENCODE_FLAGS_ENCODE_W3C_ENTITIES = 256;
		public const uint ENCODE_FLAGS_CR_LINEBREAKS = 512;
		public const uint ENCODE_FLAGS_LF_LINEBREAKS = 1024;
		public const uint ENCODE_FLAGS_NOSCRIPT_CONTENT = 2048;
		public const uint ENCODE_FLAGS_NOFRAMES_CONTENT = 4096;
		public const uint ENCODE_FLAGS_ENCODE_BASIC_ENTITIES = 8192;
		public const uint ENCODE_FLAGS_ENCODE_LATIN1_ENTITIES = 16384;
		public const uint ENCODE_FLAGS_ENCLODE_HTML_ENTITIES = 32768;
	}

	static class nsIContextMenuListener2Constants
	{
		public const uint CONTEXT_NONE = 0;
		public const uint CONTEXT_LINK = 1;
		public const uint CONTEXT_IMAGE = 2;
		public const uint CONTEXT_DOCUMENT = 4;
		public const uint CONTEXT_TEXT = 8;
		public const uint CONTEXT_INPUT = 16;
		public const uint CONTEXT_BACKGROUND_IMAGE = 32;
	}

	static class imgIContainerConstants
	{
		public const ushort TYPE_RASTER = 0;
		public const ushort TYPE_VECTOR = 1;

		public const long FLAG_NONE = 0x0;
		public const long FLAG_SYNC_DECODE = 0x1;
		public const long FLAG_DECODE_NO_PREMULTIPLY_ALPHA = 0x2;
		public const long FLAG_DECODE_NO_COLORSPACE_CONVERSION = 0x4;

		public const uint FRAME_FIRST = 0;
		public const uint FRAME_CURRENT = 1;
		public const uint FRAME_MAX_VALUE = 1;

		public const short kNormalAnimMode = 0;
		public const short kDontAnimMode = 1;
		public const short kLoopOnceAnimMode = 2;
	}
	
	static class nsIEmbeddingSiteWindowConstants
	{
		public const int DIM_FLAGS_POSITION = 1;
		public const int DIM_FLAGS_SIZE_INNER = 2;
		public const int DIM_FLAGS_SIZE_OUTER = 4;
	}
	
	static class nsIDocShellTreeItemConstants
	{
		public const int typeChrome = 0;
		public const int typeContent = 1;
		public const int typeContentWrapper = 2;
		public const int typeChromeWrapper = 3;
		public const int typeAll = 2147483647;
	}
	
	static class nsIWebProgressListenerConstants
	{
		public const int STATE_START = 0x1;
		public const int STATE_REDIRECTING = 0x2;
		public const int STATE_TRANSFERRING = 0x4;
		public const int STATE_NEGOTIATING = 0x8;
		public const int STATE_STOP = 0x10;
		public const int STATE_IS_REQUEST = 0x10000;
		public const int STATE_IS_DOCUMENT = 0x20000;
		public const int STATE_IS_NETWORK = 0x40000;
		public const int STATE_IS_WINDOW = 0x80000;
		public const int STATE_RESTORING = 0x1000000;
		public const int STATE_IS_INSECURE = 0x4;
		public const int STATE_IS_BROKEN = 0x1;
		public const int STATE_IS_SECURE = 0x2;
		public const int STATE_SECURE_HIGH = 0x40000;
		public const int STATE_SECURE_MED = 0x10000;
		public const int STATE_SECURE_LOW = 0x20000;
	}

	static class nsIDOMNodeConstants
	{
		public const int ELEMENT_NODE = 1;
		public const int ATTRIBUTE_NODE = 2;
		public const int TEXT_NODE = 3;
		public const int CDATA_SECTION_NODE = 4;
		public const int ENTITY_REFERENCE_NODE = 5;
		public const int ENTITY_NODE = 6;
		public const int PROCESSING_INSTRUCTION_NODE = 7;
		public const int COMMENT_NODE = 8;
		public const int DOCUMENT_NODE = 9;
		public const int DOCUMENT_TYPE_NODE = 10;
		public const int DOCUMENT_FRAGMENT_NODE = 11;
		public const int NOTATION_NODE = 12;
	}

	static class nsIDataTypeConstants
	{
		public const int VTYPE_INT8 = 0; // TD_INT8					= 0,
		public const int VTYPE_INT16 = 1; // TD_INT16				= 1,
		public const int VTYPE_INT32 = 2; // TD_INT32				= 2,
		public const int VTYPE_INT64 = 3; // TD_INT64				= 3,
		public const int VTYPE_UINT8 = 4; // TD_UINT8				= 4,
		public const int VTYPE_UINT16 = 5; // TD_UINT16				= 5,
		public const int VTYPE_UINT32 = 6; // TD_UINT32				= 6,
		public const int VTYPE_UINT64 = 7; // TD_UINT64				= 7,
		public const int VTYPE_FLOAT = 8; // TD_FLOAT				= 8, 
		public const int VTYPE_DOUBLE = 9; // TD_DOUBLE				= 9,
		public const int VTYPE_BOOL = 10; // TD_BOOL				= 10,
		public const int VTYPE_CHAR = 11; // TD_CHAR				= 11,
		public const int VTYPE_WCHAR = 12; // TD_WCHAR				= 12,
		public const int VTYPE_VOID = 13; // TD_VOID				= 13,
		public const int VTYPE_ID = 14; // TD_PNSIID				= 14,
		public const int VTYPE_DOMSTRING = 15; // TD_DOMSTRING			= 15,
		public const int VTYPE_CHAR_STR = 16; // TD_PSTRING				= 16,
		public const int VTYPE_WCHAR_STR = 17; // TD_PWSTRING			= 17,
		public const int VTYPE_INTERFACE = 18; // TD_INTERFACE_TYPE		= 18,
		public const int VTYPE_INTERFACE_IS = 19; // TD_INTERFACE_IS_TYPE	= 19,
		public const int VTYPE_ARRAY = 20; // TD_ARRAY				= 20,
		public const int VTYPE_STRING_SIZE_IS = 21; // TD_PSTRING_SIZE_IS		= 21,
		public const int VTYPE_WSTRING_SIZE_IS = 22; // TD_PWSTRING_SIZE_IS	= 22,
		public const int VTYPE_UTF8STRING = 23; // TD_UTF8STRING			= 23,
		public const int VTYPE_CSTRING = 24; // TD_CSTRING				= 24,
		public const int VTYPE_ASTRING = 25; // TD_ASTRING				= 25,
		public const int VTYPE_EMPTY_ARRAY = 254;
		public const int VTYPE_EMPTY = 255;
	}	
	
	class PRUnicharMarshaler : ICustomMarshaler
	{
		public static ICustomMarshaler GetInstance(string cookie)
		{
			return (_Instance == null) ? (_Instance = new PRUnicharMarshaler()) : _Instance;
		}
		static PRUnicharMarshaler _Instance;
		
		public void CleanUpManagedData(object ManagedObj) { }
		public void CleanUpNativeData(IntPtr pNativeData) { }
		public int GetNativeDataSize() { return 0; }

		public IntPtr MarshalManagedToNative(object ManagedObj)
		{
			byte [] bytes = Encoding.Unicode.GetBytes(ManagedObj.ToString() + "\0");
			IntPtr alloc = Xpcom.Alloc(bytes.Length + 2);
			Marshal.Copy(bytes, 0, alloc, bytes.Length);
			return alloc;
		}

		public object MarshalNativeToManaged(IntPtr pNativeData)
		{
			return Marshal.PtrToStringUni(pNativeData);
		}
	}	

	static class nsIPromptServiceConstants
	{
		public const int BUTTON_POS_0 = 1;
		public const int BUTTON_POS_1 = 256;
		public const int BUTTON_POS_2 = 65536;

		public const int BUTTON_TITLE_OK = 1;
		public const int BUTTON_TITLE_CANCEL = 2;
		public const int BUTTON_TITLE_YES = 3;
		public const int BUTTON_TITLE_NO = 4;
		public const int BUTTON_TITLE_SAVE = 5;
		public const int BUTTON_TITLE_DONT_SAVE = 6;
		public const int BUTTON_TITLE_REVERT = 7;
		public const int BUTTON_TITLE_IS_STRING = 127;

		public const int BUTTON_POS_0_DEFAULT = 0;
		public const int BUTTON_POS_1_DEFAULT = 16777216;
		public const int BUTTON_POS_2_DEFAULT = 33554432;
		
		public const int BUTTON_DELAY_ENABLE = 67108864;
		public const int STD_OK_CANCEL_BUTTONS = 513;
		public const int STD_YES_NO_BUTTONS = 1027;
	}
	
	public delegate int nsWriteSegmentFun(nsIInputStream aInStream, IntPtr aClosure, IntPtr aFromSegment, int aToOffset, int aCount, out int aWriteCount);
			
	public struct nsMargin
	{
	}

    /// <see cref="https://developer.mozilla.org/en/XPCOM_Interface_Reference/nsIHttpActivityObserver"/>
    static class nsIHttpActivityObserverConstants
    {
        public const uint ACTIVITY_TYPE_SOCKET_TRANSPORT = 0x0001;
        public const uint ACTIVITY_TYPE_HTTP_TRANSACTION = 0x0002;
        public const uint ACTIVITY_SUBTYPE_REQUEST_HEADER = 0x5001;
        public const uint ACTIVITY_SUBTYPE_REQUEST_BODY_SENT = 0x5002;
        public const uint ACTIVITY_SUBTYPE_RESPONSE_START = 0x5003;
        public const uint ACTIVITY_SUBTYPE_RESPONSE_COMPLETE = 0x5005;
        public const uint ACTIVITY_SUBTYPE_TRANSACTION_CLOSE = 0x5006;
    }

    /// <see cref="https://developer.mozilla.org/en/XPCOM_Interface_Reference/nsISocketTransport"/>
    static class nsISocketTransportConstants
    {
        public const uint STATUS_RESOLVING      = 0x804b0003;
        public const uint STATUS_RESOLVED       = 0x804b000b;
        public const uint STATUS_CONNECTING_TO  = 0x804b0007;
        public const uint STATUS_CONNECTED_TO   = 0x804b0004;
        public const uint STATUS_SENDING_TO     = 0x804b0005;
        public const uint STATUS_WAITING_FOR    = 0x804b000a;
        public const uint STATUS_RECEIVING_FROM = 0x804b0006;
    }

    static class nsISeekableStreamConstants
    {
        public const int    NS_SEEK_SET = 0;
        public const int    NS_SEEK_CUR = 1;
        public const int    NS_SEEK_END = 2;
    }
}
