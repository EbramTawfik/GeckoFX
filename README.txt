Geckofx is licensed under the Mozilla Public License Version.

== Changelog ==

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

