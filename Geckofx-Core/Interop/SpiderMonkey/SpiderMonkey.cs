using System.Collections.Generic;
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

        #region Helper methods for compiler independent wrappers

        enum PlatformEnum
        {
            Win32,
            Win64,
            Linux32,
            Linux64,
        }

        static Lazy<PlatformEnum> Platform = new Lazy<PlatformEnum>(GetPlatform);

        static private PlatformEnum GetPlatform()
        {
            if (Xpcom.Is32Bit)
                return Xpcom.IsWindows ? PlatformEnum.Win32 : PlatformEnum.Linux32;                    
            else if (Xpcom.Is64Bit)
                return Xpcom.IsWindows ? PlatformEnum.Win64 : PlatformEnum.Linux64;

            throw new NotImplementedException();
        }

        /// <summary>
        /// If more platforms are added just add more arguments to this method.
        /// </summary>
        static T Resolve<T>(T win32, T win64, T linux32, T linux64)
        {
            switch (Platform.Value)
            {
                case PlatformEnum.Win32:
                    return win32;
                case PlatformEnum.Win64:
                    return win64;
                case PlatformEnum.Linux32:
                    return linux32;
                case PlatformEnum.Linux64:
                    return linux64;
                default:
                    throw new NotImplementedException();
            }
        }

        #endregion

        #region Delegates for compiler independent wrappers

        // Keep in alphabetical order.

        delegate IntPtr CompileOptionsDelegate(IntPtr @this, IntPtr cx, int jsver);
        delegate IntPtr CurrentGlobalOrNullDelegate(IntPtr aJSContext);
        delegate IntPtr GetGlobalForObjectCrossCompartmentDelegate(IntPtr jsObject);
        delegate bool IsObjectInContextCompartmentDelegate(IntPtr jsObject, IntPtr context);
        delegate IntPtr JS_BeginRequestDelegate(IntPtr cx);
        delegate bool JS_CompileScriptDelegate(IntPtr cx, string str, int strlen, IntPtr compileOptions, ref MutableHandle jsValue);
        delegate bool JS_CallFunctionNameDelegateA(IntPtr cx, ref IntPtr jsObject, string name, IntPtr data, ref MutableHandleValue jsValue);
        delegate bool JS_CallFunctionNameDelegateB(IntPtr cx, ref IntPtr jsObject, string name, ref int args, ref MutableHandleValue jsValue);
        delegate bool JS_CallFunctionValueDelegate(IntPtr cx, IntPtr jsObject, ref JsVal fval, IntPtr passZero, ref MutableHandleValue jsValue);
        delegate IntPtr JS_EncodeStringDelegate(IntPtr cx, IntPtr jsString);
        delegate IntPtr JS_EncodeStringUTF8Delegate(IntPtr cx, ref IntPtr jsString);
        delegate IntPtr JS_EndRequestDelegate(IntPtr cx);
        delegate IntPtr JS_EnterCompartmentDelegate(IntPtr cx, IntPtr obj);
        delegate bool JS_ExecuteScriptDelegate(IntPtr cx, ref IntPtr handleScript, ref MutableHandleValue jsValue);
        delegate void JS_FreeDelegate(IntPtr cx, IntPtr p);
        delegate IntPtr JS_GetClassDelegate(IntPtr obj);
        delegate IntPtr JS_GetClassObjectDelegate(IntPtr context, IntPtr proto, ref MutableHandle jsObject);
        delegate IntPtr JS_GetCompartmentPrincipalsDelegate(IntPtr jsCompartment);
        delegate IntPtr JS_ContextIteratorDelegate(IntPtr rt, ref IntPtr iterp);
        delegate IntPtr JS_GetContextPrivateDelegate(IntPtr context);
        delegate JsVal JS_GetEmptyStringValueDelegate(IntPtr cx);
        delegate IntPtr JS_GetGlobalForObjectDelegate(IntPtr aJSContext, IntPtr jsObject);
        delegate void JS_LeaveCompartmentDelegate(IntPtr cx, IntPtr oldCompartment);
        delegate bool JS_GetPropertyDelegate(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);
        delegate int JS_GetStringLengthDelegate(IntPtr jsString);
        delegate int JS_GetStringEncodingLengthDelegate(IntPtr cx, IntPtr jsString);
        delegate bool JS_HasPropertyDelegate(IntPtr cx, ref IntPtr jsObject, string name, [MarshalAs(UnmanagedType.U1)] out bool found);
        delegate JsVal JS_GetNegativeInfinityValueDelegate(IntPtr cx);
        delegate bool JS_GetPendingExceptionDelegate(IntPtr cx, ref MutableHandle handle);
        delegate IntPtr JS_NewContextDelegate(IntPtr runtime, int stacksize);
        delegate IntPtr JS_NewPlainObjectDelegate(IntPtr cx);
        delegate IntPtr JS_NewStringCopyNDelegate(IntPtr cx, string str, int length);
        delegate bool JS_SaveFrameChainDelegate(IntPtr jsContext);
        delegate void JS_SetCompartmentPrincipalsDelegate(IntPtr jsCompartment, IntPtr principals);
        delegate void JS_SetContextCallbackDelegate(IntPtr rt, JSContextCallback cb, IntPtr data);
        delegate void JS_SetContextPrivateDelegate(IntPtr context, IntPtr data);
        delegate JSErrorReportCallback JS_SetErrorReporterDelegate(IntPtr runtime, JSErrorReportCallback callback);
        delegate bool JS_SetPropertyDelegate(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);
        delegate void JS_SetTrustedPrincipalsDelegate(IntPtr runtime, IntPtr principals);
        delegate JSType JS_TypeOfValueDelegate(IntPtr cx, ref JsVal jsVal);
        delegate bool JS_ValueToObjectDelegate(IntPtr cx, ref JsVal jsValue, ref MutableHandle jsObject);
        delegate IntPtr JS_GetRuntimeDelegate(IntPtr context);
        delegate bool JS_WrapObjectDelegate(IntPtr cx, ref MutableHandle p);
        delegate IntPtr ToStringSlowDelegate(IntPtr cx, ref JsVal v);

        #endregion

        #region functions for compiler independent wrappers

        // Keep in alphabetical order.

        static CompileOptionsDelegate CompileOptionsFunc = Resolve<CompileOptionsDelegate>(CompileOptions_Win32, CompileOptions_Win64, CompileOptions_Linux32, CompileOptions_Linux64);
        static CurrentGlobalOrNullDelegate CurrentGlobalOrNullFunc = Resolve<CurrentGlobalOrNullDelegate>(CurrentGlobalOrNull_Win32, CurrentGlobalOrNull_Win64, CurrentGlobalOrNull_Linux32, CurrentGlobalOrNull_Linux64);
        static GetGlobalForObjectCrossCompartmentDelegate GetGlobalForObjectCrossCompartmentFunc = Resolve<GetGlobalForObjectCrossCompartmentDelegate>(GetGlobalForObjectCrossCompartment_Win32, GetGlobalForObjectCrossCompartment_Win64, GetGlobalForObjectCrossCompartment_Linux32, GetGlobalForObjectCrossCompartment_Linux64);
        static IsObjectInContextCompartmentDelegate IsObjectInContextCompartmentFunc = Resolve<IsObjectInContextCompartmentDelegate>(IsObjectInContextCompartment_Win32, IsObjectInContextCompartment_Win64, IsObjectInContextCompartment_Linux32, IsObjectInContextCompartment_Linux64);
        static JS_BeginRequestDelegate JS_BeginRequestFunc = Resolve<JS_BeginRequestDelegate>(JS_BeginRequest_Win32, JS_BeginRequest_Win64, JS_BeginRequest_Linux32, JS_BeginRequest_Linux64);
        static JS_CompileScriptDelegate JS_CompileScriptFunc = Resolve<JS_CompileScriptDelegate>(JS_CompileScript_Win32, JS_CompileScript_Win64, JS_CompileScript_Linux32, JS_CompileScript_Linux64);
        static JS_CallFunctionNameDelegateA JS_CallFunctionNameFuncA = Resolve<JS_CallFunctionNameDelegateA>(JS_CallFunctionName_Win32, JS_CallFunctionName_Win64, JS_CallFunctionName_Linux32, JS_CallFunctionName_Linux64);
        static JS_CallFunctionNameDelegateB JS_CallFunctionNameFuncB = Resolve<JS_CallFunctionNameDelegateB>(JS_CallFunctionName_Win32, JS_CallFunctionName_Win64, JS_CallFunctionName_Linux32, JS_CallFunctionName_Linux64);
        static JS_CallFunctionValueDelegate JS_CallFunctionValueFunc = Resolve<JS_CallFunctionValueDelegate>(JS_CallFunctionValue_Win32, JS_CallFunctionValue_Win64, JS_CallFunctionValue_Linux32, JS_CallFunctionValue_Linux64);
        static JS_EncodeStringDelegate JS_EncodeStringFunc = Resolve<JS_EncodeStringDelegate>(JS_EncodeString_Win32, JS_EncodeString_Win64, JS_EncodeString_Linux32, JS_EncodeString_Linux64);
        static JS_EncodeStringUTF8Delegate JS_EncodeStringUTF8Func = Resolve<JS_EncodeStringUTF8Delegate>(JS_EncodeStringUTF8_Win32, JS_EncodeStringUTF8_Win64, JS_EncodeStringUTF8_Linux32, JS_EncodeStringUTF8_Linux64);
        static JS_EndRequestDelegate JS_EndRequestFunc = Resolve<JS_EndRequestDelegate>(JS_EndRequest_Win32, JS_EndRequest_Win64, JS_EndRequest_Linux32, JS_EndRequest_Linux64);
        static JS_EnterCompartmentDelegate JS_EnterCompartmentFunc = Resolve<JS_EnterCompartmentDelegate>(JS_EnterCompartment_Win32, JS_EnterCompartment_Win64, JS_EnterCompartment_Linux32, JS_EnterCompartment_Linux64);
        static JS_ExecuteScriptDelegate JS_ExecuteScriptFunc = Resolve<JS_ExecuteScriptDelegate>(JS_ExecuteScript_Win32, JS_ExecuteScript_Win64, JS_ExecuteScript_Linux32, JS_ExecuteScript_Linux64);
        static JS_FreeDelegate JS_FreeFunc = Resolve<JS_FreeDelegate>(JS_Free_Win32, JS_Free_Win64, JS_Free_Linux32, JS_Free_Linux64);
        static JS_GetClassDelegate JS_GetClassFunc = Resolve<JS_GetClassDelegate>(JS_GetClass_Win32, JS_GetClass_Win64, JS_GetClass_Linux32, JS_GetClass_Linux64);
        static JS_GetClassObjectDelegate JS_GetClassObjectFunc = Resolve<JS_GetClassObjectDelegate>(JS_GetClassObject_Win32, JS_GetClassObject_Win64, JS_GetClassObject_Linux32, JS_GetClassObject_Linux64);
        static JS_GetCompartmentPrincipalsDelegate JS_GetCompartmentPrincipalsFunc = Resolve<JS_GetCompartmentPrincipalsDelegate>(JS_GetCompartmentPrincipals_Win32, JS_GetCompartmentPrincipals_Win64, JS_GetCompartmentPrincipals_Linux32, JS_GetCompartmentPrincipals_Linux64);
        static JS_ContextIteratorDelegate JS_ContextIteratorFunc = Resolve<JS_ContextIteratorDelegate>(JS_ContextIterator_Win32, JS_ContextIterator_Win64, JS_ContextIterator_Linux32, JS_ContextIterator_Linux64);
        static JS_GetContextPrivateDelegate JS_GetContextPrivateFunc = Resolve<JS_GetContextPrivateDelegate>(JS_GetContextPrivate_Win32, JS_GetContextPrivate_Win64, JS_GetContextPrivate_Linux32, JS_GetContextPrivate_Linux64);
        static JS_GetEmptyStringValueDelegate JS_GetEmptyStringValueFunc = Resolve<JS_GetEmptyStringValueDelegate>(JS_GetEmptyStringValue_Win32, JS_GetEmptyStringValue_Win64, JS_GetEmptyStringValue_Linux32, JS_GetEmptyStringValue_Linux64);
        static JS_GetGlobalForObjectDelegate JS_GetGlobalForObjectFunc = Resolve<JS_GetGlobalForObjectDelegate>(JS_GetGlobalForObject_Win32, JS_GetGlobalForObject_Win64, JS_GetGlobalForObject_Linux32, JS_GetGlobalForObject_Linux64);
        static JS_LeaveCompartmentDelegate JS_LeaveCompartmentFunc = Resolve<JS_LeaveCompartmentDelegate>(JS_LeaveCompartment_Win32, JS_LeaveCompartment_Win64, JS_LeaveCompartment_Linux32, JS_LeaveCompartment_Linux64);
        static JS_GetPropertyDelegate JS_GetPropertyFunc = Resolve<JS_GetPropertyDelegate>(JS_GetProperty_Win32, JS_GetProperty_Win64, JS_GetProperty_Linux32, JS_GetProperty_Linux64);
        static JS_GetStringLengthDelegate JS_GetStringLengthFunc = Resolve<JS_GetStringLengthDelegate>(JS_GetStringLength_Win32, JS_GetStringLength_Win64, JS_GetStringLength_Linux32, JS_GetStringLength_Linux64);
        static JS_GetStringEncodingLengthDelegate JS_GetStringEncodingLengthFunc = Resolve<JS_GetStringEncodingLengthDelegate>(JS_GetStringEncodingLength_Win32, JS_GetStringEncodingLength_Win64, JS_GetStringEncodingLength_Linux32, JS_GetStringEncodingLength_Linux64);
        static JS_HasPropertyDelegate JS_HasPropertyFunc = Resolve<JS_HasPropertyDelegate>(JS_HasProperty_Win32, JS_HasProperty_Win64, JS_HasProperty_Linux32, JS_HasProperty_Linux64);
        static JS_GetNegativeInfinityValueDelegate JS_GetNegativeInfinityValueFunc = Resolve<JS_GetNegativeInfinityValueDelegate>(JS_GetNegativeInfinityValue_Win32, JS_GetNegativeInfinityValue_Win64, JS_GetNegativeInfinityValue_Linux32, JS_GetNegativeInfinityValue_Linux64);
        static JS_GetPendingExceptionDelegate JS_GetPendingExceptionFunc = Resolve<JS_GetPendingExceptionDelegate>(JS_GetPendingException_Win32, JS_GetPendingException_Win64, JS_GetPendingException_Linux32, JS_GetPendingException_Linux64);
        static JS_NewContextDelegate JS_NewContextFunc = Resolve<JS_NewContextDelegate>(JS_NewContext_Win32, JS_NewContext_Win64, JS_NewContext_Linux32, JS_NewContext_Linux64);
        static JS_NewPlainObjectDelegate JS_NewPlainObjectFunc = Resolve<JS_NewPlainObjectDelegate>(JS_NewPlainObject_Win32, JS_NewPlainObject_Win64, JS_NewPlainObject_Linux32, JS_NewPlainObject_Linux64);
        static JS_NewStringCopyNDelegate JS_NewStringCopyNFunc = Resolve<JS_NewStringCopyNDelegate>(JS_NewStringCopyN_Win32, JS_NewStringCopyN_Win64, JS_NewStringCopyN_Linux32, JS_NewStringCopyN_Linux64);
        static JS_SaveFrameChainDelegate JS_SaveFrameChainFunc = Resolve<JS_SaveFrameChainDelegate>(JS_SaveFrameChain_Win32, JS_SaveFrameChain_Win64, JS_SaveFrameChain_Linux32, JS_SaveFrameChain_Linux64);
        static JS_SetCompartmentPrincipalsDelegate JS_SetCompartmentPrincipalsFunc = Resolve<JS_SetCompartmentPrincipalsDelegate>(JS_SetCompartmentPrincipals_Win32, JS_SetCompartmentPrincipals_Win64, JS_SetCompartmentPrincipals_Linux32, JS_SetCompartmentPrincipals_Linux64);
        static JS_SetContextCallbackDelegate JS_SetContextCallbackFunc = Resolve<JS_SetContextCallbackDelegate>(JS_SetContextCallback_Win32, JS_SetContextCallback_Win64, JS_SetContextCallback_Linux32, JS_SetContextCallback_Linux64);
        static JS_SetContextPrivateDelegate JS_SetContextPrivateFunc = Resolve<JS_SetContextPrivateDelegate>(JS_SetContextPrivate_Win32, JS_SetContextPrivate_Win64, JS_SetContextPrivate_Linux32, JS_SetContextPrivate_Linux64);
        static JS_SetErrorReporterDelegate JS_SetErrorReporterFunc = Resolve<JS_SetErrorReporterDelegate>(JS_SetErrorReporter_Win32, JS_SetErrorReporter_Win64, JS_SetErrorReporter_Linux32, JS_SetErrorReporter_Linux64);
        static JS_SetPropertyDelegate JS_SetPropertyFunc = Resolve<JS_SetPropertyDelegate>(JS_SetProperty_Win32, JS_SetProperty_Win64, JS_SetProperty_Linux32, JS_SetProperty_Linux64);
        static JS_SetTrustedPrincipalsDelegate JS_SetTrustedPrincipalsFunc = Resolve<JS_SetTrustedPrincipalsDelegate>(JS_SetTrustedPrincipals_Win32, JS_SetTrustedPrincipals_Win64, JS_SetTrustedPrincipals_Linux32, JS_SetTrustedPrincipals_Linux64);
        static JS_TypeOfValueDelegate JS_TypeOfValueFunc = Resolve<JS_TypeOfValueDelegate>(JS_TypeOfValue_Win32, JS_TypeOfValue_Win64, JS_TypeOfValue_Linux32, JS_TypeOfValue_Linux64);
        static JS_ValueToObjectDelegate JS_ValueToObjectFunc = Resolve<JS_ValueToObjectDelegate>(JS_ValueToObject_Win32, JS_ValueToObject_Win64, JS_ValueToObject_Linux32, JS_ValueToObject_Linux64);
        static JS_GetRuntimeDelegate JS_GetRuntimeFunc = Resolve<JS_GetRuntimeDelegate>(JS_GetRuntime_Win32, JS_GetRuntime_Win64, JS_GetRuntime_Linux32, JS_GetRuntime_Linux64);
        static JS_WrapObjectDelegate JS_WrapObjectFunc = Resolve<JS_WrapObjectDelegate>(JS_WrapObject_Win32, JS_WrapObject_Win64, JS_WrapObject_Linux32, JS_WrapObject_Linux64);
        static ToStringSlowDelegate ToStringSlowFunc = Resolve<ToStringSlowDelegate>(ToStringSlow_Win32, ToStringSlow_Win64, ToStringSlow_Linux32, ToStringSlow_Linux64);

        #endregion

        #region compiler independent wrappers

        // Keep in alphabetical order.

        public static IntPtr CurrentGlobalOrNull(IntPtr aJSContext)
        {
            return CurrentGlobalOrNullFunc(aJSContext);
        }

        public static IntPtr GetGlobalForObjectCrossCompartment(IntPtr jsObject)
        {
            return GetGlobalForObjectCrossCompartmentFunc(jsObject);
        }

        public static bool IsObjectInContextCompartment(IntPtr jsObject, IntPtr cx)
        {
            return IsObjectInContextCompartmentFunc(jsObject, cx);
        }

        public static IntPtr JS_BeginRequest(IntPtr cx)
        {
            return JS_BeginRequestFunc(cx);
        }

        /// <summary>
        /// JS_CallFunctionName without args
        /// </summary>
        /// <param name="cx"></param>
        /// <param name="jsObject"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static JsVal JS_CallFunctionName(IntPtr cx, IntPtr jsObject, string name)
        {
            bool result;
            JsVal value;
            int parameterCount = 0;
            var mutableHandle = new MutableHandleValue();
            if (!JS_CallFunctionNameFuncB(cx, ref jsObject, name, ref parameterCount, ref mutableHandle))
                throw new GeckoException(String.Format("Failed to call function {0}", name));

            value = JsVal.FromPtr(mutableHandle.Handle);
            result = true;

            if (!result)
                throw new GeckoException("Function does not exist!");
            return value;
        }

        public static JsVal JS_CallFunctionName(IntPtr cx, IntPtr jsObject, string name, JsVal[] args)
        {
            if ((args == null) || (args.Length == 0))
            {
                return JS_CallFunctionName(cx, jsObject, name);
            }

            bool result;
            JsVal value = default(JsVal);
            using (var argsArray = new HandleValueArray(args.Length, args))
            {               
                MutableHandleValue mutableHandle = new MutableHandleValue();
                result = JS_CallFunctionNameFuncA(cx, ref jsObject, name, argsArray.Ptr, ref mutableHandle);
                if (result)
                    value = JsVal.FromPtr(mutableHandle.Handle);
            }

            if (!result)
                throw new GeckoException("Function does not exist!");
            return value;
        }

        public static JsVal JS_CallFunctionValue(IntPtr cx, IntPtr jsObject, JsVal func)
        {
            var mutableHandle = new MutableHandleValue();
            bool success;
            using (var args = new HandleValueArray(0, new JsVal[0]))
                success = JS_CallFunctionValueFunc(cx, jsObject, ref func, args.Ptr, ref mutableHandle);
            if (success)
                return JsVal.FromPtr(mutableHandle.Handle);

            throw new GeckoException("failed to call function.");
        }

        public static IntPtr JS_EncodeString(IntPtr cx, IntPtr jsString)
        {
            return JS_EncodeStringFunc(cx, jsString);
        }

        public static IntPtr JS_EncodeStringToUTF8(IntPtr cx, IntPtr jsString)
        {
            return JS_EncodeStringUTF8Func(cx, ref jsString);
        }

        public static IntPtr JS_EndRequest(IntPtr cx)
        {
            return JS_EndRequestFunc(cx);
        }

        public static IntPtr JS_EnterCompartment(IntPtr cx, IntPtr obj)
        {
            JS_BeginRequest(cx);
            return JS_EnterCompartmentFunc(cx, obj);
        }       

        public static bool JS_ExecuteScript(IntPtr cx, string script, out JsVal jsval)
        {
            jsval = default(JsVal);
            var scriptHandle = new MutableHandle();
            if (!JS_CompileScriptFunc(cx, script, script.Length, GetCompileOptions(cx), ref scriptHandle))
                throw new GeckoException("Failed to compile script.");
            var val = new MutableHandleValue();
            var handle = scriptHandle.Handle;
            if (!JS_ExecuteScriptFunc(cx, ref handle, ref val))
                return false;

            jsval = JsVal.FromPtr(val.Handle);
            return true;
        }

        public static bool JS_EvaluateScript(IntPtr cx, string src, UInt32 length, string filename, UInt32 lineno,
            ref JsVal jsval)
        {
            src = EncodeUnicodeScript(src);
            if (cx == IntPtr.Zero)
                throw new ArgumentNullException("cx");

            return JS_ExecuteScript(cx, src, out jsval);
        }

        public static void JS_Free(IntPtr cx, IntPtr p)
        {
            JS_FreeFunc(cx, p);
        }

        public static IntPtr JS_GetClass(IntPtr obj)
        {
            return JS_GetClassFunc(obj);
        }

        public static IntPtr JS_GetClassObject(IntPtr context, IntPtr proto)
        {
            var m = new MutableHandle();
            JS_GetClassObjectFunc(context, proto, ref m);
            return m.Handle;
        }

        public static IntPtr JS_GetCompartmentPrincipals(IntPtr jsCompartment)
        {
            return JS_GetCompartmentPrincipalsFunc(jsCompartment);
        }

        public static IntPtr JS_ContextIterator(IntPtr rt, ref IntPtr iterp)
        {
            return JS_ContextIteratorFunc(rt, ref iterp);
        }

        /// <summary>
        /// This should return an nsISupport object if a option JSOPTION_PRIVATE_IS_NSISUPPORTS is set on the runtime.
        /// </summary>
        /// <param name="jsContext"></param>
        /// <returns></returns>
        public static IntPtr JS_GetContextPrivate(IntPtr jsContext)
        {
            return JS_GetContextPrivateFunc(jsContext);
        }

        public static JsVal JS_GetEmptyStringValue(IntPtr cx)
        {
            return JS_GetEmptyStringValueFunc(cx);
        }

        public static IntPtr JS_GetGlobalForObject(IntPtr jsContext, IntPtr jsObject)
        {
            return JS_GetGlobalForObjectFunc(jsContext, jsObject);
        }

        public static JsVal JS_GetProperty(IntPtr cx, IntPtr jsObject, string name)
        {
            bool success;
            var value = new JsVal();
            success = JS_GetPropertyFunc(cx, ref jsObject, name, ref value);
            if (!success)
                throw new GeckoException(String.Format("Could not get property. {0}", name));

            return value;
        }

        public static int JS_GetStringLength(IntPtr jsString)
        {
            return JS_GetStringLengthFunc(jsString);
        }

        public static int JS_GetStringEncodingLength(IntPtr cx, IntPtr jsString)
        {
            return JS_GetStringEncodingLengthFunc(cx, jsString);
        }

        public static bool JS_HasProperty(IntPtr cx, IntPtr jsObject, string name)
        {
            bool hasProperty;
            JS_HasPropertyFunc(cx, ref jsObject, name, out hasProperty);
            return hasProperty;
        }

        public static JsVal JS_GetNegativeInfinityValue(IntPtr cx)
        {
            return JS_GetNegativeInfinityValueFunc(cx);
        }

        public static IntPtr JS_GetPendingException(IntPtr cx)
        {
            var mutableHandle = new MutableHandle();
            return JS_GetPendingExceptionFunc(cx, ref mutableHandle) ? mutableHandle.Handle : IntPtr.Zero;
        }

        public static void JS_LeaveCompartment(IntPtr cx, IntPtr oldCompartment)
        {
            JS_LeaveCompartmentFunc(cx, oldCompartment);
            JS_EndRequest(cx);
        }

        public static IntPtr JS_NewContext(IntPtr runtime, int stackChunkSize)
        {
            return JS_NewContextFunc(runtime, stackChunkSize);
        }

        public static IntPtr JS_NewPlainObject(IntPtr cx)
        {
            return JS_NewPlainObjectFunc(cx);
        }

        public static IntPtr JS_NewStringCopyN(IntPtr cx, string str, int length)
        {
            return JS_NewStringCopyNFunc(cx, str, length);
        }

        public static bool JS_SaveFrameChain(IntPtr jsContext)
        {
            return JS_SaveFrameChainFunc(jsContext);
        }

        public static void JS_SetCompartmentPrincipals(IntPtr jsCompartment, IntPtr principals)
        {
            JS_SetCompartmentPrincipalsFunc(jsCompartment, principals);
        }

        public static JSContextCallback JS_SetContextCallback(IntPtr rt, JSContextCallback cb)
        {
            JS_SetContextCallbackFunc(rt, cb, IntPtr.Zero);
            return null;
        }

        public static void JS_SetContextPrivate(IntPtr jsContext, IntPtr data)
        {
            JS_SetContextPrivateFunc(jsContext, data);
        }

        public static JSErrorReportCallback JS_SetErrorReporter(IntPtr runtime, JSErrorReportCallback callback)
        {
            return JS_SetErrorReporterFunc(runtime, callback);
        }

        public static bool JS_SetProperty(IntPtr cx, IntPtr jsObject, string name, JsVal value)
        {
            return JS_SetPropertyFunc(cx, ref jsObject, name, ref value);
        }

        public static void JS_SetTrustedPrincipals(IntPtr runtime, IntPtr principals)
        {
            JS_SetTrustedPrincipalsFunc(runtime, principals);
        }

        public static JSType JS_TypeOfValue(IntPtr cx, JsVal jsVal)
        {
            return JS_TypeOfValueFunc(cx, ref jsVal);
        }

        public static IntPtr JS_ValueToObject(IntPtr cx, JsVal v)
        {
            var mutableHandle = new MutableHandle();
            JS_ValueToObjectFunc(cx, ref v, ref mutableHandle);
            return mutableHandle.Handle;
        }

        public static IntPtr JS_WrapObject(IntPtr cx, IntPtr jsObject)
        {
            var mh = new MutableHandle(jsObject);
            return JS_WrapObjectFunc(cx, ref mh) ? mh.Handle : IntPtr.Zero;
        }

        public static IntPtr ToStringSlow(IntPtr cx, JsVal v)
        {
            return ToStringSlowFunc(cx, ref v);
        }

        public static IntPtr JS_GetRuntime(IntPtr jsContext)
        {
            return JS_GetRuntimeFunc(jsContext);
        }

        #endregion

        #region delegates

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate JSBool JSContextCallback(IntPtr cx, UInt32 contextOp);

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate void JSErrorReportCallback(IntPtr cx, string message, IntPtr report);

        #endregion

        #region Helper Classes

        /// <summary>
        /// Converts a array of JsVal into Handle (Ptr) to ValueArray.
        /// </summary>
        private class HandleValueArray : IDisposable
        {
            public HandleValueArray(int length, JsVal[] args)
            {
                _length = length;
                _args = args;
            }

            private int _length;
            private JsVal[] _args;
            private IntPtr _ptr;

            public IntPtr Ptr
            {
                get
                {
                    if (_ptr == IntPtr.Zero)
                        _ptr = CopyToNativeMemory();

                    return _ptr;
                }
            }

            /// <summary>
            /// Allocates enough memory for contents of HandleValueArray.
            /// and copies content across.
            /// Must call FreeNativeMemory on the returned pointer.
            /// </summary>
            /// <returns></returns>
            private IntPtr CopyToNativeMemory()
            {
                // Length is 4 bytes on 32bit systems and 8 bytes on 64bit systems.
                IntPtr ptr = Marshal.AllocCoTaskMem(IntPtr.Size + IntPtr.Size);
                Marshal.WriteIntPtr(ptr, 0, new IntPtr(_length));
                IntPtr arrayPtr = Marshal.AllocCoTaskMem(8 * _length);
                Marshal.WriteIntPtr(ptr, IntPtr.Size, arrayPtr);
                for (int i = 0; i < _length; i++)
                    Marshal.StructureToPtr(_args[i], new IntPtr(arrayPtr.ToInt64() + (i * 8)), true);

                return ptr;
            }

            private void FreeNativeMemory(IntPtr ptr)
            {
                var p = Marshal.ReadIntPtr(ptr, IntPtr.Size);
                Marshal.FreeCoTaskMem(p);
                Marshal.FreeCoTaskMem(ptr);
            }

            public void Dispose()
            {
                if (_ptr != IntPtr.Zero)
                    FreeNativeMemory(_ptr);
                _length = -1;
            }
        }

        #endregion

        #region helper methods

        private static string EncodeUnicodeScript(string script)
        {
            int i;
            for (i = 0; i < script.Length && script[i] < 128; i++) ;
            if (i == script.Length)
                return script;
            var sb = new System.Text.StringBuilder();
            if (i > 0)
                sb.Append(script.Substring(0, i));
            for (; i < script.Length; i++)
            {
                char c = script[i];
                if (c < 128)
                    sb.Append(c);
                else
                {
                    sb.Append("\\u");
                    sb.Append(((int) c).ToString("X4"));
                }
            }
            return sb.ToString();
        }

        private static Dictionary<IntPtr, IntPtr> ContextToCompileOptionsMap = new Dictionary<IntPtr, IntPtr>();

        private static IntPtr GetCompileOptions(IntPtr context)
        {
            IntPtr compileOptions;
            if (!ContextToCompileOptionsMap.TryGetValue(context, out compileOptions))
            {
                IntPtr block = Marshal.AllocCoTaskMem(160);
                CompileOptionsFunc(block, context, 0);
                ContextToCompileOptionsMap[context] = compileOptions = block;
            }

            return compileOptions;
        }

        #endregion

        #region Windows x86

        // These should be in Alphabetical order.

        [DllImport("xul", CallingConvention = CallingConvention.ThisCall, CharSet = CharSet.Ansi, ExactSpelling = false,
            EntryPoint = "??0CompileOptions@JS@@QAE@PAUJSContext@@W4JSVersion@@@Z")]
        private static extern IntPtr CompileOptions_Win32(IntPtr @this, IntPtr cx, int jsver);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?CurrentGlobalOrNull@JS@@YAPAVJSObject@@PAUJSContext@@@Z")]
        private static extern IntPtr CurrentGlobalOrNull_Win32(IntPtr aJSContext);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?GetGlobalForObjectCrossCompartment@js@@YAPAVJSObject@@PAV2@@Z")]
        private static extern IntPtr GetGlobalForObjectCrossCompartment_Win32(IntPtr jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?IsObjectInContextCompartment@js@@YA_NPAVJSObject@@PBUJSContext@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool IsObjectInContextCompartment_Win32(IntPtr jsObject, IntPtr context);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_BeginRequest@@YAXPAUJSContext@@@Z")]
        private static extern IntPtr JS_BeginRequest_Win32(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = false,
            EntryPoint =
                "?JS_CompileScript@@YA_NPAUJSContext@@PBDIABVCompileOptions@JS@@V?$MutableHandle@PAVJSScript@@@3@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CompileScript_Win32(IntPtr cx, string str, int strlen, IntPtr compileOptions,
            ref MutableHandle jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
                "?JS_CallFunctionName@@YA_NPAUJSContext@@V?$Handle@PAVJSObject@@@JS@@PBDABVHandleValueArray@3@V?$MutableHandle@VValue@JS@@@3@@Z"
            )]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CallFunctionName_Win32(IntPtr cx, ref IntPtr jsObject, string name, IntPtr data,
            ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
                "?JS_CallFunctionName@@YA_NPAUJSContext@@V?$Handle@PAVJSObject@@@JS@@PBDABVHandleValueArray@3@V?$MutableHandle@VValue@JS@@@3@@Z"
            )]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CallFunctionName_Win32(IntPtr cx, ref IntPtr jsObject, string name, ref int args,
            ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
                "?JS_CallFunctionValue@@YA_NPAUJSContext@@V?$Handle@PAVJSObject@@@JS@@V?$Handle@VValue@JS@@@3@ABVHandleValueArray@3@V?$MutableHandle@VValue@JS@@@3@@Z"
            )]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CallFunctionValue_Win32(IntPtr cx, IntPtr jsObject, ref JsVal fval,
            IntPtr passZero, ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_EncodeString@@YAPADPAUJSContext@@PAVJSString@@@Z")]
        private static extern IntPtr JS_EncodeString_Win32(IntPtr cx, IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_EncodeStringToUTF8@@YAPADPAUJSContext@@V?$Handle@PAVJSString@@@JS@@@Z")]
        private static extern IntPtr JS_EncodeStringUTF8_Win32(IntPtr cx, ref IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_EndRequest@@YAXPAUJSContext@@@Z")]
        private static extern IntPtr JS_EndRequest_Win32(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_EnterCompartment@@YAPAUJSCompartment@@PAUJSContext@@PAVJSObject@@@Z")]
        private static extern IntPtr JS_EnterCompartment_Win32(IntPtr cx, IntPtr obj);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
                "?JS_ExecuteScript@@YA_NPAUJSContext@@V?$Handle@PAVJSScript@@@JS@@V?$MutableHandle@VValue@JS@@@3@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_ExecuteScript_Win32(IntPtr cx, ref IntPtr handleScript,
            ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_free@@YAXPAUJSContext@@PAX@Z")]
        private static extern void JS_Free_Win32(IntPtr cx, IntPtr p);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetClass@@YAPBUJSClass@@PAVJSObject@@@Z")]
        private static extern IntPtr JS_GetClass_Win32(IntPtr obj);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetClassObject@@YA_NPAUJSContext@@W4JSProtoKey@@V?$MutableHandle@PAVJSObject@@@JS@@@Z")]
        private static extern IntPtr JS_GetClassObject_Win32(IntPtr context, IntPtr proto, ref MutableHandle jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetCompartmentPrincipals@@YAPAUJSPrincipals@@PAUJSCompartment@@@Z")]
        private static extern IntPtr JS_GetCompartmentPrincipals_Win32(IntPtr jsCompartment);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_ContextIterator@@YAPAUJSContext@@PAUJSRuntime@@PAPAU1@@Z")]
        private static extern IntPtr JS_ContextIterator_Win32(IntPtr rt, ref IntPtr iterp);

        // if JSOPTION_PRIVATE_IS_NSISUPPORTS is set on the runtime then ContextPrivate should contain the nsISupports object.
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetContextPrivate@@YAPAXPAUJSContext@@@Z")]
        private static extern IntPtr JS_GetContextPrivate_Win32(IntPtr context);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetEmptyStringValue@@YA?AVValue@JS@@PAUJSContext@@@Z")]
        private static extern JsVal JS_GetEmptyStringValue_Win32(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetGlobalForObject@@YAPAVJSObject@@PAUJSContext@@PAV1@@Z")]
        private static extern IntPtr JS_GetGlobalForObject_Win32(IntPtr aJSContext, IntPtr jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_LeaveCompartment@@YAXPAUJSContext@@PAUJSCompartment@@@Z")]
        private static extern void JS_LeaveCompartment_Win32(IntPtr cx, IntPtr oldCompartment);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
                "?JS_GetProperty@@YA_NPAUJSContext@@V?$Handle@PAVJSObject@@@JS@@PBDV?$MutableHandle@VValue@JS@@@3@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_GetProperty_Win32(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetStringLength@@YAIPAVJSString@@@Z")]
        private static extern int JS_GetStringLength_Win32(IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetStringEncodingLength@@YAIPAUJSContext@@PAVJSString@@@Z")]
        private static extern int JS_GetStringEncodingLength_Win32(IntPtr cx, IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_HasProperty@@YA_NPAUJSContext@@V?$Handle@PAVJSObject@@@JS@@PBDPA_N@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_HasProperty_Win32(IntPtr cx, ref IntPtr jsObject, string name,
            [MarshalAs(UnmanagedType.U1)] out bool found);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetNegativeInfinityValue@@YA?AVValue@JS@@PAUJSContext@@@Z")]
        private static extern JsVal JS_GetNegativeInfinityValue_Win32(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetPendingException@@YA_NPAUJSContext@@V?$MutableHandle@VValue@JS@@@JS@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_GetPendingException_Win32(IntPtr cx, ref MutableHandle handle);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_NewContext@@YAPAUJSContext@@PAUJSRuntime@@I@Z")]
        private static extern IntPtr JS_NewContext_Win32(IntPtr runtime, int stacksize);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_NewPlainObject@@YAPAVJSObject@@PAUJSContext@@@Z")]
        private static extern IntPtr JS_NewPlainObject_Win32(IntPtr cx);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_NewStringCopyN@@YAPAVJSString@@PAUJSContext@@PBDI@Z")]
        private static extern IntPtr JS_NewStringCopyN_Win32(IntPtr cx, string str, int length);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_SaveFrameChain@@YA_NPAUJSContext@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_SaveFrameChain_Win32(IntPtr jsContext);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_SetCompartmentPrincipals@@YAXPAUJSCompartment@@PAUJSPrincipals@@@Z")]
        private static extern void JS_SetCompartmentPrincipals_Win32(IntPtr jsCompartment, IntPtr principals);

        /// <summary>
        /// declaration in jsapi.h
        /// extern JS_PUBLIC_API(JSContextCallback) JS_SetContextCallback(JSRuntime *rt, JSContextCallback cxCallback);
        /// </summary>
        /// <param name="rt"></param>
        /// <param name="cb"></param>
        /// <returns></returns>
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_SetContextCallback@@YAXPAUJSRuntime@@P6A_NPAUJSContext@@IPAX@Z2@Z")]
        private static extern void JS_SetContextCallback_Win32(IntPtr rt, JSContextCallback cb, IntPtr data);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_SetContextPrivate@@YAXPAUJSContext@@PAX@Z")]
        private static extern void JS_SetContextPrivate_Win32(IntPtr context, IntPtr data);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_SetErrorReporter@@YAP6AXPAUJSContext@@PBDPAVJSErrorReport@@@ZPAUJSRuntime@@P6AX012@Z@Z")]
        private static extern JSErrorReportCallback JS_SetErrorReporter_Win32(IntPtr runtime,
            JSErrorReportCallback callback);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_SetProperty@@YA_NPAUJSContext@@V?$Handle@PAVJSObject@@@JS@@PBDV?$Handle@VValue@JS@@@3@@Z")
        ]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_SetProperty_Win32(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_SetTrustedPrincipals@@YAXPAUJSRuntime@@PAUJSPrincipals@@@Z")]
        private static extern void JS_SetTrustedPrincipals_Win32(IntPtr runtime, IntPtr principals);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_TypeOfValue@@YA?AW4JSType@@PAUJSContext@@V?$Handle@VValue@JS@@@JS@@@Z")]
        private static extern JSType JS_TypeOfValue_Win32(IntPtr cx, ref JsVal jsVal);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
                "?JS_ValueToObject@@YA_NPAUJSContext@@V?$Handle@VValue@JS@@@JS@@V?$MutableHandle@PAVJSObject@@@3@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_ValueToObject_Win32(IntPtr cx, ref JsVal jsValue, ref MutableHandle jsObject);       

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetRuntime@@YAPAUJSRuntime@@PAUJSContext@@@Z")]
        private static extern IntPtr JS_GetRuntime_Win32(IntPtr context);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_WrapObject@@YA_NPAUJSContext@@V?$MutableHandle@PAVJSObject@@@JS@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_WrapObject_Win32(IntPtr cx, ref MutableHandle p);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "?ToStringSlow@js@@YAPAVJSString@@PAUJSContext@@V?$Handle@VValue@JS@@@JS@@@Z")]
        private static extern IntPtr ToStringSlow_Win32(IntPtr cx, ref JsVal v);

        #endregion

        #region Windows x64

        // These should be in Alphabetical order.

        [DllImport("xul", CallingConvention = CallingConvention.ThisCall, CharSet = CharSet.Ansi, ExactSpelling = false,
            EntryPoint = "??0CompileOptions@JS@@QEAA@PEAUJSContext@@W4JSVersion@@@Z")]
        private static extern IntPtr CompileOptions_Win64(IntPtr @this, IntPtr cx, int jsver);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?CurrentGlobalOrNull@JS@@YAPEAVJSObject@@PEAUJSContext@@@Z")]
        private static extern IntPtr CurrentGlobalOrNull_Win64(IntPtr aJSContext);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?GetGlobalForObjectCrossCompartment@js@@YAPEAVJSObject@@PEAV2@@Z")]
        private static extern IntPtr GetGlobalForObjectCrossCompartment_Win64(IntPtr jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?IsObjectInContextCompartment@js@@YA_NPEAVJSObject@@PEBUJSContext@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool IsObjectInContextCompartment_Win64(IntPtr jsObject, IntPtr context);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_BeginRequest@@YAXPEAUJSContext@@@Z")]
        private static extern IntPtr JS_BeginRequest_Win64(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = false,
            EntryPoint =
                "?JS_CompileScript@@YA_NPEAUJSContext@@PEBD_KAEBVCompileOptions@JS@@V?$MutableHandle@PEAVJSScript@@@3@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CompileScript_Win64(IntPtr cx, string str, int strlen, IntPtr compileOptions,
            ref MutableHandle jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
                "?JS_CallFunctionName@@YA_NPEAUJSContext@@V?$Handle@PEAVJSObject@@@JS@@PEBDAEBVHandleValueArray@3@V?$MutableHandle@VValue@JS@@@3@@Z"
            )]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CallFunctionName_Win64(IntPtr cx, ref IntPtr jsObject, string name, IntPtr data,
            ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
                "?JS_CallFunctionName@@YA_NPEAUJSContext@@V?$Handle@PEAVJSObject@@@JS@@PEBDAEBVHandleValueArray@3@V?$MutableHandle@VValue@JS@@@3@@Z"
            )]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CallFunctionName_Win64(IntPtr cx, ref IntPtr jsObject, string name, ref int args,
            ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
                "?JS_CallFunctionValue@@YA_NPEAUJSContext@@V?$Handle@PEAVJSObject@@@JS@@V?$Handle@VValue@JS@@@3@AEBVHandleValueArray@3@V?$MutableHandle@VValue@JS@@@3@@Z"
            )]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CallFunctionValue_Win64(IntPtr cx, IntPtr jsObject, ref JsVal fval,
            IntPtr passZero, ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_EncodeString@@YAPEADPEAUJSContext@@PEAVJSString@@@Z")]
        private static extern IntPtr JS_EncodeString_Win64(IntPtr cx, IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_EncodeStringToUTF8@@YAPEADPEAUJSContext@@V?$Handle@PEAVJSString@@@JS@@@Z")]
        private static extern IntPtr JS_EncodeStringUTF8_Win64(IntPtr cx, ref IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_EndRequest@@YAXPEAUJSContext@@@Z")]
        private static extern IntPtr JS_EndRequest_Win64(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_EnterCompartment@@YAPEAUJSCompartment@@PEAUJSContext@@PEAVJSObject@@@Z")]
        private static extern IntPtr JS_EnterCompartment_Win64(IntPtr cx, IntPtr obj);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
                "?JS_ExecuteScript@@YA_NPEAUJSContext@@AEAV?$AutoVectorRooter@PEAVJSObject@@@JS@@V?$Handle@PEAVJSScript@@@3@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_ExecuteScript_Win64(IntPtr cx, ref IntPtr handleScript,
            ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_free@@YAXPEAUJSContext@@PEAX@Z")]
        private static extern void JS_Free_Win64(IntPtr cx, IntPtr p);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetClass@@YAPEBUJSClass@@PEAVJSObject@@@Z")]
        private static extern IntPtr JS_GetClass_Win64(IntPtr obj);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetClassObject@@YA_NPEAUJSContext@@W4JSProtoKey@@V?$MutableHandle@PEAVJSObject@@@JS@@@Z")]
        private static extern IntPtr JS_GetClassObject_Win64(IntPtr context, IntPtr proto, ref MutableHandle jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetCompartmentPrincipals@@YAPEAUJSPrincipals@@PEAUJSCompartment@@@Z")]
        private static extern IntPtr JS_GetCompartmentPrincipals_Win64(IntPtr jsCompartment);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_ContextIterator@@YAPEAUJSContext@@PEAUJSRuntime@@PEAPEAU1@@Z")]
        private static extern IntPtr JS_ContextIterator_Win64(IntPtr rt, ref IntPtr iterp);

        // if JSOPTION_PRIVATE_IS_NSISUPPORTS is set on the runtime then ContextPrivate should contain the nsISupports object.
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetContextPrivate@@YAPEAXPEAUJSContext@@@Z")]
        private static extern IntPtr JS_GetContextPrivate_Win64(IntPtr context);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetEmptyStringValue@@YA?AVValue@JS@@PEAUJSContext@@@Z")]
        private static extern JsVal JS_GetEmptyStringValue_Win64(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetGlobalForObject@@YAPEAVJSObject@@PEAUJSContext@@PEAV1@@Z")]
        private static extern IntPtr JS_GetGlobalForObject_Win64(IntPtr aJSContext, IntPtr jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_LeaveCompartment@@YAXPEAUJSContext@@PEAUJSCompartment@@@Z")]
        private static extern void JS_LeaveCompartment_Win64(IntPtr cx, IntPtr oldCompartment);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
                "?JS_GetProperty@@YA_NPEAUJSContext@@V?$Handle@PEAVJSObject@@@JS@@PEBDV?$MutableHandle@VValue@JS@@@3@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_GetProperty_Win64(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetStringLength@@YA_KPEAVJSString@@@Z")]
        private static extern int JS_GetStringLength_Win64(IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetStringEncodingLength@@YA_KPEAUJSContext@@PEAVJSString@@@Z")]
        private static extern int JS_GetStringEncodingLength_Win64(IntPtr cx, IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_HasProperty@@YA_NPEAUJSContext@@V?$Handle@PEAVJSObject@@@JS@@PEBDPEA_N@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_HasProperty_Win64(IntPtr cx, ref IntPtr jsObject, string name,
            [MarshalAs(UnmanagedType.U1)] out bool found);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetNegativeInfinityValue@@YA?AVValue@JS@@PEAUJSContext@@@Z")]
        private static extern JsVal JS_GetNegativeInfinityValue_Win64(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetPendingException@@YA_NPEAUJSContext@@V?$MutableHandle@VValue@JS@@@JS@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_GetPendingException_Win64(IntPtr cx, ref MutableHandle handle);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_NewContext@@YAPEAUJSContext@@PEAUJSRuntime@@_K@Z")]
        private static extern IntPtr JS_NewContext_Win64(IntPtr runtime, int stacksize);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_NewPlainObject@@YAPEAVJSObject@@PEAUJSContext@@@Z")]
        private static extern IntPtr JS_NewPlainObject_Win64(IntPtr cx);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_NewStringCopyN@@YAPEAVJSString@@PEAUJSContext@@PEBD_K@Z")]
        private static extern IntPtr JS_NewStringCopyN_Win64(IntPtr cx, string str, int length);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_SaveFrameChain@@YA_NPEAUJSContext@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_SaveFrameChain_Win64(IntPtr jsContext);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_SetCompartmentPrincipals@@YAXPEAUJSCompartment@@PEAUJSPrincipals@@@Z")]
        private static extern void JS_SetCompartmentPrincipals_Win64(IntPtr jsCompartment, IntPtr principals);

        /// <summary>
        /// declaration in jsapi.h
        /// extern JS_PUBLIC_API(JSContextCallback) JS_SetContextCallback(JSRuntime *rt, JSContextCallback cxCallback);
        /// </summary>
        /// <param name="rt"></param>
        /// <param name="cb"></param>
        /// <returns></returns>
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_SetContextCallback@@YAXPEAUJSRuntime@@P6A_NPEAUJSContext@@IPEAX@Z2@Z")]
        private static extern void JS_SetContextCallback_Win64(IntPtr rt, JSContextCallback cb, IntPtr data);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_SetContextPrivate@@YAXPEAUJSContext@@PEAX@Z")]
        private static extern void JS_SetContextPrivate_Win64(IntPtr context, IntPtr data);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_SetErrorReporter@@YAP6AXPEAUJSContext@@PEBDPEAVJSErrorReport@@@ZPEAUJSRuntime@@P6AX012@Z@Z")]
        private static extern JSErrorReportCallback JS_SetErrorReporter_Win64(IntPtr runtime,
            JSErrorReportCallback callback);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_SetProperty@@YA_NPEAUJSContext@@V?$Handle@PEAVJSObject@@@JS@@PEBDV?$Handle@VValue@JS@@@3@@Z")
        ]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_SetProperty_Win64(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_SetTrustedPrincipals@@YAXPEAUJSRuntime@@PEAUJSPrincipals@@@Z")]
        private static extern void JS_SetTrustedPrincipals_Win64(IntPtr runtime, IntPtr principals);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_TypeOfValue@@YA?AW4JSType@@PEAUJSContext@@V?$Handle@VValue@JS@@@JS@@@Z")]
        private static extern JSType JS_TypeOfValue_Win64(IntPtr cx, ref JsVal jsVal);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
                "?JS_ValueToObject@@YA_NPEAUJSContext@@V?$Handle@VValue@JS@@@JS@@V?$MutableHandle@PEAVJSObject@@@3@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_ValueToObject_Win64(IntPtr cx, ref JsVal jsValue, ref MutableHandle jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_GetRuntime@@YAPEAUJSRuntime@@PEAUJSContext@@@Z")]
        private static extern IntPtr JS_GetRuntime_Win64(IntPtr context);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "?JS_WrapObject@@YA_NPEAUJSContext@@V?$MutableHandle@PEAVJSObject@@@JS@@@Z")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_WrapObject_Win64(IntPtr cx, ref MutableHandle p);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "?ToStringSlow@js@@YAPEAVJSString@@PEAUJSContext@@V?$Handle@VValue@JS@@@JS@@@Z")]
        private static extern IntPtr ToStringSlow_Win64(IntPtr cx, ref JsVal v);

        #endregion

        #region Linux x86

        // These should be in Alphabetical order.

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = false,
                   EntryPoint = "_ZN2JS14CompileOptionsC2EP9JSContext9JSVersion")]
        private static extern IntPtr CompileOptions_Linux32(IntPtr @this, IntPtr cx, int jsver);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_ZN2JS19CurrentGlobalOrNullEP9JSContext")]
        private static extern IntPtr CurrentGlobalOrNull_Linux32(IntPtr aJSContext);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_ZN2js34GetGlobalForObjectCrossCompartmentEP8JSObject")]
        private static extern IntPtr GetGlobalForObjectCrossCompartment_Linux32(IntPtr jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_ZN2js28IsObjectInContextCompartmentEP8JSObjectPK9JSContext")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool IsObjectInContextCompartment_Linux32(IntPtr jsObject, IntPtr context);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z15JS_BeginRequestP9JSContext")]
        private static extern IntPtr JS_BeginRequest_Linux32(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = false,
                   EntryPoint =
                   "_Z16JS_CompileScriptP9JSContextPKcjRKN2JS14CompileOptionsENS3_13MutableHandleIP8JSScriptEE")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CompileScript_Linux32(IntPtr cx, string str, int strlen, IntPtr compileOptions,
                                                            ref MutableHandle jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint =
                   "_Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE"
                   )]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CallFunctionName_Linux32(IntPtr cx, ref IntPtr jsObject, string name, IntPtr data,
                                                               ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint =
                   "_Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE"
                   )]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CallFunctionName_Linux32(IntPtr cx, ref IntPtr jsObject, string name, ref int args,
                                                               ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint =
                   "_Z20JS_CallFunctionValueP9JSContextN2JS6HandleIP8JSObjectEENS2_INS1_5ValueEEERKNS1_16HandleValueArrayENS1_13MutableHandleIS6_EE"
                   )]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CallFunctionValue_Linux32(IntPtr cx, IntPtr jsObject, ref JsVal fval,
                                                                IntPtr passZero, ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z15JS_EncodeStringP9JSContextP8JSString")]
        private static extern IntPtr JS_EncodeString_Linux32(IntPtr cx, IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z21JS_EncodeStringToUTF8P9JSContextN2JS6HandleIP8JSStringEE")]
        private static extern IntPtr JS_EncodeStringUTF8_Linux32(IntPtr cx, ref IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z13JS_EndRequestP9JSContext")]
        private static extern IntPtr JS_EndRequest_Linux32(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z19JS_EnterCompartmentP9JSContextP8JSObject")]
        private static extern IntPtr JS_EnterCompartment_Linux32(IntPtr cx, IntPtr obj);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint =
                   "_Z16JS_ExecuteScriptP9JSContextN2JS6HandleIP8JSScriptEENS1_13MutableHandleINS1_5ValueEEE")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_ExecuteScript_Linux32(IntPtr cx, ref IntPtr handleScript,
                                                            ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z7JS_freeP9JSContextPv")]
        private static extern void JS_Free_Linux32(IntPtr cx, IntPtr p);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z11JS_GetClassP8JSObject")]
        private static extern IntPtr JS_GetClass_Linux32(IntPtr obj);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z17JS_GetClassObjectP9JSContext10JSProtoKeyN2JS13MutableHandleIP8JSObjectEE")]
        private static extern IntPtr JS_GetClassObject_Linux32(IntPtr context, IntPtr proto, ref MutableHandle jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z27JS_GetCompartmentPrincipalsP13JSCompartment")]
        private static extern IntPtr JS_GetCompartmentPrincipals_Linux32(IntPtr jsCompartment);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z18JS_ContextIteratorP9JSRuntimePP9JSContext")]
        private static extern IntPtr JS_ContextIterator_Linux32(IntPtr rt, ref IntPtr iterp);

        // if JSOPTION_PRIVATE_IS_NSISUPPORTS is set on the runtime then ContextPrivate should contain the nsISupports object.
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z20JS_GetContextPrivateP9JSContext")]
        private static extern IntPtr JS_GetContextPrivate_Linux32(IntPtr context);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z22JS_GetEmptyStringValueP9JSContext")]
        private static extern JsVal JS_GetEmptyStringValue_Linux32(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z21JS_GetGlobalForObjectP9JSContextP8JSObject")]
        private static extern IntPtr JS_GetGlobalForObject_Linux32(IntPtr aJSContext, IntPtr jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z19JS_LeaveCompartmentP9JSContextP13JSCompartment")]
        private static extern void JS_LeaveCompartment_Linux32(IntPtr cx, IntPtr oldCompartment);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint =
                   "_Z14JS_GetPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcNS1_13MutableHandleINS1_5ValueEEE")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_GetProperty_Linux32(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z18JS_GetStringLengthP8JSString")]
        private static extern int JS_GetStringLength_Linux32(IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z26JS_GetStringEncodingLengthP9JSContextP8JSString")]
        private static extern int JS_GetStringEncodingLength_Linux32(IntPtr cx, IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z14JS_HasPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcPb")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_HasProperty_Linux32(IntPtr cx, ref IntPtr jsObject, string name,
                                                          [MarshalAs(UnmanagedType.U1)] out bool found);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z27JS_GetNegativeInfinityValueP9JSContext")]
        private static extern JsVal JS_GetNegativeInfinityValue_Linux32(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z22JS_GetPendingExceptionP9JSContextN2JS13MutableHandleINS1_5ValueEEE")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_GetPendingException_Linux32(IntPtr cx, ref MutableHandle handle);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z13JS_NewContextP9JSRuntimej")]
        private static extern IntPtr JS_NewContext_Linux32(IntPtr runtime, int stacksize);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z17JS_NewPlainObjectP9JSContext")]
        private static extern IntPtr JS_NewPlainObject_Linux32(IntPtr cx);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "NewStringCopyNP9JSContextPKcj")]
        private static extern IntPtr JS_NewStringCopyN_Linux32(IntPtr cx, string str, int length);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z17JS_SaveFrameChainP9JSContext")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_SaveFrameChain_Linux32(IntPtr jsContext);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z27JS_SetCompartmentPrincipalsP13JSCompartmentP12JSPrincipals")]
        private static extern void JS_SetCompartmentPrincipals_Linux32(IntPtr jsCompartment, IntPtr principals);

        /// <summary>
        /// declaration in jsapi.h
        /// extern JS_PUBLIC_API(JSContextCallback) JS_SetContextCallback(JSRuntime *rt, JSContextCallback cxCallback);
        /// </summary>
        /// <param name="rt"></param>
        /// <param name="cb"></param>
        /// <returns></returns>
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z21JS_SetContextCallbackP9JSRuntimePFbP9JSContextjPvES3_")]
        private static extern void JS_SetContextCallback_Linux32(IntPtr rt, JSContextCallback cb, IntPtr data);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z20JS_SetContextPrivateP9JSContextPv")]
        private static extern void JS_SetContextPrivate_Linux32(IntPtr context, IntPtr data);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z19JS_SetErrorReporterP9JSRuntimePFvP9JSContextPKcP13JSErrorReportE")]
        private static extern JSErrorReportCallback JS_SetErrorReporter_Linux32(IntPtr runtime,
                                                                                JSErrorReportCallback callback);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z14JS_SetPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcNS2_INS1_5ValueEEE")
         ]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_SetProperty_Linux32(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z23JS_SetTrustedPrincipalsP9JSRuntimeP12JSPrincipals")]
        private static extern void JS_SetTrustedPrincipals_Linux32(IntPtr runtime, IntPtr principals);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z14JS_TypeOfValueP9JSContextN2JS6HandleINS1_5ValueEEE")]
        private static extern JSType JS_TypeOfValue_Linux32(IntPtr cx, ref JsVal jsVal);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint =
                   "_Z16JS_ValueToObjectP9JSContextN2JS6HandleINS1_5ValueEEENS1_13MutableHandleIP8JSObjectEE")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_ValueToObject_Linux32(IntPtr cx, ref JsVal jsValue, ref MutableHandle jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z13JS_GetRuntimeP9JSContext")]
        private static extern IntPtr JS_GetRuntime_Linux32(IntPtr context);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_Z13JS_WrapObjectP9JSContextN2JS13MutableHandleIP8JSObjectEE")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_WrapObject_Linux32(IntPtr cx, ref MutableHandle p);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
                   EntryPoint = "_ZN2js12ToStringSlowEP9JSContextN2JS6HandleINS2_5ValueEEE")]
        private static extern IntPtr ToStringSlow_Linux32(IntPtr cx, ref JsVal v);

        #endregion

        #region Linux x64

        // These should be in Alphabetical order.

        [DllImport("xul", CallingConvention = CallingConvention.ThisCall, CharSet = CharSet.Ansi, ExactSpelling = false,
           EntryPoint = "_ZN2JS14CompileOptionsC2EP9JSContext9JSVersion")]
        private static extern IntPtr CompileOptions_Linux64(IntPtr @this, IntPtr cx, int jsver);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_ZN2JS19CurrentGlobalOrNullEP9JSContext")]
        private static extern IntPtr CurrentGlobalOrNull_Linux64(IntPtr aJSContext);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_ZN2js34GetGlobalForObjectCrossCompartmentEP8JSObject")]
        private static extern IntPtr GetGlobalForObjectCrossCompartment_Linux64(IntPtr jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_ZN2js28IsObjectInContextCompartmentEP8JSObjectPK9JSContext")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool IsObjectInContextCompartment_Linux64(IntPtr jsObject, IntPtr context);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "_Z15JS_BeginRequestP9JSContext")]
        private static extern IntPtr JS_BeginRequest_Linux64(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = false,
            EntryPoint =
                   "_Z16JS_CompileScriptP9JSContextPKcmRKN2JS14CompileOptionsENS3_13MutableHandleIP8JSScriptEE")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CompileScript_Linux64(IntPtr cx, string str, int strlen, IntPtr compileOptions,
            ref MutableHandle jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
                   "_Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE"
            )]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CallFunctionName_Linux64(IntPtr cx, ref IntPtr jsObject, string name, IntPtr data,
            ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
                   "_Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE"
            )]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CallFunctionName_Linux64(IntPtr cx, ref IntPtr jsObject, string name, ref int args,
            ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
                   "_Z20JS_CallFunctionValueP9JSContextN2JS6HandleIP8JSObjectEENS2_INS1_5ValueEEERKNS1_16HandleValueArrayENS1_13MutableHandleIS6_EE"
            )]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CallFunctionValue_Linux64(IntPtr cx, IntPtr jsObject, ref JsVal fval,
            IntPtr passZero, ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z15JS_EncodeStringP9JSContextP8JSString")]
        private static extern IntPtr JS_EncodeString_Linux64(IntPtr cx, IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "_Z21JS_EncodeStringToUTF8P9JSContextN2JS6HandleIP8JSStringEE")]
        private static extern IntPtr JS_EncodeStringUTF8_Linux64(IntPtr cx, ref IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
               EntryPoint = "_Z13JS_EndRequestP9JSContext")]
        private static extern IntPtr JS_EndRequest_Linux64(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
               EntryPoint = "_Z19JS_EnterCompartmentP9JSContextP8JSObject")]
        private static extern IntPtr JS_EnterCompartment_Linux64(IntPtr cx, IntPtr obj);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
               "_Z16JS_ExecuteScriptP9JSContextN2JS6HandleIP8JSScriptEENS1_13MutableHandleINS1_5ValueEEE")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_ExecuteScript_Linux64(IntPtr cx, ref IntPtr handleScript,
            ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
               EntryPoint = "_Z7JS_freeP9JSContextPv")]
        private static extern void JS_Free_Linux64(IntPtr cx, IntPtr p);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
               EntryPoint = "_Z11JS_GetClassP8JSObject")]
        private static extern IntPtr JS_GetClass_Linux64(IntPtr obj);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
               EntryPoint = "_Z17JS_GetClassObjectP9JSContext10JSProtoKeyN2JS13MutableHandleIP8JSObjectEE")]
        private static extern IntPtr JS_GetClassObject_Linux64(IntPtr context, IntPtr proto, ref MutableHandle jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
               EntryPoint = "_Z27JS_GetCompartmentPrincipalsP13JSCompartment")]
        private static extern IntPtr JS_GetCompartmentPrincipals_Linux64(IntPtr jsCompartment);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
               EntryPoint = "_Z18JS_ContextIteratorP9JSRuntimePP9JSContext")]
        private static extern IntPtr JS_ContextIterator_Linux64(IntPtr rt, ref IntPtr iterp);

        // if JSOPTION_PRIVATE_IS_NSISUPPORTS is set on the runtime then ContextPrivate should contain the nsISupports object.
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
               EntryPoint = "_Z20JS_GetContextPrivateP9JSContext")]
        private static extern IntPtr JS_GetContextPrivate_Linux64(IntPtr context);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
               EntryPoint = "_Z22JS_GetEmptyStringValueP9JSContext")]
        private static extern JsVal JS_GetEmptyStringValue_Linux64(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
               EntryPoint = "_Z21JS_GetGlobalForObjectP9JSContextP8JSObject")]
        private static extern IntPtr JS_GetGlobalForObject_Linux64(IntPtr aJSContext, IntPtr jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "_Z19JS_LeaveCompartmentP9JSContextP13JSCompartment")]
        private static extern void JS_LeaveCompartment_Linux64(IntPtr cx, IntPtr oldCompartment);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
                   "_Z14JS_GetPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcNS1_13MutableHandleINS1_5ValueEEE")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_GetProperty_Linux64(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z18JS_GetStringLengthP8JSString")]
        private static extern int JS_GetStringLength_Linux64(IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z26JS_GetStringEncodingLengthP9JSContextP8JSString")]
        private static extern int JS_GetStringEncodingLength_Linux64(IntPtr cx, IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z14JS_HasPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcPb")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_HasProperty_Linux64(IntPtr cx, ref IntPtr jsObject, string name,
            [MarshalAs(UnmanagedType.U1)] out bool found);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z27JS_GetNegativeInfinityValueP9JSContext")]
        private static extern JsVal JS_GetNegativeInfinityValue_Linux64(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z22JS_GetPendingExceptionP9JSContextN2JS13MutableHandleINS1_5ValueEEE")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_GetPendingException_Linux64(IntPtr cx, ref MutableHandle handle);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z13JS_NewContextP9JSRuntimem")]
        private static extern IntPtr JS_NewContext_Linux64(IntPtr runtime, int stacksize);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
               EntryPoint = "_Z17JS_NewPlainObjectP9JSContext")]
        private static extern IntPtr JS_NewPlainObject_Linux64(IntPtr cx);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z17JS_NewStringCopyNP9JSContextPKcm")]
        private static extern IntPtr JS_NewStringCopyN_Linux64(IntPtr cx, string str, int length);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z17JS_SaveFrameChainP9JSContext")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_SaveFrameChain_Linux64(IntPtr jsContext);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z27JS_SetCompartmentPrincipalsP13JSCompartmentP12JSPrincipals")]
        private static extern void JS_SetCompartmentPrincipals_Linux64(IntPtr jsCompartment, IntPtr principals);

        /// <summary>
        /// declaration in jsapi.h
        /// extern JS_PUBLIC_API(JSContextCallback) JS_SetContextCallback(JSRuntime *rt, JSContextCallback cxCallback);
        /// </summary>
        /// <param name="rt"></param>
        /// <param name="cb"></param>
        /// <returns></returns>
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z21JS_SetContextCallbackP9JSRuntimePFbP9JSContextjPvES3_")]
        private static extern void JS_SetContextCallback_Linux64(IntPtr rt, JSContextCallback cb, IntPtr data);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z20JS_SetContextPrivateP9JSContextPv")]
        private static extern void JS_SetContextPrivate_Linux64(IntPtr context, IntPtr data);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z19JS_SetErrorReporterP9JSRuntimePFvP9JSContextPKcP13JSErrorReportE")]
        private static extern JSErrorReportCallback JS_SetErrorReporter_Linux64(IntPtr runtime,
            JSErrorReportCallback callback);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint = "_Z14JS_SetPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcNS2_INS1_5ValueEEE")
        ]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_SetProperty_Linux64(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z23JS_SetTrustedPrincipalsP9JSRuntimeP12JSPrincipals")]
        private static extern void JS_SetTrustedPrincipals_Linux64(IntPtr runtime, IntPtr principals);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z14JS_TypeOfValueP9JSContextN2JS6HandleINS1_5ValueEEE")]
        private static extern JSType JS_TypeOfValue_Linux64(IntPtr cx, ref JsVal jsVal);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
            EntryPoint =
           "_Z16JS_ValueToObjectP9JSContextN2JS6HandleINS1_5ValueEEENS1_13MutableHandleIP8JSObjectEE")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_ValueToObject_Linux64(IntPtr cx, ref JsVal jsValue, ref MutableHandle jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z13JS_GetRuntimeP9JSContext")]
        private static extern IntPtr JS_GetRuntime_Linux64(IntPtr context);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_Z13JS_WrapObjectP9JSContextN2JS13MutableHandleIP8JSObjectEE")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_WrapObject_Linux64(IntPtr cx, ref MutableHandle p);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false,
           EntryPoint = "_ZN2js12ToStringSlowEP9JSContextN2JS6HandleINS2_5ValueEEE")]
        private static extern IntPtr ToStringSlow_Linux64(IntPtr cx, ref JsVal v);

        #endregion
    }
}