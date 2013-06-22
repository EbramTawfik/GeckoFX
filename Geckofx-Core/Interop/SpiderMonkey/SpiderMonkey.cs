using System.Runtime.InteropServices;
using System;

// functions are declared like
// extern JS_PUBLIC_API(JSContextCallback) JS_SetContextCallback(JSRuntime *rt, JSContextCallback cxCallback);
// C++ default convention is Cdecl
namespace Gecko
{
	public static class SpiderMonkey
	{
		// Different compiers name munge C++ signitures differently.
		// Assumes Firefox built with MSVC compiler on Windows.
		// TODO: add Linux 32bit + 64bit C++ signitures.
		#region compiler independent wrappers
		public static IntPtr JS_EncodeString(IntPtr cx, IntPtr jsString)
		{
			if (Xpcom.IsLinux)
				throw new NotImplementedException();

			return JS_EncodeString_Win32(cx, jsString);
		}
		
		public static JSType JS_TypeOfValue(IntPtr cx, JsVal jsVal)
		{
			if (Xpcom.IsLinux)
				throw new NotImplementedException();

			return JS_TypeOfValue_Win32(cx, jsVal);
		}

		public static IntPtr JS_ValueToString(IntPtr cx, JsVal v)
		{
			if (Xpcom.IsLinux)
				throw new NotImplementedException();

			return JS_ValueToString_Win32(cx, v);
		}

		public static IntPtr JS_NewStringCopyN(IntPtr cx, string str, int length)
		{
			if (Xpcom.IsLinux)
				throw new NotImplementedException();

			return JS_NewStringCopyN_Win32(cx, str, length);
		}

		public static IntPtr JS_GetGlobalForScopeChain(IntPtr aJSContext)
		{
			if (Xpcom.IsLinux)
				throw new NotImplementedException();

			return JS_GetGlobalForScopeChain_Win32(aJSContext);
		}

		public static IntPtr JS_GetGlobalObject(IntPtr aJSContext)
		{
			if (Xpcom.IsLinux)
				throw new NotImplementedException();

			return JS_GetGlobalObject_Win32(aJSContext);
		}

		public static IntPtr JS_BeginRequest(IntPtr cx)
		{
			if (Xpcom.IsLinux)
				throw new NotImplementedException();

			return JS_BeginRequest_Win32(cx);
		}

		public static IntPtr JS_EndRequest(IntPtr cx)
		{
			if (Xpcom.IsLinux)
				throw new NotImplementedException();

			return JS_EndRequest_Win32(cx);
		}

		public static bool JS_EvaluateScript(IntPtr cx, IntPtr obj, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval)
		{
			if (Xpcom.IsLinux)
				throw new NotImplementedException();

			return JS_EvaluateScript_Win32(cx, obj, src, length, filename, lineno, ref jsval);
		}

		public static bool JS_EvaluateScriptForPrincipals(IntPtr cx, IntPtr obj, IntPtr principals, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval)
		{
			if (Xpcom.IsLinux)
				throw new NotImplementedException();

			return JS_EvaluateScriptForPrincipals_Win32(cx, obj, principals, src, length, filename, lineno, ref jsval);
		}


		public static IntPtr JS_GetClass(IntPtr obj)
		{
			if (Xpcom.IsLinux)
				throw new NotImplementedException();

			return JS_GetClass_Win32(obj);
		}

		public static IntPtr JS_ContextIterator(IntPtr rt, ref IntPtr iterp)
		{
			if (Xpcom.IsLinux)
				throw new NotImplementedException();

			return JS_ContextIterator_Win32(rt, ref iterp);
		}

		public static SpiderMonkey.JSContextCallback JS_SetContextCallback(IntPtr rt, JSContextCallback cb)
		{
			if (Xpcom.IsLinux)
				throw new NotImplementedException();

			return JS_SetContextCallback_Win32(rt, cb);
		}

		#endregion

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

		[UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
		public delegate JSBool JSContextCallback(IntPtr cx, UInt32 contextOp);
		
		/// <summary>
		/// declaration in jsapi.h
		/// extern JS_PUBLIC_API(JSContextCallback) JS_SetContextCallback(JSRuntime *rt, JSContextCallback cxCallback);
		/// </summary>
		/// <param name="rt"></param>
		/// <param name="cb"></param>
		/// <returns></returns>
		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_SetContextCallback@@YAP6AHPAUJSContext@@I@ZPAUJSRuntime@@P6AH0I@Z@Z")]
		private static extern SpiderMonkey.JSContextCallback JS_SetContextCallback_Win32(IntPtr rt, JSContextCallback cb);


	}
}