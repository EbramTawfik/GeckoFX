Geckofx is licensed under the Mozilla Public License Version.

== Changelog ==

== v45.0-0.33 ==

1. Fix a rare InvalidComObjectException in OnHandleCreated

== v45.0-0.32 ==

1. 64bit only fix. fix for issue #191 - Thanks h.b.

== v45.0-0.31 ==

1. Upgrade to HarfBuzz 1.4.1

== v45.0-0.29 ==

1. update firefox files dep nuget package to version 0.10

== v45.0-0.28 ==

1. Add Xpcom.EnableProfileMonitoring property.
(defaults to true so fix for #113 is still enabled by default.)
If Handled exception are a problem for you when calling Xpcom.Initialize
add Xpcom.EnableProfileMonitoring = true; before the Xpcom.Initialize call.

== v45.0-0.27 ==

Rebuild

== v45.0-0.26 ==

Rebuild for nuget packaging problems.
1. update firefox files dep nuget package to version 0.9 - need to remove dep on VS 2015 runttime libs.

== v45.0-0.25 ==

Rebuild for nuget packaging problems.
1. update firefox files dep nuget package to version 0.8

== v45.0-0.24 ==

1. Fix issue #113.
2. Fix issue #146
3. Fix cross-platform issues when setting PATH environment variable
4. update firefox files dep nuget package to version 0.7
5. Upgrade to .net framework 4.5 from 4.0

== v45.0-0.23 ==

1. Added support for 64bit windows geckofx.

== v45.0-0.22 ==

1. Location changes to nuget content folders.
2. Mark load LoadHtml(string) as obsolete

== v45.0-0.21 ==

1. Fix #91 - https://bitbucket.org/geckofx/geckofx-45.0/issues/91/browser-dom-mouse-events-not-working
2. Fix #110 - https://bitbucket.org/geckofx/geckofx-33.0/issues/110/remembervalidityoverride-is-not-respecting
3. Linux memory leak fix.

== v45.0-0.20 ==

1. Update included firefox files to verison 0.6
  - Fixes https://bugzilla.mozilla.org/show_bug.cgi?id=1279069

== v45.0-0.19 ==

1. Update included firefox files to verison 0.5
  - Fixes firefox bugs - 1263288 + 1260825
  - Also fix use of window.opener in javascript.

== v45.0-0.18 ==

1. Fix a rare crash at shutdown.

== v45.0-0.17 ==

1. Fix a 64bit bug when creating a JsVal from a C# IntPtr.

== v45.0-0.16 ==

1. Disable FF use of Realtime signals on Linux. 
Prevents lots of log files being created when debugging with mono soft debugger.

== v45.0-0.15 ==

1. Fix https://bitbucket.org/geckofx/geckofx-45.0/issues/64/promptservice-not-working-on-linux

== v45.0-0.14 ==

1. Implement 64bit verison of JsVal::FromPtr

== v45.0-0.13 ==

1. Stop CompileOptions calls from segfaulting on 32bit Linux.

== v45.0-0.12 ==

1. Hookup Spidermonkey Linux 32 interops.

== v45.0-0.11 ==

1. Add nsICacheStorageService interfaces. - Fixes issue #55
2. Fix a bug in JS_SetErrorReporter on 64bit Linux.

== v45.0-0.10 ==

1. Add ContentWindow property to HtmlFrameElement
2. Allow window.opener to return non null in running javascript.

== v45.0-0.9 ==

1. Update to Firefox 45 release (a39cbdebde6c)
2. Geckofx now renders/paints web pages while loading.

== v45.0-0.8 ==

1. Update to latest Beta Firefox 45. (45_0b9)
2. Upgrading to .net framework 4.0 from 3.5
3. Fix a ref count bug in Xpcom.CreateInstance<TInterfaceType> (memory)
4. Ignore any errors in the GeckoWebBrowser::OnSizeChanged method.
5. Returned JSVal From ExecuteJQuery
6. Suppress a rare ObjectIsDisposed exception running Dispose via finalizer.
7. Improve script error exceptions from EvaluateScript. (Include stacktrace)
8. Add GeckoWebBrowser FrameEventsPropergateToMainWindow property. (default false - set to true to get geckofx 33 type behavior.)

== v45.0-0.7 ==

1. Update to latest Beta Firefox 45.
2. Fix a memory leak. for issue #17
3. Added MemoryService class. (Thanks sbetzin)
4. Removed the Push/Pop/Peek CompartmentScope Methods. (Thanks sbetzin)
5. Improve EvaluateXPath for issue #25
6. Added GeckoIFrameElement::ContentWindow property.

== v45.0-0.6 ==

This build is an Beta version.

1. Message event listeners for custom event not longer get lost after page navigation. (Thanks SBetzin)
2. Fix issue https://bitbucket.org/geckofx/geckofx-45.0/issues/10
3. Update to latest Beta Firefox 45.

== v45.0-0.5 ==

This build is an Alpha version.

1. Another attempt at fixing events.
2. Include Plugin exe's in nuget package.

== v45.0-0.4 ==

This build is an Alpha version.

1. More fixes to event handling so that event handlers still work after document reloaded.
2. Fix bug were only first argument was passed to webidl methods. (Fixes Window.ScrollBy ignore 'y' argument)

== v45.0-0.3 ==

This build is an Alpha version.

1. Fix event handling.
2. Work with newer versions of the firefox 45 Alpha.

== v45.0-0.2 ==

This build is an Alpha version.

1. Add ScrollMinX, ScrollMinY, ScrollMaxX, ScrollMaxY, MozPaintCount, Content properties and Find Method to GeckoWindow.
2. Fix bug which prevented ComputedStyle (and similar typed properties) from working.

== v45.0-0.1 ==

This build is an Alpha version.

1. Initial version supporting firefox v45.0
This version has some fairly major changes.

Rather than publising via a .zip file this version is going to be published via a nuget package.
This is because, geckofx 45.0 requires a slightly modified firefox build.
The nuget package will include both geckofx files and the required firefox binary files.

This version is also makes use of a webidl compiler to allow access to apis provided by webidl files.
This is needed because an increasing number of firefox apis have moved from IDL to webidl.
The compiler can be found here: https://bitbucket.org/geckofx/webidltogeckofxbindings

The nuget package can be found here:
https://www.nuget.org/packages/Geckofx45/


== v33.0-0.8 ==

1. Using only one context menu for the life of the GeckoBrowser.
2. Some memory leak fixes (Mostly for Linux)
3. Add option to Disable WindowMeditator (saves a small amount of mem on each GeckoWebBrowser Creation)
usage: WindowMediator.Disable = true;

== v33.0-0.7 ==

1. `JS_SetErrorReporter()` moved into `using (new JSAutoCompartment())` block. Fixes issue #47
2. Add null check to JsVal
3. LINUX: Fix Linux message "Gdk-WARNING **: GdkWindow ?????? unexpectedly destroyed"
4. LINUX: Remove a Linux TODO: (Reparenting back before destroying window)
5. Make GeckoWebBrowser.Stop method more robust.

== v33.0-0.6 ==

1. Fix: Issue 20 https://bitbucket.org/geckofx/geckofx-33.0/issue/20/unit-tests
2. Fix: Issue 39 https://bitbucket.org/geckofx/geckofx-33.0/issue/39/geckonode-selectfirst-not-working-in-33
3. Update NSS-errors API (issue 5)
4. Fix a reentrant bug with LoadHtml(string content, string url) / LoadContent seen on Linux.
5. Add html5 input event support.

== v33.0-0.5 ==

1. Linux only tag.

== v33.0-0.4 ==

1. Linux only tag.

== v33.0-0.3 ==

1. Linux only tag.

== v33.0-0.2 ==

1. Fix compiling using mono.
2. Implement nsISHistoryListener.OnHistoryReplaceEntry rather than throwing NotImplementedException.

== v33.0-0.1 ==

1. Initial version supporting firefox/xulrunner v33.0

== v31.0-0.1 ==

1. Initial version supporting firefox/xulrunner v31.0
2. Support for executing javascript in a window, via new EvaluateScript(string javascript, nsIDOMWindow window) overload.
3. Added debug warning message if geckofx is used in non STA mode.

== v29.0-0.17 ==

Linux only tag.

1. Fix GeckoWebBrowser.nsIContextMenuListener2.OnShowContextMenu() to properly encapsulate SWF.MenuItem objects inside Gtk.MenuItem objects.

== v29.0-0.16 ==

1. Linux only tag.

== v29.0-0.15 ==

1. Fix Release build.
2. WindowUtils -- Add SendWheelEvent method (Thanks Matt Gerginski)
3. Fix JSVal Is{Type} functions on 64bit Linux. 
4. Unifiy CreateWindow and CreateWindow2 events, and mark CreateWindow2 as Obsolete. (Thanks Duan Yao)
5. Fix nsIDirectoryServiceProvider (Thanks Duan Yao And Eberhard Beilharz)
6. Handle retargeting during navigation (Thanks Duan Yao)
7. Implements nsIXULAppInfo, and make remote debugging works with firefox 31+. (Thanks Duan Yao)
8. Fixed infinite loop when minizing the window using Facebook. (Thanks Bron-Yr-Aur)
9. Make GeckoPreferences support unicode values  (Thanks Duan Yao)

== v29.0-0.14 ==

1. Linux only tag.

== v29.0-0.13 ==

1. Linux only tag.

== v29.0-0.12 ==

1. Linux only tag.

== v29.0-0.11 ==

1. Upgraded OffScreenGeckoWebBrowser to use ImageCreater.
2. Certificates and Cache fixes
3. XPath add SelectSingle and SelectFirst

== v29.0-0.10 ==

1. Added "load", "abort", and "error" listeners to XML Requests to fix the AjaxIsBusy flag.
2. Hook up JS_SetErrorReporter on Linux
3. Generate debug info on Linux
4. Enhance effective Debian/Ubuntu packaging.

Thanks: Bron-Yr-Aur, Eberhard Beilharz, Steve McConnel.

== v29.0-0.9 ==

1. Linux only tag.

== v29.0-0.8 ==

1. Improve how geckofx handles Popups.
2. Improve handling of LoadContent calls that occur before geckofx control handle is created.
3. Linux Makefile improvements.

Thanks : Duan Yao, Jason Naylor, Steve McConnel.

== v29.0-0.7 ==

1. Linux only tag.

== v29.0-0.6 ==

1. Eliminate mandatory GeckoWebBrowser.UseCustomPrompt() call.
2. Add FullscreenChange event.
3. Fix GeckoWebBrowser.OnPrint in desing mode
4. Allow LoadContent to be called if control handle is not yet created.
5. Fix print issues (#50 and #54); add print button to geckfxtest.
6. Use custom marshaler for nsAStringBase
7. More flexible XULRunnerLocator

Thanks : Duan Yao, vmas

== v29.0-0.5 ==

1. Linux only tag.

== v29.0-0.4 ==

1. Regenerate interfaces against released firefox 29
2. Make GeckoWebBrowser.DocumentCompleted's event type more specific.
3. Add NavigationError event to GeckoWebBrowser and make GeckoWebBrowser always fire events asynchronously.
4. Make GeckoWebBrowser.Reload/GoBack()/GoForward() always fire events asynchronously.
5. Fix GoBack()/GoForward() fired NavigationError event with correct url.
6. Full Xpath Support. Before this you could not evaluate xpaths that return string, only ones that return nodes.
7. Fix custom prompt by using default nsIPromptFactory implemetation
8. Fix WindowMediator (Issue #11).
9. Fix https://bitbucket.org/geckofx/geckofx-29.0/issue/33/having-a-problem-to-get-a-screenshot-of-a
10. QuerySelector (CSS) & GetSingle (XPATH)
11. GeckoPreference random AccessViolationException fix
12. Fix https://bitbucket.org/geckofx/geckofx-29.0/issue/39/certoverrideservicerememberrecentbadcert
13. PreferenceService - added typed getter & setter

Thanks : Duan Yao, hheexx, vmas, zloyprotoss

== v29.0-0.3 ==

1. Linux only tag.

== v29.0-0.2 ==

1. Fix https://bitbucket.org/geckofx/geckofx-29.0/issue/8/geckowebbrowsernavigate-dont-have-to :
  GeckoWebBrowser.Navigate() don't have to return early for non-existing local file.
2. Fix https://bitbucket.org/geckofx/geckofx-29.0/issue/28/autojscontextevaluatescript-does-not
   AutoJSContext.EvaluateScript does not accept unicode charactars (non-ISO-8859-1)
3. Fix https://bitbucket.org/geckofx/geckofx-29.0/issue/30/unicode-path
   nsACString with unicode chars (Thanks Duan Yao)
4. Fix Fixed problem with unicode symbols in path to XULRunner (Thanks vmas)

== v29.0-0.1 ==

1. Initial version supporting firefox/xulrunner v29.0

== v22.0-0.7 ==

1. Added Unregister method to BaseNsFactory<TFactory>
2. Allow .NET-event handlers for unload, beforeunload, etc.
3. Fix: https://bitbucket.org/geckofx/geckofx-22.0/issue/54/casting-geckonode-to-geckoelement-for-svg

== v22.0-0.6 ==

1. Fixed reference counting issue which caused crash when calling XpCom.Shutdown.
2. CertOverrideService was added.
3. GeckoWebBrowser.NSSError event was added.

== v22.0-0.5 ==

1. ComPtr's, with missing disposed are now released again rather than a warning message being displayed.
2. New EvaluateScript method that returns a JsVal (thanks SBetzin)
3. New JQueryExecutor class (thanks SBetzin)
4. Memory leak fixes.

== v22.0-0.3 ==

1. Fix bug where geckofx was releasing COM ptr on the GC thread.

== v22.0-0.2 ==

1. Initial version supporting firefox/xulrunner v22.0

== v21.0-0.2 ==

1. Fix zooming.
2. Fix issue #3 (AccessViolationException on Dispose())

== v21.0-0.1 ==

1. Initial version supporting firefox/xulrunner v21.0
2. GeckoWebBrowser.LoadHtml(string content, string url, string contentType) 
which provides a new way of loading WebBrowser content via a string.

== v18.0-0.2 ==

1. Small bug fix release.

== v18.0-0.1 ==

1. Initial version supporting firefox/xulrunner v18.0

== v16.0-0.2 ==

1. New ReadyStateChanged event. Usefull for telling when a document has completly loaded.
2. Memory leak fixes.

== v16.0-0.1 ==

1. Initial version supporting firefox/xulrunner v16.0

== v15.0-0.2 ==

1. Fix #1 : HTML5 video and audio still non-functional - https://bitbucket.org/geckofx/geckofx-15.0/issue/1
2. Fix #4 - CreateJSContext puts an error in the console
3. Fix #7 - GeckoWebBrowser.GetMarkupDocumentViewer() throws Access Violation on subsequent calls

== v15.0-0.1 ==

1. Initial version supporting firefox/xulrunner v15.0

== v14.0-0.2 ==

1. Numerious bug fixes.
2. Lots of improvements to the Linux build, including 64bit Linux.

== v14.0-0.1 ==

1. Initial version supporting firefox/xulrunner v14.0
2. Geckofx has been split into two dlls.
* Geckofx-Core.dll 
* Geckofx-Winfoms.dll 
3. Improvements to the Linux build process.
4. Enhance GeckoHtmlElement wrapper.
5. GeckoWebBrowser Naviagate method now automatically creates initlaizes Geckofx if needed.

== v13.0-0.1 ==

1. Initial version supporting firefox/xulrunner v13.0

== v12.0-0.3 ==

1. Improve WindowWatcher service
2. Rename missnamed propertie from Frames to Forms.
3. Improve GeckoTextAreaElement wrapper.
4. Added Request Data (for POST/PUT) to GeckoObserveHttpModifyRequestEvent
5. Renamed GeckoNode.Type to GeckoNode.NodeType
6. Fix GeckoWebBrowser memory leak.
7. Rename GetElementById to GetHtmlElementById
8. Add GetElementById that returns a GeckoDomElement
9. Remove version from ProfileDirectory default path and make path cross platform.

== v12.0-0.2 ==

1. Added Cryptography classes.
2. Calling Convention fixes. (stops .net 4.0 error messages)
3. Added wrappers for HttpActivityDistributor,ImgContainer,DomNavigator.
4. Fixed release builds.
5. Added WindowWatcher service wrapper.
6. Add WindowUtils wrapper for nsIDOMWindowUtils
7. Generated interfaces now contain numeric constants defintions. 
8. Added Head Property to GeckoDocument.
9. Added OnRedirecting event to GeckoWebBrowser.
10. Changed AppShellService visibilty to public.
11. Fixed Dispose crash when disposing non shown GeckoWebBrowser instances.

== v12.0-0.1 ==

1. Initial version supporting firefox/xulrunner v12.0
2. Improved JsVal support.

== v11.0-0.3 ==

1. Some work to make geckofx more stable.
2. Fixes crashes on mono caused by broken Marshal.GetObjectForUInknown on mono.
3. Add SelectionStart and Selection End Properties to GeckoInputElement
4. Make GeckoDocument.Body return GeckoElement type not GeckoBodyElement type.

== v11.0-0.2 ==

1. changes from v10.0-0.4 + v10.0-0.5 imported into v11 repo.

== v11.0-0.1 ==

1. Initial version supporting firefox/xulrunner v11.0

== v10.0-0.6 ==

1. More fixes to improve GeckoFx stability.

== v10.0-0.5 ==

1. Numerious fixes to improve Geckofx stability.
2. Added wrappers for XulRuntime WindowMediator WiFiMonitor ExceptionService ScreenManager RandomGenerator

== v10.0-0.4 ==

1. Fix infrequent Linux seg fault when calling SetInputFocus()
2. wrappers for nsIPipe, nsIObserverService, nsIStreamListenerTee, nsIRequestObserver, nsIStorageStream, nsIInputStreamTee, nsIVersionComparer, nsIConsoleService. provided by zloyprotoss
3. Add some aditional stream implementations.  provided by zloyprotoss
4. public Event delegates renamed:
  GeckoNavigatedEventHandler  -> EventHandler<GeckoNavigatedEventArgs>
  GeckoNavigatingEventHandler -> EventHandler<GeckoNavigatingEventArgs>

== v10.0-0.3 ==

1. Make Custom Prompts Service runtime switchable. (currently defaulting to off)
2. Allow Custom Prompt Service to be customized, with out modifiying geckofx.
3. Lots more wrappers provided by zloyprotoss

== v10.0-0.2 ==

1. Memory corruption fixes when ns*String class was used in callbacks.
2. Optional HttpActivityOberver provided by Romi Kuntsman
3. Added DomBlur event handler
4. basic plugin control + PrivateBrowsingService  provided by zloyprotoss
5. GetPngImage method provided by zloyprotoss
6. Linux fixes.

== v10.0-0.1 ==

1. Initial version supporting firefox/xulrunner v10.0

Note: Applications using geckofx must now include the following in there app.manifest
to prevent R6034 errors:

<dependency>
    <dependentAssembly>
      <assemblyIdentity type="win32" name="Microsoft.VC80.CRT" version="8.0.50727.762" processorArchitecture="x86" publicKeyToken="1fc8b3b9a1e18e3b"></assemblyIdentity>
    </dependentAssembly>
  </dependency>

== v9.0-0.5 ==

Linux only release.
1. Add geckofx config files to deal firefox platform differences.
2. Change X11 to libX11 pinvoke dll name match mono.
3. Make NAvigateFinishedNotifier more robust.

== v9.0-0.4 ==

zloyprotoss:
1. fixed  default prompt service. 
2. Added Cache related wrappers.
3. Added CategoryManager wrapper.
4. Added nsURI.Create(string) method.
5. Added Certificates related wrappers.

== V9.0-0.3 ==

Bug fixes

1. Fix bug in method GeckoWebBrowser.GetBitmap.
2. Various Linux improvements.

== v9.0-0.2 ==

Bug fixes

1. Make NaviagateFinshedNotifier disposable.
2. Setting GeckoElement.Id and GeckoElement.ClassName to String.Empty 
or null should now remove the attribute.

Added Features

1. Add GeckoSelection.ScrollIntoView method
2. Add AutoJSContext.EvaluateScript method which allows executing of 
javascript without using Navigate("javascript:").

== v9.0-0.1 ==

1. Initial version supporting firefox/xulrunner v9.0
2. Namespaces renamed from Skybound.Gecko to Gecko.
3. GeckoFx Dll renamed to include Major version number. 
	Skybound.Gecko.dll  -> geckofx-9.dll
4. Generated interfaces now correctly handle implicit_jscontext attribute.

== v8.0-0.9 ==

Bug fixes

1. Only enable Console Message notification when an event handler is attached.

Added Features

1. Added nsIEditor property to GeckoWebbrowser
2. Added StartBatchChanges +  EndBatchChanges to GeckoSelection.

== v8.0-0.8 ==

Bug fixes

1. Make SaveDocument more robust.
2. Only enable Javascript debugger if event handler is attached to the relevant event.

Added Features
1. new GeckoWebBrowser.AddMessageEventListener allows listening for custom javascript MessageEvents.
2. Add "Open In System Browser" option to the default context menu.

== v8.0-0.7 ==

Bug fixes

1. GeckoElement.OuterHtml property, was quoting attributes.
3. GetBitmap using wrong width when not using origin.
4. Fix some issues with flash plugings. (Thanks shcherba)
5. Loading pages without a body, could throw exception.

Added Features

1. Added DomContentChanged event.
2. Addws JavascriptError event
3. Addws ConsoleMessage event.

== v8.0-0.6 ==

1. Fix GetBitmap method to work with Invisiable windows.
2. Add PrintSettings class which implements nsIPrintSettings.

== v8.0-0.5 ==

1. Add a GetBitmap method to GeckoWebBrowser which replaces the Control.DrawToBitmap method that used to work in old versions of gecko.

== v8.0-0.4 ==

1. Added NavigateFinishedNotifier.NavigateFinished so that its easy to tell when a Navigation has completely finished.

== v8.0-0.3 ==

1. Add MarkupDocumentViewer wrapper (allows setting FullZoom + lots of other options)

== v8.0-0.2 ==

1. Add DomDoubleClick + GetData Extenstion method (Sent by Salaros)
2. Improve Generated files to handle array better. Fixes bug https://bitbucket.org/geckofx/geckofx-7.0/issue/7
3. Disable GeckoWrapperCache by default.

== v8.0-0.1 ==

1. Initial version supporting xulrunner v8.0

== v7.0-0.1 ==

1. Initial version supporting xulrunner v7.0

== v6.0-0.3 ==

1. Fix bug https://bitbucket.org/geckofx/geckofx-6.0/issue/4 by changing
idl out params to ref (from out).

== v6.0-0.2 ==

Include changes from geckofx-5.0:
1. Add Axis property to GeckoDomMouseEventArgs. (Thanks Priyank)
2. Add GeckoComment class.
3. Add NodeType Enum.
4. Fix mapping of ACString in Generated interfaces.
5. Lots of Optimizations including weakreferences caching. This is enabled by default, to disable: GeckoWrapperCache.Enabled = false;
6. Fix some bugs displaying the default context menu.
7. Add methods ScrollTo, ScrollBy, ScrollByLines, ScrollByPages, and SizeToContent to GeckoWindow.


== v6.0-0.1 ==

1. Initial version supporting xulrunner v6.0

== v5.0-0.5 ==

Bug fixes
=========

1. Fix bugs in GeckoSelection
2. fix bug in GeckoWebBrowser nsIEmbeddingSiteWindow2.SetDimensions (Thanks zloyprotoss)
3. Fix bug in generated xulrunner interfaces where double was being used instead of float. (Thanks Priyank)

Added Features
=============

1. Expose GeckoSelection.RemoveAllRanges and GeckoSelection.DeleteFromDocument
2. GeckoNode got the new properties: Type, ParentNode, ParentElement
3. GeckoSelection got the new properties: BoundingClientRect, ClientRects
4. GeckoElement got the new property: BoundingClientRect
5. GeckoDocument got the new property: CreateTextNode
6. GeckoWebBrowser got the new event: Load

== v5.0-0.4 ==

1. Improve OuterHtml values.
2. Performance optimization.
3. Fix GeckoRange.ToString method.
4. Add ContentEditable, Blur, Focus and Click to GeckoElement
5. Add PreventDefault and StopPropagation to GeckoDomEventsArgs
6. Found and deleted some remaining handwritten Xulrunner interfaces.
7. Add LoadHtml(string) function that loads page based upon a string.
8. Fix bug where InvalidCastException was being thrown when clicking on certain links.
9. Disallow GeckoSelection represting a null selection.

== v5.0-0.3 ==

Import changes from geckofx-2.0:

Patch from zloyprotoss that:

1. Optimizes WStringMarshaler
2. Makes DOM GeckoElements actually be their Gecko DOM type.

== v5.0-0.2 ==

Import changes from geckofx-2.0:

1. Add GetNodes(xpath), GetElements(xpath) to GeckoDom.
2. Fix Bug where GeckoSelection object was not being updated.
3. Improved Naviagte support specifying for POST headers.
4. Exposed NS_ShutdownXPCOM.
5. Rewrite much of AutoJSContext to prevent crashing with FF 4 and newer.
6. Add HasAttribute method to GeckoElement.
7. Add very basic OuterHtml property to GeckoElement.
8. Fix bug which was causing Links to have wrong cursor.

== v5.0-0.1 ==

1. Initial version supporting xulrunner v5.0

== v2.0.1-0.10 ==

Patch from zloyprotoss that:

1. Optimizes WStringMarshaler
2. Makes DOM GeckoElements actually be their Gecko DOM type.

== v2.0.1-0.9 ==

1. Fix bug which was causing Links to have wrong cursor.

== v2.0.1-0.8 ==

1. Rewrite much of AutoJSContext to prevent crashing with FF 4 and newer.
2. Add HasAttribute method to GeckoElement.
3. Add very basic OuterHtml property to GeckoElement.

== v2.0.1-0.7 ==

1. Add GetNodes(xpath), GetElements(xpath) to GeckoDom.
2. Fix Bug where GeckoSelection object was not being updated.
3. Improved Naviagte support specifying for POST headers.
4. Exposed NS_ShutdownXPCOM.

== v2.0.1-0.6 ==

1. Fix issue with LPStruct marshaled nsAString return types. Fixes https://bitbucket.org/geckofx/geckofx-2.0/issue/15

== v2.0.1-0.5 ==

1. Rename namespace Skybound.Gecko.XpCom to Skybound.Gecko.CustomMarshalers to prevent VB name clash.

== v2.0.1-0.4 ==

1. bool types, in Generated Files, now have the MarshalAs(UnmanagedType.Bool) attribute applied.

== v2.0.1-0.3 ==

1. Generated Files now contain correct License block.
2. Generated Files now contain method and interface comments imported directly from 
   the IDL files.
3. Fix bug where some return parameter types were missing there Marshing attributes.

== v2.0.1-0.2 ==

1. Fix bug where some UTF8 strings were being treated as UTF16.

== v2.0.1-0.1 ==

1. Initial version supporting xulrunner v2.0.1.
2. All interfaces are direcly generated from the xulrunner idl files.

