using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using NUnit.Framework;
using Skybound.Gecko;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class XpComTests
	{
		const string XulRunnerLocation = @"C:\Program Files (x86)\Mozilla Firefox";

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XulRunnerLocation);
		}

		[Test]
		public void Alloc_XpcomInitialize_ReturnsValidPointer()
		{			
			IntPtr memory = Xpcom.Alloc(100);
			Assert.IsFalse(memory == IntPtr.Zero);
			Xpcom.Free(memory);			
		}
		
		[Test]
		public void Realloc_XpcomInitialize_ReturnsValidPointer()
		{		
			IntPtr memory = Xpcom.Alloc(100);			
			Xpcom.Realloc(memory, 200);
			Assert.IsFalse(memory == IntPtr.Zero);
			Xpcom.Free(memory);
		}

		[Test]
		public void CreateInstance_CreatingnsWebBrowser_ReturnsValidInstance()
		{
			var webBrowser = Xpcom.CreateInstance<nsIWebBrowser>("@mozilla.org/embedding/browser/nsWebBrowser;1");
			Assert.IsNotNull(webBrowser);
			Marshal.ReleaseComObject(webBrowser);
		}

		[Test]
		public void CreateInstance_CreatingShellService_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIShellService>("@mozilla.org/browser/shell-service;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingDirectoryProvider_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIDirectoryServiceProvider>("@mozilla.org/browser/directory-provider;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
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
		public void CreateInstance_CreatingPSM_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsISignatureVerifier>("@mozilla.org/psm;1");
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
		public void CreateInstance_CreatingSyncloadDomService_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsISyncLoadDOMService>("@mozilla.org/content/syncload-dom-service;1");
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
		public void CreateInstance_CreatingGlobalMessageManager_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIFrameMessageManager>("@mozilla.org/globalmessagemanager;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingParentProcessMessageManager_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIFrameMessageManager>("@mozilla.org/parentprocessmessagemanager;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingChildProcessMessageManager_ThrowsClassNotFound()
		{			
			Assert.Throws<COMException>( () => Xpcom.CreateInstance<nsIFrameMessageManager>("@mozilla.org/childprocessmessagemanager;1"));			
		}

		[Test]
		public void CreateInstance_CreatingContentPolicy_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIContentPolicy>("@mozilla.org/layout/content-policy;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingFileReader_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIDOMFileReader>("@mozilla.org/files/filereader;1");
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
		public void CreateInstance_CreatingPlainTextSink_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/layout/plaintextsink;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingNameSpaceManager_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/content/namespacemanager;1");
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

		[Test]
		public void CreateInstance_CreatingWebSocket_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIWebSocket>("@mozilla.org/websocket;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
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
		public void CreateInstance_CreatingXtfXmlContentBuilder_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIXMLContentBuilder>("@mozilla.org/xtf/xml-contentbuilder;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingXtfElementFactory_ThrowsClassNotRegistered()
		{
			Assert.Throws<COMException>(() => Xpcom.CreateInstance<nsIXTFElementFactory>("@mozilla.org/xtf/element-factory;1"));
		}


		[Test]
		public void CreateInstance_CreatingXtfService_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/xtf/xtf-service;1");
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
		public void CreateInstance_CreatingHistoryEntry_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIHistoryEntry>("@mozilla.org/browser/history-entry;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSessionHistroyEntry_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIHistoryEntry>("@mozilla.org/browser/session-history-entry;1");
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
		public void CreateInstance_CreatingIndexedDbManager_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/dom/indexeddb/manager;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingContenetPermissionPrompt_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIContentPermissionPrompt>("@mozilla.org/content-permission/prompt;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingContentPrefService_ThrowsFail()
		{
			Assert.Throws<COMException>(() => Xpcom.CreateInstance<nsIContentPrefService>("@mozilla.org/content-pref/service;1"));			
		}

		[Test]
		public void CreateInstance_CreatingHostnameGrouper_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsISupports>("@mozilla.org/content-pref/hostname-grouper;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingSidebar_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsISidebar>("@mozilla.org/sidebar;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingWebContentHandlerRegistrar_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIWebContentHandlerRegistrar>("@mozilla.org/embeddor.implemented/web-content-handler-registrar;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}

		[Test]
		public void CreateInstance_CreatingWorkerFactory_ReturnsValidInstance()
		{
			var instance = Xpcom.CreateInstance<nsIWorkerFactory>("@mozilla.org/threads/workerfactory;1");
			Assert.IsNotNull(instance);
			Marshal.ReleaseComObject(instance);
		}
		
		[Test]
		public void CreateInstance_CreatingAccelerometer_ReturnsValidInstance()
		{			
			var instance = Xpcom.CreateInstance<nsIAccelerometer>("@mozilla.org/accelerometer;1");
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
	}
}
