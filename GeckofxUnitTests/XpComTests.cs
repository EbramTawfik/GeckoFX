using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using NUnit.Framework;
using Gecko;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class XpComTests
	{
		public static string XulRunnerLocation 
		{
			get { return XULRunnerLocator.GetXULRunnerLocation(); }
		}

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XulRunnerLocation);
		}

		[Test]
		public void Alloc_XpcomInitialize_ReturnsValidPointer()
		{			
			IntPtr memory = Xpcom.Alloc(new IntPtr(100));
			Assert.IsFalse(memory == IntPtr.Zero);
			Xpcom.Free(memory);			
		}
		
		[Test]
		public void Realloc_XpcomInitialize_ReturnsValidPointer()
		{		
			IntPtr memory = Xpcom.Alloc(new IntPtr(100));			
			memory = Xpcom.Realloc(memory, new IntPtr(200));
			Assert.IsFalse(memory == IntPtr.Zero);
			Xpcom.Free(memory);
		}
#region CreateInstance Unittests
		[Test]
		public void CreateInstance_CreatingnsWebBrowser_ReturnsValidInstance()
		{
			var webBrowser = Xpcom.CreateInstance<nsIWebBrowser>("@mozilla.org/embedding/browser/nsWebBrowser;1");
			Assert.IsNotNull(webBrowser);
			Marshal.ReleaseComObject(webBrowser);
		}			

		[Test]
		[Platform(Exclude="Linux")]
		public void CreateInstance_CreatingWindowsTaskbar_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIWinTaskbar>("@mozilla.org/windows-taskbar;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingScriptSecurityManager_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIScriptSecurityManager>("@mozilla.org/scriptsecuritymanager;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingNullPrincipal_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIPrincipal>("@mozilla.org/nullprincipal;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingPrincipal_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIPrincipal>("@mozilla.org/principal;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSystemPrincipal_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIPrincipal>("@mozilla.org/systemprincipal;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingChromeRegistry_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIChromeRegistry>("@mozilla.org/chrome/chrome-registry;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingHtmlCopyEncoder_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/layout/htmlCopyEncoder;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}
		
		[Test]
		public void CreateInstance_CreatingEventListenerService_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIEventListenerService>("@mozilla.org/eventlistenerservice;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}		

		[Test]
		public void CreateInstance_CreatingContentPolicy_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIContentPolicy>("@mozilla.org/layout/content-policy;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingFormData_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIDOMFormData>("@mozilla.org/files/formdata;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingDomParser_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIDOMParser>("@mozilla.org/xmlextras/domparser;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingXmlSerializer_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIDOMSerializer>("@mozilla.org/xmlextras/xmlserializer;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingXmlHttpRequest_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIXMLHttpRequest>("@mozilla.org/xmlextras/xmlhttprequest;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingNSChannelPolicy_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIChannelPolicy>("@mozilla.org/nschannelpolicy;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingCspService_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIContentPolicy>("@mozilla.org/cspservice;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingDataDocumentContentPolicy_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIContentPolicy>("@mozilla.org/data-document-content-policy;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingNoDataProtocolContentPolicy_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIContentPolicy>("@mozilla.org/no-data-protocol-content-policy;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Ignore("Removed in firefox 18 : https://bugzilla.mozilla.org/show_bug.cgi?id=775368")]
		[Test]
		public void CreateInstance_CreatingWebSocket_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/websocket;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		[Ignore("I've seen this fail on 2 machines now (Win7 + Win8) - so ignoring")]
		public void CreateInstance_CreatingXmlHttpRequestBadCertHandler_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/content/xmlhttprequest-bad-cert-handler;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingXPathNameSpace_ThrowsClassNotRegistered()
		{
			Assert.Throws<COMException>(() => Xpcom.CreateInstance<nsISupports>("@mozilla.org/transformiix/xpath-namespace;1"));			
		}

		[Test]
		public void CreateInstance_CreatingXsltDocumentTransformer_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIXSLTProcessor>("@mozilla.org/document-transformer;1?type=xslt");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingMork_ThrowsClassNotRegistered()
		{
			Assert.Throws<COMException>(() => Xpcom.CreateInstance<nsISupports>("@mozilla.org/db/mork;1"));			
		}

		[Test]
		public void CreateInstance_CreatingUriFixup_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIURIFixup>("@mozilla.org/docshell/urifixup;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingEnumeratorForwards_ThrowsClassNotRegistered()
		{
			Assert.Throws<COMException>(() => Xpcom.CreateInstance<nsIEnumerator>("@mozilla.org/docshell/enumerator-forwards;1"));			
		}

		[Test]
		public void CreateInstance_CreatingEnumeratorBackwards_ThrowsClassNotRegistered()
		{
			Assert.Throws<COMException>(() => Xpcom.CreateInstance<nsIEnumerator>("@mozilla.org/docshell/enumerator-backwards;1"));
		}
		

		[Test]
		public void CreateInstance_CreatingWebNavigationInfo_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIWebNavigationInfo>("@mozilla.org/webnavigation-info;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingBrowserHistory_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/browser/history;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSHistory_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsISHistory>("@mozilla.org/browser/shistory;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSHistoryInternal_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsISHistory>("@mozilla.org/browser/shistory-internal;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSesionHistoryTransaction_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsISHTransaction>("@mozilla.org/browser/session-history-transaction;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingXPathEvaluator_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIDOMXPathEvaluator>("@mozilla.org/dom/xpath-evaluator;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingFocusManager_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIFocusManager>("@mozilla.org/focus-manager;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingWindowController_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIController>("@mozilla.org/dom/window-controller;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingEntropy_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIEntropyCollector>("@mozilla.org/security/entropy;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingContentPrefService_ThrowsFail()
		{
			var instance = Xpcom.CreateInstance<nsIContentPrefService>("@mozilla.org/content-pref/service;1");
			Assert.IsNotNull(instance);			
		}

		[Test]
		public void CreateInstance_CreatingHostnameGrouper_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/content-pref/hostname-grouper;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}				

		[Test]
		public void CreateInstance_CreatingTxtSrvFilter_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/editor/txtsrvfilter;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingTxtSrvFilterMail_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/editor/txtsrvfiltermail;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingTransactionManager_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsITransactionManager>("@mozilla.org/transactionmanager;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSpellcheckerInline_ReturnsValidInstance()
		{				
			var instance = Xpcom.CreateInstance<nsIInlineSpellChecker>("@mozilla.org/spellchecker-inline;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSpellChecker_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/spellchecker;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingPromptService_ReturnsValidInstance()
		{
			var promptService = Xpcom.CreateInstance<nsIPromptService>("@mozilla.org/embedcomp/prompt-service;1");
			Assert.IsNotNull(promptService);
	
			// GeckoWebBrowser registers a global PromptService
			if (Marshal.IsComObject(promptService))
				Marshal.ReleaseComObject(promptService);
		}

		[Test]
		public void CreateInstance_CreatingTooltipTextProvider_ThrowsClassNotRegistered()
		{
			Assert.Throws<COMException>(() => Xpcom.CreateInstance<nsITooltipTextProvider>("@mozilla.org/embedcomp/tooltiptextprovider;1"));
		}
		
		[Test]
		public void CreateInstance_CreatingNsCommandHandler_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsICommandHandler>("@mozilla.org/embedding/browser/nsCommandHandler;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);

		}

		[Test]
		public void CreateInstance_CreatingAppStartupNotifier_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/embedcomp/appstartup-notifier;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingCommandManager_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsICommandManager>("@mozilla.org/embedcomp/command-manager;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingCommandParams_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsICommandParams>("@mozilla.org/embedcomp/command-params;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingControllerCommandTable_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIControllerCommandTable>("@mozilla.org/embedcomp/controller-command-table;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingBaseCommandController_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsICommandController>("@mozilla.org/embedcomp/base-command-controller;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingControllerCommandGroup_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIControllerCommandGroup>("@mozilla.org/embedcomp/controller-command-group;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingRangeFind_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIFind>("@mozilla.org/embedcomp/rangefind;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingFind_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIWebBrowserFind>("@mozilla.org/embedcomp/find;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingPrintingPromptService_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIPrintingPromptService>("@mozilla.org/embedcomp/printingprompt-service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingWebBrowserPersist_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIWebBrowserPersist>("@mozilla.org/embedding/browser/nsWebBrowserPersist;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingDialogParam_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIDialogParamBlock>("@mozilla.org/embedcomp/dialogparam;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingWindowWatcher_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIWindowWatcher>("@mozilla.org/embedcomp/window-watcher;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingCookiePrompt_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsICookiePromptService>("@mozilla.org/embedcomp/cookieprompt-service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingContentBlocker_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/permissions/contentblocker;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingAutoConfiguration_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIAutoConfig>("@mozilla.org/autoconfiguration;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingReadConfig_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIReadConfig>("@mozilla.org/readconfig;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}


		[Test]
		public void CreateInstance_CreatingSpellcheckerEngine_ReturnsValidInstance()
		{					
			var instance = Xpcom.CreateInstance<mozISpellCheckingEngine>("@mozilla.org/spellchecker/engine;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingPersonalDictionary_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<mozIPersonalDictionary>("@mozilla.org/spellchecker/personaldictionary;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingIl8nManager_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<mozISpellI18NManager>("@mozilla.org/spellchecker/i18nmanager;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingLocaleService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsILocaleService>("@mozilla.org/intl/nslocaleservice;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingScriptableDateFormat_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIScriptableDateFormat>("@mozilla.org/intl/scriptabledateformat;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingCollation_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsICollation>("@mozilla.org/intl/collation;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingCollationFactory_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsICollationFactory>("@mozilla.org/intl/collation-factory;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingDateTimeFormat_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/intl/datetimeformat;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingLanguageAtomService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/intl/nslanguageatomservice;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);		
		}

		[Test]
		public void CreateInstance_CreatingSemanticUnitsScanner_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISemanticUnitScanner>("@mozilla.org/intl/semanticunitscanner;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingLbek_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/intl/lbrk;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingWbrk_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/intl/wbrk;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingStringBundle_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIStringBundleService>("@mozilla.org/intl/stringbundle;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingScriptableUnicodeConverter_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIScriptableUnicodeConverter>("@mozilla.org/intl/scriptableunicodeconverter");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingTextToSubUri_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsITextToSubURI>("@mozilla.org/intl/texttosuburi;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingPlatformCharset_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/intl/platformcharset;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingUtf8ConverterService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/intl/utf8converterservice;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingConverterInputStream_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIConverterInputStream>("@mozilla.org/intl/converter-input-stream;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingUnideDecoderWindows1252_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/intl/unicode/decoder;1?charset=windows-1252");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingUnicodeDecoderISO8859_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/intl/unicode/decoder;1?charset=ISO-8859-1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingEntityConverter_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIEntityConverter>("@mozilla.org/intl/entityconverter;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSaveAsCharset_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISaveAsCharset>("@mozilla.org/intl/saveascharset;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingUnicodeNormalizer_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIUnicodeNormalizer>("@mozilla.org/intl/unicodenormalizer;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingUniCharUtil_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/intl/unicharutil;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSciptError_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIScriptError>("@mozilla.org/scripterror;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}
		
		[Ignore("Creating multiple jsloaders causes multiple copies of mozJSComponentLoader (Singleton) to be inialized, This causes Xpcom.Shutdown to segfault")]		
		[Test]
		public void CreateInstance_CreatingJsLoader_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/moz/jsloader;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingStyleSheetService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIStyleSheetService>("@mozilla.org/content/style-sheet-service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingDocumentLoaderFactory_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIDocumentLoaderFactory>("@mozilla.org/content/document-loader-factory;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingTransformiixNodeSet_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<txINodeSet>("@mozilla.org/transformiix-nodeset;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingZipWriter_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIZipWriter>("@mozilla.org/zipwriter;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingPrefLocalizedString_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIPrefLocalizedString>("@mozilla.org/pref-localizedstring;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingPreferencesService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIPrefBranch>("@mozilla.org/preferences-service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingPrefRelativeFile_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIRelativeFilePref>("@mozilla.org/pref-relativefile;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingPluginHost_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIPluginHost>("@mozilla.org/plugin/host;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingThirdPartyUtil_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<mozIThirdPartyUtil>("@mozilla.org/thirdpartyutil;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingPermissionManager_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIPermissionManager>("@mozilla.org/permissionmanager;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSecureBrowser_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISecureBrowserUI>("@mozilla.org/secure_browser_ui;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingMimeInpurtStream_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIMIMEInputStream>("@mozilla.org/network/mime-input-stream;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingCookiePermission_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsICookiePermission>("@mozilla.org/cookie/permission;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingTxtToHtmlConv_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<mozITXTToHTMLConv>("@mozilla.org/txttohtmlconv;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingDirIndexParser_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIDirIndexParser>("@mozilla.org/dirIndexParser;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingParserService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/parser/parser-service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSaxParserAttributes_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISAXAttributes>("@mozilla.org/saxparser/attributes;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSaxParserXmlReader_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISAXXMLReader>("@mozilla.org/saxparser/xmlreader;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSecurityWarningDialogs_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISecurityWarningDialogs>("@mozilla.org/nsSecurityWarningDialogs;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingASN1Tree_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIASN1Tree>("@mozilla.org/security/nsASN1Tree;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingPkiParamBlocl_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIPKIParamBlock>("@mozilla.org/security/pkiparamblock;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingCertificateDialogs_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsICertificateDialogs>("@mozilla.org/nsCertificateDialogs;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingCertPickDialog_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsICertPickDialogs>("@mozilla.org/nsCertPickDialogs;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingAlertsService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIAlertsService>("@mozilla.org/alerts-service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSystemInfo_ReturnsValidInstance()
		{	
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/system-info;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingFindService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIFindService>("@mozilla.org/find/find_service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingLoginInfo_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsILoginInfo>("@mozilla.org/login-manager/loginInfo;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingLoginManager_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsILoginManager>("@mozilla.org/login-manager;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingJSPerf_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/jsperf;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingUserInfo_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIUserInfo>("@mozilla.org/userinfo;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingAppShellComponentBrowserStatusFilter_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/appshell/component/browser-status-filter;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}		

		[Test]
		public void CreateInstance_CreatingCrashReporter_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsICrashReporter>("@mozilla.org/toolkit/crash-reporter;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingUriLoader_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIURILoader>("@mozilla.org/uriloader;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingExternalHelperAppService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIExternalHelperAppService>("@mozilla.org/uriloader/external-helper-app-service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingHelperAppLauncherDialog_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIHelperAppLauncherDialog>("@mozilla.org/helperapplauncherdialog;1");
			Assert.IsNotNull(instance);
			// GeckoWebBrowser registers LauncherDialogFactory.
			if (Marshal.IsComObject(instance))
				Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingPrefetchService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIPrefetchService>("@mozilla.org/prefetch-service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingDebug_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIDebug>("@mozilla.org/xpcom/debug;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingConsoleService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIConsoleService>("@mozilla.org/consoleservice;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingErrorService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIErrorService>("@mozilla.org/xpcom/error-service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingUuidGenerator_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIUUIDGenerator>("@mozilla.org/uuid-generator;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingVersionComparator_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIVersionComparator>("@mozilla.org/xpcom/version-comparator;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingDirectoryService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIDirectoryService>("@mozilla.org/file/directory_service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingFileLocal_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsILocalFile>("@mozilla.org/file/local;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingCategoryManager_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsICategoryManager>("@mozilla.org/categorymanager;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingProperties_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIProperties>("@mozilla.org/properties;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingArray_ReturnsValidInstance()
		{			 
			var instance = Xpcom.CreateInstance<nsIArray>("@mozilla.org/array;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingObserverService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIObserverService>("@mozilla.org/observer-service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingIoUtil_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIIOUtil>("@mozilla.org/io-util;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingCycleCollector_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsICycleCollectorListener>("@mozilla.org/cycle-collector-logger;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSupportsId_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupportsID>("@mozilla.org/supports-id;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSupportsCString_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupportsCString>("@mozilla.org/supports-cstring;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSupportsString_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupportsString>("@mozilla.org/supports-string;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingAtomService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIAtomService>("@mozilla.org/atom-service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}		

		[Test]
		public void CreateInstance_CreatingIniParserFactory_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIINIParserFactory>("@mozilla.org/xpcom/ini-parser-factory;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingPersistentProperties_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIPersistentProperties>("@mozilla.org/persistent-properties;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSupportsArray_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupportsArray>("@mozilla.org/supports-array;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingVariant_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIVariant>("@mozilla.org/variant;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		[Platform(Exclude="Linux")]
		public void CreateInstance_CreatingWindowsRegistryKey_ReturnsValidInstance()
		{			 
			var instance = Xpcom.CreateInstance<nsIWindowsRegKey>("@mozilla.org/windows-registry-key;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingMemoryService_ReturnsValidInstance()
		{			 
			var instance = Xpcom.CreateInstance<nsIMemory>("@mozilla.org/xpcom/memory-service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingBinaryOutputStream_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIBinaryOutputStream>("@mozilla.org/binaryoutputstream;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingBinaryInputStream_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIBinaryInputStream>("@mozilla.org/binaryinputstream;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}
	
		[Test]
		public void CreateInstance_CreatingMultiplexInputStream_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIMultiplexInputStream>("@mozilla.org/io/multiplex-input-stream;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingPipe_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIPipe>("@mozilla.org/pipe;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingScriptableInputStream_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIScriptableInputStream>("@mozilla.org/scriptableinputstream;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingStorageStream_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIStorageStream>("@mozilla.org/storagestream;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingGeolocationProvider_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIGeolocationProvider>("@mozilla.org/geolocation/provider;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingEnvironment_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIEnvironment>("@mozilla.org/process/environment;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingProcessUtil_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIProcess>("@mozilla.org/process/util;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingTimer_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsITimer>("@mozilla.org/timer;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingAppShellService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIAppShellService>("@mozilla.org/appshell/appShellService;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingPopupWindowManager_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIPopupWindowManager>("@mozilla.org/PopupWindowManager;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingWindowMediator_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIWindowMediator>("@mozilla.org/appshell/window-mediator;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingHttpIndexService_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIHTTPIndex>("@mozilla.org/browser/httpindex-service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingTransferable_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsITransferable>("@mozilla.org/widget/transferable;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}
#endregion

#region GetService Unittests
		[Test]
		public void GetIoService_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsIIOService>("@mozilla.org/network/io-service;1");
			Assert.IsNotNull(instance);
		}

		[Test]
		public void GetJsRuntimeService_CleanXpComInstance_ReturnsValidInstance()
		{		
			nsIJSRuntimeService instance = Xpcom.GetService<nsIJSRuntimeService>("@mozilla.org/js/xpc/RuntimeService;1");
			Assert.IsNotNull(instance);
		}

		[Test]
		public void GetScriptSecurityManager_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsIScriptSecurityManager>("@mozilla.org/scriptsecuritymanager;1");
			Assert.IsNotNull(instance);
		}

		[Test]
		public void GetPreferencesService_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsIPrefService>("@mozilla.org/preferences-service;1");
			Assert.IsNotNull(instance);
		}

		[Test]
		public void GetWindowWatcher_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsIWindowWatcher>("@mozilla.org/embedcomp/window-watcher;1");
			Assert.IsNotNull(instance);
		}

		[Test]
		public void GetAppShellService_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsIAppShellService>("@mozilla.org/appshell/appShellService;1");
			Assert.IsNotNull(instance);
		}

		[Test]
		public void GetAppShell_CleanXpComInstance_ReturnsValidInstance()
		{
			System.IntPtr ptr = (IntPtr)Xpcom.GetService(new Guid("2d96b3df-c051-11d1-a827-0040959a28c9"));
			var instance = (nsIAppShell)Xpcom.GetObjectForIUnknown(ptr);
			Assert.IsNotNull(instance);						
		}

		[Test]
		public void GetAppInfo_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsIXULRuntime>("@mozilla.org/xre/app-info;1");
			Assert.IsNotNull(instance);			
		}

		[Test]
		public void GetXULRuntime_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsIXULRuntime>("@mozilla.org/xre/runtime;1");
			Assert.IsNotNull(instance);
		}

		[Test]
		public void GetConsoleService_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsIConsoleService>("@mozilla.org/consoleservice;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void GetDownloadManager_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsIDownloadManager>("@mozilla.org/download-manager;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void GetDownloadManagerUI_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsIDownloadManagerUI>("@mozilla.org/download-manager-ui;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}


		[Test]
		public void GetHandlerService_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsIHandlerService>("@mozilla.org/uriloader/handler-service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);			
		}

		[Test]
		public void GetProtocolProxyService_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsIProtocolProxyService2>("@mozilla.org/network/protocol-proxy-service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void GetControllers_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsIControllers>("@mozilla.org/xul/xul-controllers;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void GetXPConnect_CleanXpComInstance_ReturnsValidInstance()
		{			
			var instance = Xpcom.GetService<nsIXPConnect>("@mozilla.org/js/xpc/XPConnect;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void GetJsSubscriptLoader_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<mozIJSSubScriptLoader>("@mozilla.org/moz/jssubscript-loader;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void GetJsLoader_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<xpcIJSModuleLoader>("@mozilla.org/moz/jsloader;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void GetThreadManager_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsIThreadManager>("@mozilla.org/thread-manager;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void GetThreadPool_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsIThreadPool>("@mozilla.org/thread-pool;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);			
		}

		[Test]
		public void GetMessageLoop_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsISupports>("@mozilla.org/message-loop;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);	
		}

		[Test]
		public void GetInterfaceInfoManager_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService<nsIInterfaceInfoManager>("@mozilla.org/xpti/interfaceinfomanager-service;1");
			Assert.IsNotNull(instance);			
			Marshal.ReleaseComObject(instance);				
		}

		[Test]
		public void GetnsICertOverrideService_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService2<nsICertOverrideService>(Contracts.CertOverride);
			Assert.IsNotNull(instance);
			instance.Dispose();
		}

		[Test]
		public void GetnsIX509CertDB_CleanXpComInstance_ReturnsValidInstance()
		{
			var instance = Xpcom.GetService2<nsIX509CertDB>(Contracts.X509CertDb);
			Assert.IsNotNull(instance);
			instance.Dispose();
		}
#endregion
	}
}
