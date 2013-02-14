using System.Runtime.InteropServices;
using System;

// functions are declared like
// extern JS_PUBLIC_API(JSContextCallback) JS_SetContextCallback(JSRuntime *rt, JSContextCallback cxCallback);
// C++ default convention is Cdecl
namespace Gecko
{
	public static class SpiderMonkey
	{
		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr JS_EncodeString(IntPtr cx, IntPtr jsString);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
		public static extern JSType JS_TypeOfValue(IntPtr cx, JsVal jsVal);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr JS_ValueToString(IntPtr cx, JsVal v);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr JS_NewStringCopyN(IntPtr cx, string str, int length);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr JS_GetGlobalForScopeChain(IntPtr aJSContext);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr JS_CompileScriptForPrincipals(IntPtr aJSContext, IntPtr aJSObject, IntPtr aJSPrincipals, string bytes, int length, string filename, int lineNumber);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr JS_GetGlobalObject(IntPtr aJSContext);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr JS_NewContext(IntPtr aJSRuntime, int stackchunksize);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
		public static extern void JS_DestroyContextNoGC(IntPtr cx);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr JS_BeginRequest(IntPtr cx);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr JS_EndRequest(IntPtr cx);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool JS_EvaluateScript(IntPtr cx, IntPtr obj, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval);

		[DllImport("mozjs", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool JS_EvaluateScriptForPrincipals(IntPtr cx, IntPtr obj, IntPtr principals, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool JS_InitStandardClasses(IntPtr cx, IntPtr obj);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
		public static extern void JS_SetGlobalObject(IntPtr cx, IntPtr jsObject);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr JS_EnterCrossCompartmentCall(IntPtr cx, IntPtr targetJSObject);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr JS_Init(UInt32 maxbytes);
		
		[UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
		public delegate int CallBack(IntPtr cx, UInt32 contextOp);
		
		/// <summary>
		/// declaration in jsapi.h
		/// extern JS_PUBLIC_API(JSContextCallback) JS_SetContextCallback(JSRuntime *rt, JSContextCallback cxCallback);
		/// </summary>
		/// <param name="rt"></param>
		/// <param name="cb"></param>
		/// <returns></returns>
		[DllImport("mozjs",CallingConvention = CallingConvention.Cdecl)]
		public static extern SpiderMonkey.CallBack JS_SetContextCallback(IntPtr rt, CallBack cb);


	}
}