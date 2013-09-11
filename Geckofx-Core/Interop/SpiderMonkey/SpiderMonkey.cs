using System.Runtime.InteropServices;
using System;

// functions are declared like
// extern JS_PUBLIC_API(JSContextCallback) JS_SetContextCallback(JSRuntime *rt, JSContextCallback cxCallback);
// C++ default convention is Cdecl
namespace Gecko
{
	public static class SpiderMonkey
	{
		// Different compilers name munge C++ signitures differently.
		// Assumes Firefox built with MSVC compiler on Windows and gcc compiler on Linux
		#region compiler independent wrappers
		public static IntPtr JS_EncodeString(IntPtr cx, IntPtr jsString)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_EncodeString_Linux32(cx, jsString);

				return JS_EncodeString_Win32(cx, jsString);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_EncodeString_Linux64(cx, jsString);

				return JS_EncodeString_Win64(cx, jsString);
			}
		}

		public static JSType JS_TypeOfValue(IntPtr cx, JsVal jsVal)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_TypeOfValue_Linux32(cx, jsVal);

				return JS_TypeOfValue_Win32(cx, jsVal);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_TypeOfValue_Linux64(cx, jsVal);

				return JS_TypeOfValue_Win64(cx, jsVal);
			}
		}

		public static IntPtr JS_ValueToString(IntPtr cx, JsVal v)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_ValueToString_Linux32(cx, v);

				return JS_ValueToString_Win32(cx, v);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_ValueToString_Linux64(cx, v);

				return JS_ValueToString_Win64(cx, v);
			}
		}

		public static IntPtr JS_NewStringCopyN(IntPtr cx, string str, int length)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_NewStringCopyN_Linux32(cx, str, length);

				return JS_NewStringCopyN_Win32(cx, str, length);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_NewStringCopyN_Linux64(cx, str, length);

				return JS_NewStringCopyN_Win64(cx, str, length);
			}
		}

		public static IntPtr JS_GetGlobalForScopeChain(IntPtr aJSContext)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_GetGlobalForScopeChain_Linux32(aJSContext);

				return JS_GetGlobalForScopeChain_Win32(aJSContext);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_GetGlobalForScopeChain_Linux64(aJSContext);

				return JS_GetGlobalForScopeChain_Win64(aJSContext);
			}
		}

		public static IntPtr JS_GetGlobalObject(IntPtr aJSContext)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_GetGlobalObject_Linux32(aJSContext);

				return JS_GetGlobalObject_Win32(aJSContext);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_GetGlobalObject_Linux64(aJSContext);

				return JS_GetGlobalObject_Win64(aJSContext);
			}
		}

		public static IntPtr JS_BeginRequest(IntPtr cx)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_BeginRequest_Linux32(cx);

				return JS_BeginRequest_Win32(cx);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_BeginRequest_Linux64(cx);

				return JS_BeginRequest_Win64(cx);
			}
		}

		public static IntPtr JS_EndRequest(IntPtr cx)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_EndRequest_Linux32(cx);

				return JS_EndRequest_Win32(cx);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_EndRequest_Linux64(cx);

				return JS_EndRequest_Win64(cx);
			}
		}

		public static bool JS_EvaluateScript(IntPtr cx, IntPtr obj, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_EvaluateScript_Linux32(cx, obj, src, length, filename, lineno, ref jsval);

				return JS_EvaluateScript_Win32(cx, obj, src, length, filename, lineno, ref jsval);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_EvaluateScript_Linux64(cx, obj, src, length, filename, lineno, ref jsval);

				return JS_EvaluateScript_Win64(cx, obj, src, length, filename, lineno, ref jsval);
			}
		}

		public static bool JS_EvaluateScriptForPrincipals(IntPtr cx, IntPtr obj, IntPtr principals, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_EvaluateScriptForPrincipals_Linux32(cx, obj, principals, src, length, filename, lineno, ref jsval);

				return JS_EvaluateScriptForPrincipals_Win32(cx, obj, principals, src, length, filename, lineno, ref jsval);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_EvaluateScriptForPrincipals_Linux64(cx, obj, principals, src, length, filename, lineno, ref jsval);

				return JS_EvaluateScriptForPrincipals_Win64(cx, obj, principals, src, length, filename, lineno, ref jsval);
			}
		}


		public static IntPtr JS_GetClass(IntPtr obj)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_GetClass_Linux32(obj);

				return JS_GetClass_Win32(obj);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_GetClass_Linux64(obj);

				return JS_GetClass_Win64(obj);
			}
		}

		public static IntPtr JS_ContextIterator(IntPtr rt, ref IntPtr iterp)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_ContextIterator_Linux32(rt, ref iterp);

				return JS_ContextIterator_Win32(rt, ref iterp);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_ContextIterator_Linux64(rt, ref iterp);

				return JS_ContextIterator_Win64(rt, ref iterp);
			}
		}

		public static SpiderMonkey.JSContextCallback JS_SetContextCallback(IntPtr rt, JSContextCallback cb)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_SetContextCallback_Linux32(rt, cb);

				return JS_SetContextCallback_Win32(rt, cb);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_SetContextCallback_Linux64(rt, cb);

				return JS_SetContextCallback_Win64(rt, cb);
			}
		}

		public static IntPtr JS_EnterCompartment(IntPtr cx, IntPtr obj)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_EnterCompartment_Linux32(cx, obj);
				return JS_EnterCompartment_Win32(cx, obj);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_EnterCompartment_Linux64(cx, obj);
				return JS_EnterCompartment_Win64(cx, obj);
			}
		}

		public static void JS_LeaveCompartment(IntPtr cx, IntPtr oldCompartment)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					JS_LeaveCompartment_Linux32(cx, oldCompartment);
				else
					JS_LeaveCompartment_Win32(cx, oldCompartment);
			}
			else
			{
				if (Xpcom.IsLinux)
					JS_LeaveCompartment_Linux64(cx, oldCompartment);
				else
					JS_LeaveCompartment_Win64(cx, oldCompartment);
			}
		}

		public static void JS_Free(IntPtr cx, IntPtr p)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					JS_Free_Linux32(cx, p);
				else
					JS_Free_Win32(cx, p);
			}
			else
			{
				if (Xpcom.IsLinux)
					JS_Free_Linux64(cx, p);
				else
					JS_Free_Win64(cx, p);
			}
		}
		
		public static void JS_Shutdown()
		{			
			if (Xpcom.IsWindows)
				throw new NotImplementedException();
			
			if (Xpcom.Is32Bit)
				JS_Shutdown_Linux32();
			else 
				JS_Shutdown_Linux64();
		}	
		
		public static void JS_DestroyRuntime(IntPtr rt)
		{		
			if (Xpcom.IsWindows)
				throw new NotImplementedException();
			
			if (Xpcom.Is32Bit)
				JS_DestroyRuntime_Linux32(rt);
			else 
				JS_DestroyRuntime_Linux64(rt);
		}

		#endregion

		[UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
		public delegate JSBool JSContextCallback(IntPtr cx, UInt32 contextOp);




		#region Windows x86

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EncodeString@@YAPADPAUJSContext@@PAVJSString@@@Z")]
		private static extern IntPtr JS_EncodeString_Win32(IntPtr cx, IntPtr jsString);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_TypeOfValue@@YA?AW4JSType@@PAUJSContext@@VValue@JS@@@Z")]
		private static extern JSType JS_TypeOfValue_Win32(IntPtr cx, JsVal jsVal);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_ValueToString@@YAPAVJSString@@PAUJSContext@@VValue@JS@@@Z")]
		private static extern IntPtr JS_ValueToString_Win32(IntPtr cx, JsVal v);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_NewStringCopyN@@YAPAVJSString@@PAUJSContext@@PBDI@Z")]
		private static extern IntPtr JS_NewStringCopyN_Win32(IntPtr cx, string str, int length);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetGlobalForScopeChain@@YAPAVJSObject@@PAUJSContext@@@Z")]
		private static extern IntPtr JS_GetGlobalForScopeChain_Win32(IntPtr aJSContext);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetGlobalObject@@YAPAVJSObject@@PAUJSContext@@@Z")]
		private static extern IntPtr JS_GetGlobalObject_Win32(IntPtr aJSContext);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_BeginRequest@@YAXPAUJSContext@@@Z")]
		private static extern IntPtr JS_BeginRequest_Win32(IntPtr cx);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EndRequest@@YAXPAUJSContext@@@Z")]
		private static extern IntPtr JS_EndRequest_Win32(IntPtr cx);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EvaluateScript@@YAHPAUJSContext@@PAVJSObject@@PBDI2IPAVValue@JS@@@Z")]
		private static extern bool JS_EvaluateScript_Win32(IntPtr cx, IntPtr obj, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EvaluateScriptForPrincipals@@YAHPAUJSContext@@PAVJSObject@@PAUJSPrincipals@@PBDI3IPAVValue@JS@@@Z")]
		private static extern bool JS_EvaluateScriptForPrincipals_Win32(IntPtr cx, IntPtr obj, IntPtr principals, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetClass@@YAPAUJSClass@@PAVJSObject@@@Z")]
		private static extern IntPtr JS_GetClass_Win32(IntPtr obj);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_ContextIterator@@YAPAUJSContext@@PAUJSRuntime@@PAPAU1@@Z")]
		private static extern IntPtr JS_ContextIterator_Win32(IntPtr rt, ref IntPtr iterp);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EnterCompartment@@YAPAUJSCompartment@@PAUJSContext@@PAVJSObject@@@Z")]
		private static extern IntPtr JS_EnterCompartment_Win32(IntPtr cx, IntPtr obj);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_LeaveCompartment@@YAXPAUJSContext@@PAUJSCompartment@@@Z")]
		private static extern void JS_LeaveCompartment_Win32(IntPtr cx, IntPtr oldCompartment);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_free@@YAXPAUJSContext@@PAX@Z")]
		private static extern void JS_Free_Win32(IntPtr cx, IntPtr p);
		
		/// <summary>
		/// declaration in jsapi.h
		/// extern JS_PUBLIC_API(JSContextCallback) JS_SetContextCallback(JSRuntime *rt, JSContextCallback cxCallback);
		/// </summary>
		/// <param name="rt"></param>
		/// <param name="cb"></param>
		/// <returns></returns>
		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_SetContextCallback@@YAP6AHPAUJSContext@@I@ZPAUJSRuntime@@P6AH0I@Z@Z")]
		private static extern SpiderMonkey.JSContextCallback JS_SetContextCallback_Win32(IntPtr rt, JSContextCallback cb);
		
		#endregion

		#region Windows x64

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EncodeString@@YAPEADPEAUJSContext@@PEAVJSString@@@Z")]
		private static extern IntPtr JS_EncodeString_Win64(IntPtr cx, IntPtr jsString);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_TypeOfValue@@YA?AW4JSType@@PEAUJSContext@@VValue@JS@@@Z")]
		private static extern JSType JS_TypeOfValue_Win64(IntPtr cx, JsVal jsVal);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_ValueToString@@YAPEAVJSString@@PEAUJSContext@@VValue@JS@@@Z")]
		private static extern IntPtr JS_ValueToString_Win64(IntPtr cx, JsVal v);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_NewStringCopyN@@YAPEAVJSString@@PEAUJSContext@@PEBD_K@Z")]
		private static extern IntPtr JS_NewStringCopyN_Win64(IntPtr cx, string str, int length);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetGlobalForScopeChain@@YAPEAVJSObject@@PEAUJSContext@@@Z")]
		private static extern IntPtr JS_GetGlobalForScopeChain_Win64(IntPtr aJSContext);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetGlobalObject@@YAPEAVJSObject@@PEAUJSContext@@@Z")]
		private static extern IntPtr JS_GetGlobalObject_Win64(IntPtr aJSContext);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_BeginRequest@@YAXPEAUJSContext@@@Z")]
		private static extern IntPtr JS_BeginRequest_Win64(IntPtr cx);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EndRequest@@YAXPEAUJSContext@@@Z")]
		private static extern IntPtr JS_EndRequest_Win64(IntPtr cx);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EvaluateScript@@YAHPEAUJSContext@@PEAVJSObject@@PEBDI2IPEAVValue@JS@@@Z")]
		private static extern bool JS_EvaluateScript_Win64(IntPtr cx, IntPtr obj, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EvaluateScriptForPrincipals@@YAHPEAUJSContext@@PEAVJSObject@@PEAUJSPrincipals@@PEBDI3IPEAVValue@JS@@@Z")]
		private static extern bool JS_EvaluateScriptForPrincipals_Win64(IntPtr cx, IntPtr obj, IntPtr principals, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetClass@@YAPEAUJSClass@@PEAVJSObject@@@Z")]
		private static extern IntPtr JS_GetClass_Win64(IntPtr obj);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_ContextIterator@@YAPEAUJSContext@@PEAUJSRuntime@@PEAPEAU1@@Z")]
		private static extern IntPtr JS_ContextIterator_Win64(IntPtr rt, ref IntPtr iterp);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EnterCompartment@@YAPEAUJSCompartment@@PEAUJSContext@@PEAVJSObject@@@Z")]
		private static extern IntPtr JS_EnterCompartment_Win64(IntPtr cx, IntPtr obj);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_LeaveCompartment@@YAXPEAUJSContext@@PEAUJSCompartment@@@Z")]
		private static extern void JS_LeaveCompartment_Win64(IntPtr cx, IntPtr oldCompartment);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_free@@YAXPEAUJSContext@@PEAX@Z")]
		private static extern void JS_Free_Win64(IntPtr cx, IntPtr p);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_SetContextCallback@@YAP6AHPEAUJSContext@@I@ZPEAUJSRuntime@@P6AH0I@Z@Z")]
		private static extern SpiderMonkey.JSContextCallback JS_SetContextCallback_Win64(IntPtr rt, JSContextCallback cb);

		#endregion

		#region Linux x86

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z15JS_EncodeStringP9JSContextP8JSString")]
		private static extern IntPtr JS_EncodeString_Linux32(IntPtr cx, IntPtr jsString);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z14JS_TypeOfValueP9JSContextN2JS5ValueE")]
		private static extern JSType JS_TypeOfValue_Linux32(IntPtr cx, JsVal jsVal);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z16JS_ValueToStringP9JSContextN2JS5ValueE")]
		private static extern IntPtr JS_ValueToString_Linux32(IntPtr cx, JsVal v);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_NewStringCopyNP9JSContextPKcj")]
		private static extern IntPtr JS_NewStringCopyN_Linux32(IntPtr cx, string str, int length);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z25JS_GetGlobalForScopeChainP9JSContext")]
		private static extern IntPtr JS_GetGlobalForScopeChain_Linux32(IntPtr aJSContext);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z18JS_GetGlobalObjectP9JSContext")]
		private static extern IntPtr JS_GetGlobalObject_Linux32(IntPtr aJSContext);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z15JS_BeginRequestP9JSContext")]
		private static extern IntPtr JS_BeginRequest_Linux32(IntPtr cx);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z13JS_EndRequestP9JSContext")]
		private static extern IntPtr JS_EndRequest_Linux32(IntPtr cx);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_EvaluateScriptP9JSContextP8JSObjectPKcjS4_jPN2JS5ValueE")]
		private static extern bool JS_EvaluateScript_Linux32(IntPtr cx, IntPtr obj, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z30JS_EvaluateScriptForPrincipalsP9JSContextP8JSObjectP12JSPrincipalsPKcjS6_jPN2JS5ValueE")]
		private static extern bool JS_EvaluateScriptForPrincipals_Linux32(IntPtr cx, IntPtr obj, IntPtr principals, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z11JS_GetClassP8JSObject")]
		private static extern IntPtr JS_GetClass_Linux32(IntPtr obj);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z18JS_ContextIteratorP9JSRuntimePP9JSContext")]
		private static extern IntPtr JS_ContextIterator_Linux32(IntPtr rt, ref IntPtr iterp);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z19JS_EnterCompartmentP9JSContextP8JSObject")]
		private static extern IntPtr JS_EnterCompartment_Linux32(IntPtr cx, IntPtr obj);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z19JS_LeaveCompartmentP9JSContextP13JSCompartment")]
		private static extern void JS_LeaveCompartment_Linux32(IntPtr cx, IntPtr oldCompartment);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z7JS_freeP9JSContextPv")]
		private static extern void JS_Free_Linux32(IntPtr cx, IntPtr p);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z21JS_SetContextCallbackP9JSRuntimePFiP9JSContextjE")]
		private static extern SpiderMonkey.JSContextCallback JS_SetContextCallback_Linux32(IntPtr rt, JSContextCallback cb);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z11JS_ShutDownv")]
		private static extern void JS_Shutdown_Linux32();
		
		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_DestroyRuntimeP9JSRuntime")]
		private static extern void JS_DestroyRuntime_Linux32(IntPtr rt);

		#endregion

		#region Linux x64

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z15JS_EncodeStringP9JSContextP8JSString")]
		private static extern IntPtr JS_EncodeString_Linux64(IntPtr cx, IntPtr jsString);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z14JS_TypeOfValueP9JSContextN2JS5ValueE")]
		private static extern JSType JS_TypeOfValue_Linux64(IntPtr cx, JsVal jsVal);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z16JS_ValueToStringP9JSContextN2JS5ValueE")]
		private static extern IntPtr JS_ValueToString_Linux64(IntPtr cx, JsVal v);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_NewStringCopyNP9JSContextPKcm")]
		private static extern IntPtr JS_NewStringCopyN_Linux64(IntPtr cx, string str, int length);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z25JS_GetGlobalForScopeChainP9JSContext")]
		private static extern IntPtr JS_GetGlobalForScopeChain_Linux64(IntPtr aJSContext);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z18JS_GetGlobalObjectP9JSContext")]
		private static extern IntPtr JS_GetGlobalObject_Linux64(IntPtr aJSContext);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z15JS_BeginRequestP9JSContext")]
		private static extern IntPtr JS_BeginRequest_Linux64(IntPtr cx);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z13JS_EndRequestP9JSContext")]
		private static extern IntPtr JS_EndRequest_Linux64(IntPtr cx);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_EvaluateScriptP9JSContextP8JSObjectPKcjS4_jPN2JS5ValueE")]
		private static extern bool JS_EvaluateScript_Linux64(IntPtr cx, IntPtr obj, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z30JS_EvaluateScriptForPrincipalsP9JSContextP8JSObjectP12JSPrincipalsPKcjS6_jPN2JS5ValueE")]
		private static extern bool JS_EvaluateScriptForPrincipals_Linux64(IntPtr cx, IntPtr obj, IntPtr principals, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z11JS_GetClassP8JSObject")]
		private static extern IntPtr JS_GetClass_Linux64(IntPtr obj);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z18JS_ContextIteratorP9JSRuntimePP9JSContext")]
		private static extern IntPtr JS_ContextIterator_Linux64(IntPtr rt, ref IntPtr iterp);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z19JS_EnterCompartmentP9JSContextP8JSObject")]
		private static extern IntPtr JS_EnterCompartment_Linux64(IntPtr cx, IntPtr obj);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z19JS_LeaveCompartmentP9JSContextP13JSCompartment")]
		private static extern void JS_LeaveCompartment_Linux64(IntPtr cx, IntPtr oldCompartment);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z7JS_freeP9JSContextPv")]
		private static extern void JS_Free_Linux64(IntPtr cx, IntPtr p);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z21JS_SetContextCallbackP9JSRuntimePFiP9JSContextjE")]
		private static extern SpiderMonkey.JSContextCallback JS_SetContextCallback_Linux64(IntPtr rt, JSContextCallback cb);
		
		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z11JS_ShutDownv")]
		private static extern void JS_Shutdown_Linux64();
		
		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_DestroyRuntimeP9JSRuntime")]
		private static extern void JS_DestroyRuntime_Linux64(IntPtr rt);

		#endregion

	}
}