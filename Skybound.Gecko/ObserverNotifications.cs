namespace Gecko
{
	/// <summary>
	/// Observer notification strings
	/// Some of them will be unavaliable in GeckoFX (they may be avaliable only in XUL App or Firefox/Seamonkey)
	/// https://developer.mozilla.org/en/Observer_Notifications
	/// </summary>
	public static class ObserverNotifications
	{
		public static class ApplicationStartup
		{
			public const string XpComStartup = "xpcom-startup";
			public const string AppStartup = "app-startup";
			public const string ProfileDoChange = "profile-do-change";
			public const string ProfileAfterChange = "profile-after-change";
			public const string FinalUiStartup = "final-ui-startup";
			public const string SessionstoreWindowsRestored = "sessionstore-windows-restored";
		}

		public static class ApplicationShutdown
		{
			public const string QuitApplicationRequested = "quit-application-requested";
			public const string QuitApplicationGranted = "quit-application-granted";
			public const string QuitApplication = "quit-application";
			public const string ProfileChangeNetTeardown = "profile-change-net-teardown";
			public const string ProfileChangeTeardown = "profile-change-teardown";
			public const string ProfileBeforeChange = "profile-before-change";
			public const string XpComWillShutdown = "xpcom-will-shutdown";
			public const string XpComShutdown = "xpcom-shutdown";
		}

		public static class Browser
		{
			public const string BrowserPurgeSessionHistory = "browser:purge-session-history";
			public const string BrowserLastWindowCloseRequested = "browser-lastwindow-close-requested";
			public const string BrowserLastWindowCloseGranted = "browser-lastwindow-close-granted";
		}

		public static class Documents
		{
			
		}

		public static class Windows
		{
			
		}

		public static class SpellingChecker
		{
			
		}

		public static class IONotifications
		{
			
		}

		public static class HttpRequests
		{
			public const string HttpOnModifyRequest="http-on-modify-request";
			public const string HttpOnExamineResponse = "http-on-examine-response";
			public const string HttpOnExamineCachedResponse = "http-on-examine-cached-response";
			public const string HttpOnExamineMergedResponse = "http-on-examine-merged-response";
		}
		
		public static class Cookies
		{
			
		}

		public static class DownloadManager
		{
			
		}

		public static class Telemetry
		{
			/// <summary>
			/// Gecko 10
			/// </summary>
			public const string GatherTelemetry="gather-telemetry";
		}
	}
}