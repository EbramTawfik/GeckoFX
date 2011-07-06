Geckofx is licensed under the Mozilla Public License Version.

== Changelog ==

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

