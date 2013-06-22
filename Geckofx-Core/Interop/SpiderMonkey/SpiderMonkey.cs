using System.Runtime.InteropServices;
using System;

// functions are declared like
// extern JS_PUBLIC_API(JSContextCallback) JS_SetContextCallback(JSRuntime *rt, JSContextCallback cxCallback);
// C++ default convention is Cdecl
namespace Gecko
{
	public static class SpiderMonkey
	{
		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EncodeString@@YAPADPAUJSContext@@PAVJSString@@@Z")]
		public static extern IntPtr JS_EncodeString(IntPtr cx, IntPtr jsString);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_TypeOfValue@@YA?AW4JSType@@PAUJSContext@@VValue@JS@@@Z")]
		public static extern JSType JS_TypeOfValue(IntPtr cx, JsVal jsVal);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_ValueToString@@YAPAVJSString@@PAUJSContext@@VValue@JS@@@Z")]
		public static extern IntPtr JS_ValueToString(IntPtr cx, JsVal v);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_NewStringCopyN@@YAPAVJSString@@PAUJSContext@@PBDI@Z")]
		public static extern IntPtr JS_NewStringCopyN(IntPtr cx, string str, int length);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetGlobalForScopeChain@@YAPAVJSObject@@PAUJSContext@@@Z")]
		public static extern IntPtr JS_GetGlobalForScopeChain(IntPtr aJSContext);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetGlobalObject@@YAPAVJSObject@@PAUJSContext@@@Z")]
		public static extern IntPtr JS_GetGlobalObject(IntPtr aJSContext);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_BeginRequest@@YAXPAUJSContext@@@Z")]
		public static extern IntPtr JS_BeginRequest(IntPtr cx);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EndRequest@@YAXPAUJSContext@@@Z")]
		public static extern IntPtr JS_EndRequest(IntPtr cx);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EvaluateScript@@YAHPAUJSContext@@PAVJSObject@@PBDI2IPAVValue@JS@@@Z")]
		public static extern bool JS_EvaluateScript(IntPtr cx, IntPtr obj, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EvaluateScriptForPrincipals@@YAHPAUJSContext@@PAVJSObject@@PAUJSPrincipals@@PBDI3IPAVValue@JS@@@Z")]
		public static extern bool JS_EvaluateScriptForPrincipals(IntPtr cx, IntPtr obj, IntPtr principals, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetClass@@YAPAUJSClass@@PAVJSObject@@@Z")]
		public static extern IntPtr JS_GetClass(IntPtr obj);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_ContextIterator@@YAPAUJSContext@@PAUJSRuntime@@PAPAU1@@Z")]
		public static extern IntPtr JS_ContextIterator(IntPtr rt, ref IntPtr iterp);

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
		public static extern SpiderMonkey.JSContextCallback JS_SetContextCallback(IntPtr rt, JSContextCallback cb);


	}
}