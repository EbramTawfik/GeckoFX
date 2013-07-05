using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko
{
	public static class Contracts
	{
		public static readonly string WebBrowser = "@mozilla.org/embedding/browser/nsWebBrowser;1";

		#region contracts for elements that HAVE wrappers
		#region Network
		public static readonly string MimeInputStream = "@mozilla.org/network/mime-input-stream;1";
		internal static readonly string DnsService = "@mozilla.org/network/dns-service;1";
		internal static readonly string StreamListenerTee = "@mozilla.org/network/stream-listener-tee;1";
		public static readonly string CacheService = "@mozilla.org/network/cache-service;1";
		public static readonly string NetworkIOService = "@mozilla.org/network/io-service;1";
		internal static readonly string HttpActivityDistributor = "@mozilla.org/network/http-activity-distributor;1";
		#endregion
		#region Security
		public static readonly string X509CertDb = "@mozilla.org/security/x509certdb;1";
		public static readonly string RandomGenerator = "@mozilla.org/security/random-generator;1";
		public static readonly string KeyObjectFactory = "@mozilla.org/security/keyobjectfactory;1";
		public static readonly string Hash = "@mozilla.org/security/hash;1";
		#endregion
		#region AppShell
		public static readonly string AppShellService = "@mozilla.org/appshell/appShellService;1";
		public static readonly string WindowMediator = "@mozilla.org/appshell/window-mediator;1";
		#endregion
		#region Image
		public static readonly string ImageCache = "@mozilla.org/image/cache;1";
		public static readonly string ImageContainer = "@mozilla.org/image/container;1";
		#endregion
		#region IO
		public static readonly string StringInputStream = "@mozilla.org/io/string-input-stream;1";
		#endregion

		public static readonly string Array = "@mozilla.org/array;1";
		public static readonly string WindowWatcher = "@mozilla.org/embedcomp/window-watcher;1";
		public static readonly string WritableVariant = "@mozilla.org/variant;1";
		public static readonly string ZipReader = "@mozilla.org/libjar/zip-reader;1";
		public static readonly string Sound = "@mozilla.org/sound;1";
		public static readonly string Variant = "@mozilla.org/variant;1";
		public static readonly string CategoryManager = "@mozilla.org/categorymanager;1";
		public static readonly string CookieManager = "@mozilla.org/cookiemanager;1";
		public static readonly string BrowserSearchService = "@mozilla.org/browser/search-service;1";
		public static readonly string ScriptableInputStream = "@mozilla.org/scriptableinputstream;1";
		public static readonly string Pipe = "@mozilla.org/pipe;1";
		public static readonly string ObserverService = "@mozilla.org/observer-service;1";
		public static readonly string PluginHost = "@mozilla.org/plugin/host;1";
		public static readonly string VersionComparator = "@mozilla.org/xpcom/version-comparator;1";
		public static readonly string StorageStream = "@mozilla.org/storagestream;1";
		public static readonly string ConsoleService = "@mozilla.org/consoleservice;1";
		public static readonly string ScreenManager = "@mozilla.org/gfx/screenmanager;1";
		public static readonly string XulRuntime = "@mozilla.org/xre/app-info;1";
		public static readonly string WiFiMonitor = "@mozilla.org/wifi/monitor;1";
		public static readonly string ExceptionService = "@mozilla.org/exceptionservice;1";
		public static readonly string WindowsTaskbar = "@mozilla.org/windows-taskbar;1";
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

		public static readonly string NavHistoryService = "@mozilla.org/browser/nav-history-service;1";
		public static readonly string XPathEvaluator = "@mozilla.org/dom/xpath-evaluator;1";

		#endregion

		#region External components (XULRunner components)
		internal static readonly string PrivateBrowsing = "@mozilla.org/privatebrowsing;1";
		#endregion
	}
}
