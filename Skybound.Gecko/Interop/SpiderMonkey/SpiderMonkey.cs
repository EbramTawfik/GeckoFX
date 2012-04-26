using System.Runtime.InteropServices;
using System;
namespace Gecko
{
	public static class SpiderMonkey
	{
		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr JS_EncodeString(IntPtr cx, IntPtr jsString);

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
		public static extern JSType JS_TypeOfValue(IntPtr cx, JsVal jsVal);

		[DllImport("mozjs")]
		public static extern IntPtr JS_ValueToString(IntPtr cx, JsVal v);

		[DllImport("mozjs", CharSet = CharSet.Ansi)]
		public static extern IntPtr JS_NewStringCopyN(IntPtr cx, string str, int length);

		[DllImport("mozjs")]
		public static extern IntPtr JS_GetGlobalForScopeChain(IntPtr aJSContext);

		[DllImport("mozjs", CharSet = CharSet.Ansi)]
		public static extern IntPtr JS_CompileScriptForPrincipals(IntPtr aJSContext, IntPtr aJSObject, IntPtr aJSPrincipals, string bytes, int length, string filename, int lineNumber);

		[DllImport("mozjs")]
		public static extern IntPtr JS_GetGlobalObject(IntPtr aJSContext);

		[DllImport("mozjs")]
		public static extern IntPtr JS_NewContext(IntPtr aJSRuntime, int stackchunksize);

		[DllImport("mozjs")]
		public static extern void JS_DestroyContextNoGC(IntPtr cx);

		[DllImport("mozjs")]
		public static extern IntPtr JS_BeginRequest(IntPtr cx);

		[DllImport("mozjs")]
		public static extern IntPtr JS_EndRequest(IntPtr cx);

		[DllImport("mozjs", CharSet = CharSet.Ansi)]
		public static extern bool JS_EvaluateScript(IntPtr cx, IntPtr obj, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval);

		[DllImport("mozjs", CharSet = CharSet.Ansi)]
		public static extern bool JS_EvaluateScriptForPrincipals(IntPtr cx, IntPtr obj, IntPtr principals, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval);

		[DllImport("mozjs")]
		public static extern bool JS_InitStandardClasses(IntPtr cx, IntPtr obj);

		[DllImport("mozjs")]
		public static extern void JS_SetGlobalObject(IntPtr cx, IntPtr jsObject);

		[DllImport("mozjs")]
		public static extern IntPtr JS_EnterCrossCompartmentCall(IntPtr cx, IntPtr targetJSObject);
		
		[UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
		public delegate int CallBack(IntPtr cx, UInt32 contextOp);
		
		[DllImport("mozjs")]
		public static extern SpiderMonkey.CallBack JS_SetContextCallback(IntPtr rt, CallBack cb);


	}
}