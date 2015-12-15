﻿using System.Runtime.InteropServices;
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

        public static IntPtr JS_EncodeStringToUTF8(IntPtr cx, IntPtr jsString)
        {
            if (Xpcom.Is32Bit)
            {
                if (Xpcom.IsLinux)
                    return JS_EncodeStringUTF8_Linux32(cx, ref jsString);

                return JS_EncodeStringUTF8_Win32(cx, ref jsString);
            }
            else
            {
                if (Xpcom.IsLinux)
                    return JS_EncodeStringUTF8_Linux64(cx, ref jsString);

                return JS_EncodeStringUTF8_Win64(cx, ref jsString);
            }
        }
		
        public static int JS_GetStringLength(IntPtr jsString)
	    {
            if (Xpcom.Is32Bit)
            {
                if (Xpcom.IsLinux)
                    return JS_GetStringLength_Linux32(jsString);

                return JS_GetStringLength_Win32(jsString);
            }
            else
            {
                if (Xpcom.IsLinux)
                    return JS_GetStringLength_Linux64(jsString);

                return JS_GetStringLength_Win64(jsString);
            }
	    }

        public static int JS_GetStringEncodingLength(IntPtr cx, IntPtr jsString)
	    {
            if (Xpcom.Is32Bit)
            {
                if (Xpcom.IsLinux)
                    return JS_GetStringEncodingLength_Linux32(cx, jsString);

                return JS_GetStringEncodingLength_Win32(cx, jsString);
            }
            else
            {
                if (Xpcom.IsLinux)
                    return JS_GetStringEncodingLength_Linux64(cx, jsString);

                return JS_GetStringEncodingLength_Win64(cx, jsString);
            }
	    }

		public static JSType JS_TypeOfValue(IntPtr cx, JsVal jsVal)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_TypeOfValue_Linux32(cx, ref jsVal);

				return JS_TypeOfValue_Win32(cx, ref jsVal);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_TypeOfValue_Linux64(cx, ref jsVal);

				return JS_TypeOfValue_Win64(cx, ref jsVal);
			}
		}		
		
		public static IntPtr JS_ValueToString(IntPtr cx, JsVal v)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_ValueToString_Linux32(cx, ref v);
				
				return JS_ValueToString_Win32(cx, ref v);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_ValueToString_Linux64(cx, ref v);

				return JS_ValueToString_Win64(cx, ref v);
			}
		}
		
		public static IntPtr JS_ValueToObject(IntPtr cx, JsVal v)
		{
			if (Xpcom.Is32Bit)
			{
				MutableHandle mutableHandle = new MutableHandle();
				if (Xpcom.IsLinux)
					JS_ValueToObject_Linux32(cx, ref v, ref mutableHandle);
				else
					JS_ValueToObject_Win32(cx, ref v, ref mutableHandle);
				return mutableHandle.Handle;
			}
			else
			{
				MutableHandle mutableHandle = new MutableHandle();
				if (Xpcom.IsLinux)
					JS_ValueToObject_Linux64(cx, ref v, ref mutableHandle);
				else
					JS_ValueToObject_Win64(cx, ref v, ref mutableHandle);
				return mutableHandle.Handle;
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

		/// <summary>
		/// This is just a wrapper for DefaultObjectForContextOrNull.
		/// The JS_GetGlobalForScopeChain has been removed from spidermonkey.
		/// Its possible options for replacements were DefaultObjectForContextOrNull or
		/// CurrentGlobalOrNull. 
		/// </summary>
		/// <param name="aJSContext"></param>
		/// <returns></returns>
		[Obsolete]
		public static IntPtr JS_GetGlobalForScopeChain(IntPtr aJSContext)
		{
			return DefaultObjectForContextOrNull(aJSContext);	
		}
		
		public static IntPtr JS_GetGlobalForObject(IntPtr jsContext, IntPtr jsObject)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_GetGlobalForObject_Linux32(jsContext, jsObject);
				return JS_GetGlobalForObject_Win32(jsContext, jsObject);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_GetGlobalForObject_Linux64(jsContext, jsObject);
				throw new NotImplementedException("JS_GetGlobalForObject_Win64 is not hooked up yet");
				//return JS_GetGlobalForObject_Win64(jsContext, jsObject);
			}
		}
		
		public static IntPtr GetGlobalForObjectCrossCompartment(IntPtr jsObject)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return GetGlobalForObjectCrossCompartment_Linux32(jsObject);
				return GetGlobalForObjectCrossCompartment_Win32(jsObject);
			}
			else
			{
				if (Xpcom.IsLinux)
					return GetGlobalForObjectCrossCompartment_Linux64(jsObject);
				throw new NotImplementedException("GetGlobalForObjectCrossCompartment_Win64 is not hooked up yet");
				//return GetGlobalForObjectCrossCompartment_Win64(jsObject);
			}
		}
		
		public static bool JS_SaveFrameChain(IntPtr jsContext)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_SaveFrameChain_Linux32(jsContext);
				return JS_SaveFrameChain_Win32(jsContext);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_SaveFrameChain_Linux64(jsContext);
				throw new NotImplementedException("JS_SaveFrameChain_Win64 is not hooked up yet");
				//return JS_SaveFrameChain_Win64(jsContext);
			}
		}

		public static IntPtr JS_NewObject(IntPtr context, IntPtr globalClass, IntPtr proto, IntPtr parent)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_NewObject_Linux32(context, globalClass, proto, parent);
				return JS_NewObject_Win32(context, globalClass, proto, parent);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_NewObject_Linux64(context, globalClass, proto, parent);
				throw new NotImplementedException("JS_NewObject_Win64 is not hooked up yet");
				//return JS_NewObject_Win64(context, globalClass, proto, parent);
			}
		}
		

		public static IntPtr JS_GetParent(IntPtr jsObject)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_GetParent_Linux32(jsObject);
				return JS_GetParent_Win32(jsObject);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_GetParent_Linux64(jsObject);
				throw new NotImplementedException("JS_GetParent_Win64 is not hooked up yet");
				//return JS_GetParent_Win64(jsObject);
			}
		}

		public static IntPtr CurrentGlobalOrNull(IntPtr aJSContext)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return CurrentGlobalOrNull_Linux32(aJSContext);

				return CurrentGlobalOrNull_Win32(aJSContext);
			}
			else
			{
				if (Xpcom.IsLinux)
					return CurrentGlobalOrNull_Linux64(aJSContext);
				
				return CurrentGlobalOrNull_Win64(aJSContext);
			}
		}

		public static IntPtr JS_NewContext(IntPtr runtime, int stackChunkSize)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_NewContext_Linux32(runtime, stackChunkSize);

				return JS_NewContext_Win32(runtime, stackChunkSize);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_NewContext_Linux64(runtime, stackChunkSize);

				throw new NotImplementedException();
			}
		}

		public static IntPtr JS_GetRuntime(IntPtr jsContext)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_GetRuntime_Linux32(jsContext);

				return JS_GetRuntime_Win32(jsContext);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_GetRuntime_Linux64(jsContext);

				throw new NotImplementedException();
			}
		}
		
		/// <summary>
		/// This should return an nsISupport object if a option JSOPTION_PRIVATE_IS_NSISUPPORTS is set on the runtime.
		/// </summary>
		/// <param name="jsContext"></param>
		/// <returns></returns>
		public static IntPtr JS_GetContextPrivate(IntPtr jsContext)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_GetContextPrivate_Linux32(jsContext);

				return JS_GetContextPrivate_Win32(jsContext);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_GetContextPrivate_Linux64(jsContext);

				throw new NotImplementedException();
			}
		}

		public static void JS_SetContextPrivate(IntPtr jsContext, IntPtr data)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					JS_SetContextPrivate_Linux32(jsContext, data);
				else
					JS_SetContextPrivate_Win32(jsContext, data);
			}
			else
			{
				if (Xpcom.IsLinux)
					JS_SetContextPrivate_Linux64(jsContext, data);
				else
					throw new NotImplementedException();
			}
		}

		public static IntPtr DefaultObjectForContextOrNull(IntPtr jsContext)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return DefaultObjectForContextOrNull_Linux32(jsContext);
				
				return DefaultObjectForContextOrNull_Win32(jsContext);
			}
			else
			{
				if (Xpcom.IsLinux)
					return DefaultObjectForContextOrNull_Linux64(jsContext);

				return DefaultObjectForContextOrNull_Win64(jsContext);
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

		private static string EncodeUnicodeScript(string script)
		{
			int i;
			for (i = 0; i < script.Length && script [i] < 128; i++);
			if (i == script.Length)
				return script;
			var sb = new System.Text.StringBuilder();
			if (i > 0)
				sb.Append (script.Substring(0, i));
			for (; i < script.Length; i++)
			{
				char c = script [i];
				if (c < 128)
					sb.Append(c);
				else
				{
					sb.Append("\\u");
					sb.Append(((int)c).ToString("X4"));
				}
			}
			return sb.ToString();
		}
		
		public static bool JS_EvaluateScript(IntPtr cx, IntPtr obj, string src, UInt32 length, string filename, UInt32 lineno, ref JsVal jsval)
		{
			src = EncodeUnicodeScript(src);
			length = (uint)src.Length;
			if (cx == IntPtr.Zero)
				throw new ArgumentNullException("cx");

			if (obj == IntPtr.Zero)
				throw new ArgumentNullException("obj");

            var mJsVal = new MutableJSVal(jsval);
            bool retval = false;

			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
                    retval = JS_EvaluateScript_Linux32(cx, ref obj, src, length, filename, lineno, ref mJsVal);
                else
			        retval = JS_EvaluateScript_Win32(cx, ref obj, src, length, filename, lineno, ref mJsVal);
			}
			else
			{
				if (Xpcom.IsLinux)
                    retval = JS_EvaluateScript_Linux64(cx, ref obj, src, length, filename, lineno, ref mJsVal);
                else
                    retval = JS_EvaluateScript_Win64(cx, ref obj, src, length, filename, lineno, ref mJsVal);
			}

            jsval = mJsVal.Val;
            return retval;
		}
	
		public static IntPtr JS_GetClassObject(IntPtr context, IntPtr proto)
		{
			var m = new MutableHandle();
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					JS_GetClassObject_Linux32(context, proto, ref m);
				else
					JS_GetClassObject_Win32(context, proto, ref m);
			}
			else
			{
				if (Xpcom.IsLinux)
					JS_GetClassObject_Linux64(context, proto, ref m);
				else
					return IntPtr.Zero; // Not implemented
			}
			return m.Handle;
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
					JS_SetContextCallback_Linux32(rt, cb, IntPtr.Zero);
				else 
					JS_SetContextCallback_Win32(rt, cb, IntPtr.Zero);
				return null;
			}
			else
			{
				if (Xpcom.IsLinux)
					JS_SetContextCallback_Linux64(rt, cb, IntPtr.Zero);
				else
					JS_SetContextCallback_Win64(rt, cb, IntPtr.Zero);
				
				return null;
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

		public static IntPtr JS_WrapObject(IntPtr cx, IntPtr jsObject)
		{
			MutableHandle mh = new MutableHandle(jsObject);
			bool success = false;
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					success = JS_WrapObject_Linux32(cx, ref mh);
				else
					success = JS_WrapObject_Win32(cx, ref mh);
			}
			else
			{
				if (Xpcom.IsLinux)
					success = JS_WrapObject_Linux64(cx, ref mh);
				else
					throw new NotImplementedException();
			}
			return success ? mh.Handle : IntPtr.Zero;
		}

		public static bool IsObjectInContextCompartment(IntPtr jsObject, IntPtr cx)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return IsObjectInContextCompartment_Linux32(jsObject, cx);
				return IsObjectInContextCompartment_Win32(jsObject, cx);
			}
			else
			{
				if (Xpcom.IsLinux)
					return IsObjectInContextCompartment_Linux64(jsObject, cx);

				throw new NotImplementedException();
			}
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

		public static bool JS_HasProperty(IntPtr cx, IntPtr jsObject, string name)
		{
			bool hasProperty;

			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					JS_HasProperty_Linux32(cx, ref jsObject, name, out hasProperty);
				else
					JS_HasProperty_Win32(cx, ref jsObject, name, out hasProperty);
			}
			else
			{
				if (Xpcom.IsLinux)
					JS_HasProperty_Linux64(cx, ref jsObject, name, out hasProperty);
				else
					throw new NotImplementedException();
			}

			return hasProperty;
		}

		public static JsVal JS_GetProperty(IntPtr cx, IntPtr jsObject, string name)
		{
			JsVal Value = new JsVal();
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					JS_GetProperty_Linux32(cx, ref jsObject, name, ref Value);
				else
					JS_GetProperty_Win32(cx, ref jsObject, name, ref Value);
			}
			else
			{
				if (Xpcom.IsLinux)
					JS_GetProperty_Linux64(cx, ref jsObject, name, ref Value);
				else
					throw new NotImplementedException();
			}

			return Value;
		}

        /* A handle to an array of rooted values. */

	    private struct HandleValueArray
	    {
	        public HandleValueArray(int length, JsVal[] args)
	        {
	            _length = length;
	            _args = args;
	        }
            
	        private int _length;
            [MarshalAs(UnmanagedType.ByValArray)]
	        private JsVal[] _args;	    
	    }

		/// <summary>
		/// JS_CallFunctionName without args
		/// </summary>
		/// <param name="cx"></param>
		/// <param name="jsObject"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		public static JsVal JS_CallFunctionName( IntPtr cx, IntPtr jsObject, string name )
		{
			bool result;
			JsVal value = new JsVal();
			int parameterCount = 0;
			if ( Xpcom.Is32Bit )
			{
				if ( Xpcom.IsLinux )
					result = JS_CallFunctionName_Linux32( cx, ref jsObject, name, ref parameterCount, ref value );
				else
					result = JS_CallFunctionName_Win32( cx, ref jsObject, name, ref parameterCount, ref value );
			}
			else
			{
				if ( Xpcom.IsLinux )
					result = JS_CallFunctionName_Linux64( cx, ref jsObject, name, ref parameterCount, ref value );
				else
					throw new NotImplementedException();
			}

			if ( !result )
				throw new GeckoException( "Function does not exist!" );
			return value;
		}

	    public static JsVal JS_CallFunctionName(IntPtr cx, IntPtr jsObject, string name, JsVal[] args)
        {
		    if ( ( args == null ) || ( args.Length == 0 ) )
		    {
			    return JS_CallFunctionName( cx, jsObject, name );
		    }

			bool result;
			JsVal value = new JsVal();


            HandleValueArray argsArray = new HandleValueArray(args.Length, args);

            if (Xpcom.Is32Bit)
            {
                if (Xpcom.IsLinux)
                    result = JS_CallFunctionName_Linux32(cx, ref jsObject, name, ref argsArray, ref value);
                else
                    result = JS_CallFunctionName_Win32(cx, ref jsObject, name, ref argsArray, ref value);
            }
            else
            {
                if (Xpcom.IsLinux)
                    result = JS_CallFunctionName_Linux64(cx, ref jsObject, name, ref argsArray, ref value);
                else
                    throw new NotImplementedException();
            }
            
            if (!result)
                throw new GeckoException("Function does not exist!");
            return value;
        }

		public static void JS_SetCompartmentPrincipals(IntPtr jsCompartment, IntPtr principals)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					JS_SetCompartmentPrincipals_Linux32(jsCompartment, principals);
				else
					JS_SetCompartmentPrincipals_Win32(jsCompartment, principals);
			}
			else
			{
				if (Xpcom.IsLinux)
					JS_SetCompartmentPrincipals_Linux64(jsCompartment, principals);
				else
					throw new NotImplementedException();
			}
		}

		public static IntPtr JS_GetCompartmentPrincipals(IntPtr jsCompartment)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_GetCompartmentPrincipals_Linux32(jsCompartment);
				return JS_GetCompartmentPrincipals_Win32(jsCompartment);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_GetCompartmentPrincipals_Linux64(jsCompartment);
				throw new NotImplementedException();
			}
		}

		public static void JS_SetTrustedPrincipals(IntPtr runtime, IntPtr principals)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					JS_SetTrustedPrincipals_Linux32(runtime, principals);
				else
					JS_SetTrustedPrincipals_Win32(runtime, principals);
			}
			else
			{
				if (Xpcom.IsLinux)
					JS_SetTrustedPrincipals_Linux64(runtime, principals);
				else
					throw new NotImplementedException();
			}
		}

		public static IntPtr JS_GetPendingException(IntPtr cx)
		{
			MutableHandle mutableHandle = new MutableHandle();
			bool success = false;
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					success = JS_GetPendingException_Linux32(cx, ref mutableHandle);
				else
					success = JS_GetPendingException_Win32(cx, ref mutableHandle);
			}
			else
			{
				if (Xpcom.IsLinux)
					success = JS_GetPendingException_Linux64(cx, ref mutableHandle);
				else
					throw new NotImplementedException();
			}

			return success ? mutableHandle.Handle : IntPtr.Zero;
		}

		public static JSErrorReportCallback JS_SetErrorReporter(IntPtr cx, JSErrorReportCallback callback)
		{
			if (Xpcom.Is32Bit)
			{
				if (Xpcom.IsLinux)
					return JS_SetErrorReporter_Linux32(cx, callback);
				return JS_SetErrorReporter_Win32(cx, callback);
			}
			else
			{
				if (Xpcom.IsLinux)
					return JS_SetErrorReporter_Linux64(cx, callback);
				return JS_SetErrorReporter_Win64(cx, callback);
			}
		}


		#endregion

		[UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
		public delegate JSBool JSContextCallback(IntPtr cx, UInt32 contextOp);

		[UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public delegate void JSErrorReportCallback(IntPtr cx, string message, IntPtr report);

		#region Windows x86

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_HasProperty@@YA_NPAUJSContext@@V?$Handle@PAVJSObject@@@JS@@PBDPA_N@Z")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_HasProperty_Win32(IntPtr cx, ref IntPtr jsObject, string name, [MarshalAs(UnmanagedType.U1)] out bool found);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetProperty@@YA_NPAUJSContext@@V?$Handle@PAVJSObject@@@JS@@PBDV?$MutableHandle@VValue@JS@@@3@@Z")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_GetProperty_Win32(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_CallFunctionName@@YA_NPAUJSContext@@V?$Handle@PAVJSObject@@@JS@@PBDABVHandleValueArray@3@V?$MutableHandle@VValue@JS@@@3@@Z")]
		[return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CallFunctionName_Win32(IntPtr cx, ref IntPtr jsObject, string name, ref HandleValueArray args, ref JsVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_CallFunctionName@@YA_NPAUJSContext@@V?$Handle@PAVJSObject@@@JS@@PBDABVHandleValueArray@3@V?$MutableHandle@VValue@JS@@@3@@Z")]
		[return: MarshalAs( UnmanagedType.U1 )]
		private static extern bool JS_CallFunctionName_Win32( IntPtr cx, ref IntPtr jsObject, string name, ref int args, ref JsVal jsValue );

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_SetCompartmentPrincipals@@YAXPAUJSCompartment@@PAUJSPrincipals@@@Z")]
		private static extern void JS_SetCompartmentPrincipals_Win32(IntPtr jsCompartment, IntPtr principals);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetCompartmentPrincipals@@YAPAUJSPrincipals@@PAUJSCompartment@@@Z")]
		private static extern IntPtr JS_GetCompartmentPrincipals_Win32(IntPtr jsCompartment);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_SetTrustedPrincipals@@YAXPAUJSRuntime@@PBUJSPrincipals@@@Z")]
		private static extern void JS_SetTrustedPrincipals_Win32(IntPtr runtime, IntPtr principals);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EncodeString@@YAPADPAUJSContext@@PAVJSString@@@Z")]
		private static extern IntPtr JS_EncodeString_Win32(IntPtr cx, IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EncodeStringToUTF8@@YAPADPAUJSContext@@V?$Handle@PAVJSString@@@JS@@@Z")]
        private static extern IntPtr JS_EncodeStringUTF8_Win32(IntPtr cx, ref IntPtr jsString);
        
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetStringLength@@YAIPAVJSString@@@Z")]
        private static extern int JS_GetStringLength_Win32(IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetStringEncodingLength@@YAIPAUJSContext@@PAVJSString@@@Z")]
        private static extern int JS_GetStringEncodingLength_Win32(IntPtr cx, IntPtr jsString);
       
		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_TypeOfValue@@YA?AW4JSType@@PAUJSContext@@V?$Handle@VValue@JS@@@JS@@@Z")]
		private static extern JSType JS_TypeOfValue_Win32(IntPtr cx, ref JsVal jsVal);
		
		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?ToStringSlow@js@@YAPAVJSString@@PAUJSContext@@V?$Handle@VValue@JS@@@JS@@@Z")]
		private static extern IntPtr JS_ValueToString_Win32(IntPtr cx, ref JsVal v);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_ValueToObject@@YA_NPAUJSContext@@V?$Handle@VValue@JS@@@JS@@V?$MutableHandle@PAVJSObject@@@3@@Z")]
		[return: MarshalAs(UnmanagedType.U1)]
		// JS_ValueToObject(JSContext *cx, JS::HandleValue v, JS::MutableHandleObject objp);
		private static extern bool JS_ValueToObject_Win32(IntPtr cx, ref JsVal jsValue, ref MutableHandle jsObject);

		[DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_NewStringCopyN@@YAPAVJSString@@PAUJSContext@@PBDI@Z")]
		private static extern IntPtr JS_NewStringCopyN_Win32(IntPtr cx, string str, int length);			
		
		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?CurrentGlobalOrNull@JS@@YAPAVJSObject@@PAUJSContext@@@Z")]
		private static extern IntPtr CurrentGlobalOrNull_Win32(IntPtr aJSContext);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetGlobalForObject@@YAPAVJSObject@@PAUJSContext@@PAV1@@Z")]
		private static extern IntPtr JS_GetGlobalForObject_Win32(IntPtr aJSContext, IntPtr jsObject);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?GetGlobalForObjectCrossCompartment@js@@YAPAVJSObject@@PAV2@@Z")]
		private static extern IntPtr GetGlobalForObjectCrossCompartment_Win32(IntPtr jsObject);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_SaveFrameChain@@YA_NPAUJSContext@@@Z")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_SaveFrameChain_Win32(IntPtr jsContext);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_NewObject@@YAPAVJSObject@@PAUJSContext@@PBUJSClass@@V?$Handle@PAVJSObject@@@JS@@2@Z")]		
		private static extern IntPtr JS_NewObject_Win32(IntPtr jsContext, IntPtr classp, IntPtr proto, IntPtr parent);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetParent@@YAPAVJSObject@@PAV1@@Z")]
		private static extern IntPtr JS_GetParent_Win32(IntPtr jsObject);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_NewContext@@YAPAUJSContext@@PAUJSRuntime@@I@Z")]
		private static extern IntPtr JS_NewContext_Win32(IntPtr runtime, int stacksize);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetRuntime@@YAPAUJSRuntime@@PAUJSContext@@@Z")]
		private static extern IntPtr JS_GetRuntime_Win32(IntPtr context);

		// if JSOPTION_PRIVATE_IS_NSISUPPORTS is set on the runtime then ContextPrivate should contain the nsISupports object.
		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetContextPrivate@@YAPAXPAUJSContext@@@Z")]
		private static extern IntPtr JS_GetContextPrivate_Win32(IntPtr context);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_SetContextPrivate@@YAXPAUJSContext@@PAX@Z")]
		private static extern void JS_SetContextPrivate_Win32(IntPtr context, IntPtr data);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?DefaultObjectForContextOrNull@js@@YAPAVJSObject@@PAUJSContext@@@Z")]
		private static extern IntPtr DefaultObjectForContextOrNull_Win32(IntPtr aJSContext);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_BeginRequest@@YAXPAUJSContext@@@Z")]
		private static extern IntPtr JS_BeginRequest_Win32(IntPtr cx);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EndRequest@@YAXPAUJSContext@@@Z")]
		private static extern IntPtr JS_EndRequest_Win32(IntPtr cx);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EvaluateScript@@YA_NPAUJSContext@@V?$Handle@PAVJSObject@@@JS@@PBDI2IV?$MutableHandle@VValue@JS@@@3@@Z")]
		[return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_EvaluateScript_Win32(IntPtr cx, ref IntPtr obj, string src, UInt32 length, string filename, UInt32 lineno, ref MutableJSVal jsval);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetClass@@YAPBUJSClass@@PAVJSObject@@@Z")]
		private static extern IntPtr JS_GetClass_Win32(IntPtr obj);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetClassObject@@YA_NPAUJSContext@@W4JSProtoKey@@V?$MutableHandle@PAVJSObject@@@JS@@@Z")]
		private static extern IntPtr JS_GetClassObject_Win32(IntPtr context, IntPtr proto, ref MutableHandle jsObject);		

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_ContextIterator@@YAPAUJSContext@@PAUJSRuntime@@PAPAU1@@Z")]
		private static extern IntPtr JS_ContextIterator_Win32(IntPtr rt, ref IntPtr iterp);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EnterCompartment@@YAPAUJSCompartment@@PAUJSContext@@PAVJSObject@@@Z")]
		private static extern IntPtr JS_EnterCompartment_Win32(IntPtr cx, IntPtr obj);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_LeaveCompartment@@YAXPAUJSContext@@PAUJSCompartment@@@Z")]
		private static extern void JS_LeaveCompartment_Win32(IntPtr cx, IntPtr oldCompartment);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_free@@YAXPAUJSContext@@PAX@Z")]
		private static extern void JS_Free_Win32(IntPtr cx, IntPtr p);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_WrapObject@@YA_NPAUJSContext@@V?$MutableHandle@PAVJSObject@@@JS@@@Z")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_WrapObject_Win32(IntPtr cx, ref MutableHandle p);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?IsObjectInContextCompartment@js@@YA_NPAVJSObject@@PBUJSContext@@@Z")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool IsObjectInContextCompartment_Win32(IntPtr jsObject, IntPtr context);

		/// <summary>
		/// declaration in jsapi.h
		/// extern JS_PUBLIC_API(JSContextCallback) JS_SetContextCallback(JSRuntime *rt, JSContextCallback cxCallback);
		/// </summary>
		/// <param name="rt"></param>
		/// <param name="cb"></param>
		/// <returns></returns>
		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_SetContextCallback@@YAXPAUJSRuntime@@P6A_NPAUJSContext@@IPAX@Z2@Z")]
		private static extern void JS_SetContextCallback_Win32(IntPtr rt, JSContextCallback cb, IntPtr data);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetPendingException@@YA_NPAUJSContext@@V?$MutableHandle@VValue@JS@@@JS@@@Z")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_GetPendingException_Win32(IntPtr cx, ref MutableHandle handle);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_SetErrorReporter@@YAP6AXPAUJSContext@@PBDPAUJSErrorReport@@@Z0P6AX012@Z@Z")]		
		private static extern JSErrorReportCallback JS_SetErrorReporter_Win32(IntPtr cx, JSErrorReportCallback callback);

		#endregion

		#region Windows x64

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EncodeString@@YAPEADPEAUJSContext@@PEAVJSString@@@Z")]
		private static extern IntPtr JS_EncodeString_Win64(IntPtr cx, IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EncodeStringToUTF8@@YAPADPAUJSContext@@V?$Handle@PAVJSString@@@JS@@@Z")]
        private static extern IntPtr JS_EncodeStringUTF8_Win64(IntPtr cx, ref IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetStringLength@@YAIPAVJSString@@@Z")]
        private static extern int JS_GetStringLength_Win64(IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetStringEncodingLength@@YAIPAUJSContext@@PAVJSString@@@Z")]
        private static extern int JS_GetStringEncodingLength_Win64(IntPtr cx, IntPtr jsString);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_TypeOfValue@@YA?AW4JSType@@PEAUJSContext@@V?$Handle@VValue@JS@@@JS@@@Z")]
		private static extern JSType JS_TypeOfValue_Win64(IntPtr cx, ref JsVal jsVal);		

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?ToStringSlow@js@@YAPEAVJSString@@PEAUJSContext@@V?$Handle@VValue@JS@@@JS@@@Z")]
		private static extern IntPtr JS_ValueToString_Win64(IntPtr cx, ref JsVal v);		

		[DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_NewStringCopyN@@YAPEAVJSString@@PEAUJSContext@@PEBD_K@Z")]
		private static extern IntPtr JS_NewStringCopyN_Win64(IntPtr cx, string str, int length);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_ValueToObject@@YA_NPEAUJSContext@@V?$Handle@VValue@JS@@@JS@@V?$MutableHandle@PEAVJSObject@@@3@@Z")]
		[return: MarshalAs(UnmanagedType.U1)]
		// JS_ValueToObject(JSContext *cx, JS::HandleValue v, JS::MutableHandleObject objp);
		private static extern bool JS_ValueToObject_Win64(IntPtr cx, ref JsVal jsValue, ref MutableHandle jsObject);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?CurrentGlobalOrNull@JS@@YAPEAVJSObject@@PEAUJSContext@@@Z")]
		private static extern IntPtr CurrentGlobalOrNull_Win64(IntPtr aJSContext);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_BeginRequest@@YAXPEAUJSContext@@@Z")]
		private static extern IntPtr JS_BeginRequest_Win64(IntPtr cx);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?DefaultObjectForContextOrNull@js@@YAPEAVJSObject@@PEAUJSContext@@@Z")]
		private static extern IntPtr DefaultObjectForContextOrNull_Win64(IntPtr aJSContext);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EndRequest@@YAXPEAUJSContext@@@Z")]
		private static extern IntPtr JS_EndRequest_Win64(IntPtr cx);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_EvaluateScriptP9JSContextN2JS6HandleIP8JSObjectEEPKcjS7_jNS1_13MutableHandleINS1_5ValueEEE")]
        private static extern bool JS_EvaluateScript_Win64(IntPtr cx, ref IntPtr obj, string src, UInt32 length, string filename, UInt32 lineno, ref MutableJSVal jsval);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_GetClass@@YAPEBUJSClass@@PEAVJSObject@@@Z")]
		private static extern IntPtr JS_GetClass_Win64(IntPtr obj);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_ContextIterator@@YAPEAUJSContext@@PEAUJSRuntime@@PEAPEAU1@@Z")]
		private static extern IntPtr JS_ContextIterator_Win64(IntPtr rt, ref IntPtr iterp);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_EnterCompartment@@YAPEAUJSCompartment@@PEAUJSContext@@PEAVJSObject@@@Z")]
		private static extern IntPtr JS_EnterCompartment_Win64(IntPtr cx, IntPtr obj);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_LeaveCompartment@@YAXPEAUJSContext@@PEAUJSCompartment@@@Z")]
		private static extern void JS_LeaveCompartment_Win64(IntPtr cx, IntPtr oldCompartment);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_free@@YAXPEAUJSContext@@PEAX@Z")]
		private static extern void JS_Free_Win64(IntPtr cx, IntPtr p);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_SetContextCallback@@YAXPEAUJSRuntime@@P6A_NPEAUJSContext@@IPEAX@Z2@Z")]
		private static extern SpiderMonkey.JSContextCallback JS_SetContextCallback_Win64(IntPtr rt, JSContextCallback cb, IntPtr data);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "?JS_SetErrorReporter@@YAP6AXPEAUJSContext@@PEBDPEAUJSErrorReport@@@Z0P6AX012@Z@Z")]
		private static extern JSErrorReportCallback JS_SetErrorReporter_Win64(IntPtr cx, JSErrorReportCallback callback);

		#endregion

		#region Linux x86

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z14JS_HasPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcPb")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_HasProperty_Linux32(IntPtr cx, ref IntPtr jsObject, string name, [MarshalAs(UnmanagedType.U1)] out bool found);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z14JS_GetPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcNS1_13MutableHandleINS1_5ValueEEE")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_GetProperty_Linux32(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CallFunctionName_Linux32(IntPtr cx, ref IntPtr jsObject, string name, ref HandleValueArray args, ref JsVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE")]
		[return: MarshalAs( UnmanagedType.U1 )]
		private static extern bool JS_CallFunctionName_Linux32( IntPtr cx, ref IntPtr jsObject, string name, ref int args, ref JsVal jsValue );

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z27JS_SetCompartmentPrincipalsP13JSCompartmentP12JSPrincipals")]
		private static extern void JS_SetCompartmentPrincipals_Linux32(IntPtr jsCompartment, IntPtr principals);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z27JS_GetCompartmentPrincipalsP13JSCompartment")]
		private static extern IntPtr JS_GetCompartmentPrincipals_Linux32(IntPtr jsCompartment);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z23JS_SetTrustedPrincipalsP9JSRuntimePK12JSPrincipals")]
		private static extern void JS_SetTrustedPrincipals_Linux32(IntPtr runtime, IntPtr principals);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z15JS_EncodeStringP9JSContextP8JSString")]
		private static extern IntPtr JS_EncodeString_Linux32(IntPtr cx, IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z21JS_EncodeStringToUTF8P9JSContextN2JS6HandleIP8JSStringEE")]
        private static extern IntPtr JS_EncodeStringUTF8_Linux32(IntPtr cx, ref IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z18JS_GetStringLengthP8JSString")]
        private static extern int JS_GetStringLength_Linux32(IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z26JS_GetStringEncodingLengthP9JSContextP8JSString")]
        private static extern int JS_GetStringEncodingLength_Linux32(IntPtr cx, IntPtr jsString);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z14JS_TypeOfValueP9JSContextN2JS6HandleINS1_5ValueEEE")]
		private static extern JSType JS_TypeOfValue_Linux32(IntPtr cx, ref JsVal jsVal);
		
		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_ZN2js12ToStringSlowEP9JSContextN2JS6HandleINS2_5ValueEEE")]
		private static extern IntPtr JS_ValueToString_Linux32(IntPtr cx, ref JsVal v);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z16JS_ValueToObjectP9JSContextN2JS6HandleINS1_5ValueEEENS1_13MutableHandleIP8JSObjectEE")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_ValueToObject_Linux32(IntPtr cx, ref JsVal jsValue, ref MutableHandle jsObject);

		[DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_NewStringCopyNP9JSContextPKcj")]
		private static extern IntPtr JS_NewStringCopyN_Linux32(IntPtr cx, string str, int length);	
		
		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_ZN2JS19CurrentGlobalOrNullEP9JSContext")]
		private static extern IntPtr CurrentGlobalOrNull_Linux32(IntPtr aJSContext);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z21JS_GetGlobalForObjectP9JSContextP8JSObject")]
		private static extern IntPtr JS_GetGlobalForObject_Linux32(IntPtr aJSContext, IntPtr jsObject);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_ZN2js34GetGlobalForObjectCrossCompartmentEP8JSObject")]
		private static extern IntPtr GetGlobalForObjectCrossCompartment_Linux32(IntPtr jsObject);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_SaveFrameChainP9JSContext")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_SaveFrameChain_Linux32(IntPtr jsContext);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z12JS_NewObjectP9JSContextPK7JSClassN2JS6HandleIP8JSObjectEES8_")]
		private static extern IntPtr JS_NewObject_Linux32(IntPtr jsContext, IntPtr classp, IntPtr proto, IntPtr parent);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z12JS_GetParentP8JSObject")]
		private static extern IntPtr JS_GetParent_Linux32(IntPtr jsObject);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z13JS_NewContextP9JSRuntimej")]
		private static extern IntPtr JS_NewContext_Linux32(IntPtr runtime, int stacksize);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z13JS_GetRuntimeP9JSContext")]
		private static extern IntPtr JS_GetRuntime_Linux32(IntPtr context);
		
		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z20JS_GetContextPrivateP9JSContext")]
		private static extern IntPtr JS_GetContextPrivate_Linux32(IntPtr context);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z20JS_SetContextPrivateP9JSContextPv")]
		private static extern void JS_SetContextPrivate_Linux32(IntPtr context, IntPtr data);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_ZN2js29DefaultObjectForContextOrNullEP9JSContext")]
		private static extern IntPtr DefaultObjectForContextOrNull_Linux32(IntPtr aJSContext);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z15JS_BeginRequestP9JSContext")]
		private static extern IntPtr JS_BeginRequest_Linux32(IntPtr cx);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z13JS_EndRequestP9JSContext")]
		private static extern IntPtr JS_EndRequest_Linux32(IntPtr cx);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_EvaluateScriptP9JSContextN2JS6HandleIP8JSObjectEEPKcjS7_jNS1_13MutableHandleINS1_5ValueEEE")]
		[return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_EvaluateScript_Linux32(IntPtr cx, ref IntPtr obj, string src, UInt32 length, string filename, UInt32 lineno, ref MutableJSVal jsval);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z11JS_GetClassP8JSObject")]
		private static extern IntPtr JS_GetClass_Linux32(IntPtr obj);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_GetClassObjectP9JSContext10JSProtoKeyN2JS13MutableHandleIP8JSObjectEE")]
		private static extern IntPtr JS_GetClassObject_Linux32(IntPtr context, IntPtr proto, ref MutableHandle jsObject);		

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z18JS_ContextIteratorP9JSRuntimePP9JSContext")]
		private static extern IntPtr JS_ContextIterator_Linux32(IntPtr rt, ref IntPtr iterp);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z19JS_EnterCompartmentP9JSContextP8JSObject")]
		private static extern IntPtr JS_EnterCompartment_Linux32(IntPtr cx, IntPtr obj);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z19JS_LeaveCompartmentP9JSContextP13JSCompartment")]
		private static extern void JS_LeaveCompartment_Linux32(IntPtr cx, IntPtr oldCompartment);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z7JS_freeP9JSContextPv")]
		private static extern void JS_Free_Linux32(IntPtr cx, IntPtr p);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z13JS_WrapObjectP9JSContextN2JS13MutableHandleIP8JSObjectEE")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_WrapObject_Linux32(IntPtr cx, ref MutableHandle p);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_ZN2js28IsObjectInContextCompartmentEP8JSObjectPK9JSContext")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool IsObjectInContextCompartment_Linux32(IntPtr jsObject, IntPtr context);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z21JS_SetContextCallbackP9JSRuntimePFbP9JSContextjPvES3_")]
		private static extern void JS_SetContextCallback_Linux32(IntPtr rt, JSContextCallback cb, IntPtr data);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z22JS_GetPendingExceptionP9JSContextN2JS13MutableHandleINS1_5ValueEEE")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_GetPendingException_Linux32(IntPtr cx, ref MutableHandle handle);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z19JS_SetErrorReporterP9JSContextPFvS0_PKcP13JSErrorReportE")]
		private static extern JSErrorReportCallback JS_SetErrorReporter_Linux32(IntPtr cx, JSErrorReportCallback callback);
		
		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_DestroyRuntimeP9JSRuntime")]
		private static extern void JS_DestroyRuntime_Linux32(IntPtr rt);
		#endregion

		#region Linux x64

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z14JS_HasPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcPb")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_HasProperty_Linux64(IntPtr cx, ref IntPtr jsObject, string name, [MarshalAs(UnmanagedType.U1)] out bool found);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z14JS_GetPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcNS1_13MutableHandleINS1_5ValueEEE")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_GetProperty_Linux64(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE")]
		[return: MarshalAs( UnmanagedType.U1 )]
		private static extern bool JS_CallFunctionName_Linux64( IntPtr cx, ref IntPtr jsObject, string name, ref int args, ref JsVal jsValue );

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE")]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_CallFunctionName_Linux64(IntPtr cx, ref IntPtr jsObject, string name, ref HandleValueArray args, ref JsVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z27JS_SetCompartmentPrincipalsP13JSCompartmentP12JSPrincipals")]
		private static extern void JS_SetCompartmentPrincipals_Linux64(IntPtr jsCompartment, IntPtr principals);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z27JS_GetCompartmentPrincipalsP13JSCompartment")]
		private static extern IntPtr JS_GetCompartmentPrincipals_Linux64(IntPtr jsCompartment);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z23JS_SetTrustedPrincipalsP9JSRuntimePK12JSPrincipals")]
		private static extern void JS_SetTrustedPrincipals_Linux64(IntPtr runtime, IntPtr principals);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z15JS_EncodeStringP9JSContextP8JSString")]
		private static extern IntPtr JS_EncodeString_Linux64(IntPtr cx, IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z21JS_EncodeStringToUTF8P9JSContextN2JS6HandleIP8JSStringEE")]
        private static extern IntPtr JS_EncodeStringUTF8_Linux64(IntPtr cx, ref IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z18JS_GetStringLengthP8JSString")]
        private static extern int JS_GetStringLength_Linux64(IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z26JS_GetStringEncodingLengthP9JSContextP8JSString")]
        private static extern int JS_GetStringEncodingLength_Linux64(IntPtr cx, IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z14JS_TypeOfValueP9JSContextN2JS6HandleINS1_5ValueEEE")]
		private static extern JSType JS_TypeOfValue_Linux64(IntPtr cx, ref JsVal jsVal);
		
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_ZN2js12ToStringSlowEP9JSContextN2JS6HandleINS2_5ValueEEE")]
		private static extern IntPtr JS_ValueToString_Linux64(IntPtr cx, ref JsVal v);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z16JS_ValueToObjectP9JSContextN2JS6HandleINS1_5ValueEEENS1_13MutableHandleIP8JSObjectEE")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_ValueToObject_Linux64(IntPtr cx, ref JsVal jsValue, ref MutableHandle jsObject);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_NewStringCopyNP9JSContextPKcm")]
		private static extern IntPtr JS_NewStringCopyN_Linux64(IntPtr cx, string str, int length);			
		
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_ZN2JS19CurrentGlobalOrNullEP9JSContext")]
		private static extern IntPtr CurrentGlobalOrNull_Linux64(IntPtr aJSContext);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z21JS_GetGlobalForObjectP9JSContextP8JSObject")]
		private static extern IntPtr JS_GetGlobalForObject_Linux64(IntPtr aJSContext, IntPtr jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_ZN2js34GetGlobalForObjectCrossCompartmentEP8JSObject")]
		private static extern IntPtr GetGlobalForObjectCrossCompartment_Linux64(IntPtr jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_SaveFrameChainP9JSContext")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_SaveFrameChain_Linux64(IntPtr jsContext);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z12JS_NewObjectP9JSContextPK7JSClassN2JS6HandleIP8JSObjectEES8")]
		private static extern IntPtr JS_NewObject_Linux64(IntPtr jsContext, IntPtr classp, IntPtr proto, IntPtr parent);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z12JS_GetParentP8JSObject")]
		private static extern IntPtr JS_GetParent_Linux64(IntPtr jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z13JS_NewContextP9JSRuntimem")]
		private static extern IntPtr JS_NewContext_Linux64(IntPtr runtime, int stacksize);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z13JS_GetRuntimeP9JSContext")]
		private static extern IntPtr JS_GetRuntime_Linux64(IntPtr context);
		
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z20JS_GetContextPrivateP9JSContext")]
		private static extern IntPtr JS_GetContextPrivate_Linux64(IntPtr context);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z20JS_SetContextPrivateP9JSContextPv")]
		private static extern void JS_SetContextPrivate_Linux64(IntPtr context, IntPtr data);

		[DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_ZN2js29DefaultObjectForContextOrNullEP9JSContext")]
		private static extern IntPtr DefaultObjectForContextOrNull_Linux64(IntPtr aJSContext);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z15JS_BeginRequestP9JSContext")]
		private static extern IntPtr JS_BeginRequest_Linux64(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z13JS_EndRequestP9JSContext")]
		private static extern IntPtr JS_EndRequest_Linux64(IntPtr cx);

        [DllImport("xul", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_EvaluateScriptP9JSContextN2JS6HandleIP8JSObjectEEPKcjS7_jNS1_13MutableHandleINS1_5ValueEEE")]
		[return: MarshalAs(UnmanagedType.U1)]
        private static extern bool JS_EvaluateScript_Linux64(IntPtr cx, ref IntPtr obj, string src, UInt32 length, string filename, UInt32 lineno, ref MutableJSVal jsval);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z11JS_GetClassP8JSObject")]
		private static extern IntPtr JS_GetClass_Linux64(IntPtr obj);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_GetClassObjectP9JSContext10JSProtoKeyN2JS13MutableHandleIP8JSObjectEE")]
		private static extern IntPtr JS_GetClassObject_Linux64(IntPtr context, IntPtr proto, ref MutableHandle jsObject);		

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z18JS_ContextIteratorP9JSRuntimePP9JSContext")]
		private static extern IntPtr JS_ContextIterator_Linux64(IntPtr rt, ref IntPtr iterp);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z19JS_EnterCompartmentP9JSContextP8JSObject")]
		private static extern IntPtr JS_EnterCompartment_Linux64(IntPtr cx, IntPtr obj);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z19JS_LeaveCompartmentP9JSContextP13JSCompartment")]
		private static extern void JS_LeaveCompartment_Linux64(IntPtr cx, IntPtr oldCompartment);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z7JS_freeP9JSContextPv")]
		private static extern void JS_Free_Linux64(IntPtr cx, IntPtr p);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z13JS_WrapObjectP9JSContextN2JS13MutableHandleIP8JSObjectEE")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_WrapObject_Linux64(IntPtr cx, ref MutableHandle p);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_ZN2js28IsObjectInContextCompartmentEP8JSObjectPK9JSContext")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool IsObjectInContextCompartment_Linux64(IntPtr jsObject, IntPtr context);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z21JS_SetContextCallbackP9JSRuntimePFbP9JSContextjPvES3_")]
		private static extern void JS_SetContextCallback_Linux64(IntPtr rt, JSContextCallback cb, IntPtr data);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z22JS_GetPendingExceptionP9JSContextN2JS13MutableHandleINS1_5ValueEEE")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool JS_GetPendingException_Linux64(IntPtr cx, ref MutableHandle handle);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z19JS_SetErrorReporterP9JSContextPFvS0_PKcP13JSErrorReportE")]
		private static extern JSErrorReportCallback JS_SetErrorReporter_Linux64(IntPtr cx, JSErrorReportCallback callback);
		
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false, EntryPoint = "_Z17JS_DestroyRuntimeP9JSRuntime")]
		private static extern void JS_DestroyRuntime_Linux64(IntPtr rt);
		#endregion

	}
}