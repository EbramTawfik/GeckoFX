using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko
{
	public static class Contracts
	{
		#region contracts for elements that HAVE wrappers
		#region Network
		internal static readonly string DnsService = "@mozilla.org/network/dns-service;1";
		internal static readonly string StreamListenerTee = "@mozilla.org/network/stream-listener-tee;1";
		#endregion
		internal static readonly string ZipReader = "@mozilla.org/libjar/zip-reader;1";
		internal static readonly string Sound = "@mozilla.org/sound;1";
		internal static readonly string Variant = "@mozilla.org/variant;1";
		internal static readonly string CategoryManager = "@mozilla.org/categorymanager;1";
		internal static readonly string BrowserSearchService = "@mozilla.org/browser/search-service;1";
		internal static readonly string ScriptableInputStream = "@mozilla.org/scriptableinputstream;1";
		internal static readonly string Pipe = "@mozilla.org/pipe;1";
		internal static readonly string ObserverService = "@mozilla.org/observer-service;1";
		internal static readonly string PluginHost = "@mozilla.org/plugin/host;1";
		internal static readonly string VersionComparator = "@mozilla.org/xpcom/version-comparator;1";
		internal static readonly string StorageStream = "@mozilla.org/storagestream;1";
		internal static readonly string ConsoleService = "@mozilla.org/consoleservice;1";
		#region nsISupportsPrimitive's
		internal static readonly string SupportsID = "@mozilla.org/supports-id;1";
		internal static readonly string SupportsString = "@mozilla.org/supports-string;1";
		internal static readonly string SupportsBool = "@mozilla.org/supports-PRBool;1";
		internal static readonly string SupportsByte = "@mozilla.org/supports-PRUint8;1";
		internal static readonly string SupportsUInt16 = "@mozilla.org/supports-PRUint16;1";
		internal static readonly string SupportsUInt32 = "@mozilla.org/supports-PRUint32;1";
		internal static readonly string SupportsUInt64 = "@mozilla.org/supports-PRUint64;1";
		internal static readonly string SupportsTime = "@mozilla.org/supports-PRTime;1";
		internal static readonly string SupportsChar= "@mozilla.org/supports-char;1";
		internal static readonly string SupportsInt16= "@mozilla.org/supports-PRInt16;1";
		internal static readonly string SupportsInt32= "@mozilla.org/supports-PRInt32;1";
		internal static readonly string SupportsInt64= "@mozilla.org/supports-PRInt64;1";
		internal static readonly string SupportsFloat= "@mozilla.org/supports-float;1";
		internal static readonly string SupportsDouble= "@mozilla.org/supports-double;1";
		internal static readonly string SupportsVoid= "@mozilla.org/supports-void;1";
		internal static readonly string SupportsInterfacePointer= "@mozilla.org/supports-interface-pointer;1";
		#endregion
		#endregion
		#region  contracts for elements that NOT HAVE wrappers
		
		#endregion

		#region External components (XULRunner components)
		internal static readonly string PrivateBrowsing = "@mozilla.org/privatebrowsing;1";
		#endregion
	}
}
