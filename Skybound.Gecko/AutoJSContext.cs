#region ***** BEGIN LICENSE BLOCK *****
/* Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Skybound Software code.
 *
 * The Initial Developer of the Original Code is Skybound Software.
 * Portions created by the Initial Developer are Copyright (C) 2008-2009
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 */
#endregion END LICENSE BLOCK

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Skybound.Gecko
{
	/// <summary>
	/// Creates a scoped, fake "system principal" security context.  This class is used primarly to work around bugs in gecko
	/// which prevent methods on nsIDOMCSSStyleSheet from working outside of javascript.
	/// </summary>
	class AutoJSContext : IDisposable
	{
		#region Unmanaged Interfaces
		
		[Guid("c67d8270-3189-11d3-9885-006008962422"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		interface nsIJSContextStack
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			int GetCount();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			IntPtr Peek();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			IntPtr Pop();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void Push(IntPtr cx);
		}
		
		[Guid("f8e350b9-9f31-451a-8c8f-d10fea26b780"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		interface nsIScriptSecurityManager
		{
			// nsIXPCSecurityManager:
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void CanCreateWrapper(out IntPtr aJSContext, ref Guid aIID, nsISupports aObj, IntPtr aClassInfo, IntPtr aPolicy); // aClassInfo=nsIClassInfo
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void CanCreateInstance(out IntPtr aJSContext, ref Guid aCID);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void CanGetService(out IntPtr aJSContext, ref Guid aCID);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void CanAccess(uint aAction, IntPtr aCallContext, out IntPtr aJSContext, out IntPtr aJSObject, nsISupports aObj, IntPtr aClassInfo, IntPtr aName, IntPtr aPolicy); // aCallContext=nsIXPCNativeCallContext
			

			// nsIScriptSecurityManager:
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void CheckPropertyAccess(out IntPtr aJSContext, out IntPtr aJSObject, [MarshalAs(UnmanagedType.LPStr)] string aClassName, IntPtr aProperty, uint aAction); // aProperty=jsval
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void CheckConnect(out IntPtr aJSContext, nsIURI aTargetURI, [MarshalAs(UnmanagedType.LPStr)] string aClassName, [MarshalAs(UnmanagedType.LPStr)] string aProperty);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void CheckLoadURIFromScript(out IntPtr cx, nsIURI uri);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void CheckLoadURIWithPrincipal(nsIPrincipal aPrincipal, nsIURI uri, uint flags);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void CheckLoadURI(nsIURI from, nsIURI uri, uint flags);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void CheckLoadURIStrWithPrincipal(nsIPrincipal aPrincipal, nsACString uri, uint flags);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void CheckLoadURIStr(nsACString from, nsACString uri, uint flags);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void CheckFunctionAccess(out IntPtr cx, out IntPtr funObj, IntPtr targetObj);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			bool CanExecuteScripts(out IntPtr cx, nsIPrincipal principal);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsIPrincipal GetSubjectPrincipal();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsIPrincipal GetSystemPrincipal();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsIPrincipal GetCertificatePrincipal(nsACString aCertFingerprint, nsACString aSubjectName, nsACString aPrettyName, nsISupports aCert, nsIURI aURI);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsIPrincipal GetCodebasePrincipal(nsIURI aURI);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			short RequestCapability(nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStr)] string capability);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			bool IsCapabilityEnabled([MarshalAs(UnmanagedType.LPStr)] string capability);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void EnableCapability([MarshalAs(UnmanagedType.LPStr)] string capability);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void RevertCapability([MarshalAs(UnmanagedType.LPStr)] string capability);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void DisableCapability([MarshalAs(UnmanagedType.LPStr)] string capability);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void SetCanEnableCapability(nsACString certificateFingerprint, [MarshalAs(UnmanagedType.LPStr)] string capability, short canEnable);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsIPrincipal GetObjectPrincipal(out IntPtr cx, out IntPtr aJSObject);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			bool SubjectPrincipalIsSystem();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void CheckSameOrigin(out IntPtr aJSContext, nsIURI aTargetURI);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void CheckSameOriginURI(nsIURI aSourceURI, nsIURI aTargetURI, bool reportError);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsIPrincipal GetPrincipalFromContext(out IntPtr cx);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsIPrincipal GetChannelPrincipal(IntPtr aChannel); // nsIChannel
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			bool IsSystemPrincipal(nsIPrincipal aPrincipal);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsIPrincipal GetCxSubjectPrincipal(IntPtr cx); // JSContext

			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsIPrincipal getCxSubjectPrincipalAndFrame(IntPtr cx, out IntPtr fp);


		}
		

		[Guid("b8268b9a-2403-44ed-81e3-614075c92034"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]

		interface nsIPrincipal
		{
			// nsISerializable:
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void Read(IntPtr aInputStream); // nsIObjectInputStream
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void Write(IntPtr aOutputStream); // nsIObjectOutputStream
			
			// nsIPrincipal:
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void GetPreferences(out string prefBranch, out string id, out string subjectName, out string grantedList, out string deniedList);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			bool Equals(nsIPrincipal other);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			uint GetHashValue();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			IntPtr GetJSPrincipals(IntPtr aJSContext); // returns: JSPrincipals
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			IntPtr GetSecurityPolicy();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			IntPtr SetSecurityPolicy();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			short CanEnableCapability(out string capability);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void SetCanEnableCapability(out string capability, short canEnable);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			bool IsCapabilityEnabled(out string capability, out IntPtr annotation);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void EnableCapability(out string capability, IntPtr annotation);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void RevertCapability(out string capability, IntPtr annotation);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void DisableCapability(out string capability, IntPtr annotation);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsIURI GetURI();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsIURI GetDomain();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void SetDomain(nsIURI aDomain);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.LPStr)] string GetOrigin();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			bool GetHasCertificate();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void GetFingerprint(nsACString aFingerprint);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void GetPrettyName(nsACString aPrettyName);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			bool Subsumes(nsIPrincipal other);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			void GetSubjectName(nsACString aSubjectName);
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			nsISupports GetCertificate();
		}
		
		[Guid("e7d09265-4c23-4028-b1b0-c99e02aa78f8"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		interface nsIJSRuntimeService
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			IntPtr GetRuntime();
			
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			IntPtr GetBackstagePass(); // nsIXPCScriptable
		}
		

		[StructLayout(LayoutKind.Sequential)]
		struct JSStackFrame
		{
			IntPtr regs;
			IntPtr imacpc;        /* null or interpreter macro call pc */
			IntPtr slots;         /* variables, locals and operand stack */
			IntPtr callobj;       /* lazily created Call object */
			IntPtr argsobj;       /* lazily created arguments object */
			IntPtr varobj;        /* variables object, where vars go */
			IntPtr callee;        /* function or script object */
			public IntPtr script;        /* script being interpreted */
			IntPtr fun;           /* function being called or null */
			IntPtr thisp;         /* "this" pointer if in method */
			uint argc;           /* actual argument count */
			IntPtr argv;          /* base of argument stack slots */
			IntPtr rval;           /* function return value */
			public IntPtr down;          /* previous frame */
			IntPtr annotation;    /* used by Java security */
			IntPtr scopeChain;
			IntPtr blockChain;
			uint sharpDepth;     /* array/object initializer depth */
			IntPtr sharpArray;    /* scope for #n= initializer vars */
			uint flags;          /* frame flags -- see below */
			IntPtr dormantNext;   /* next dormant frame chain */
			IntPtr xmlNamespace;  /* null or default xml namespace in E4X */
			IntPtr displaySave;   /* previous value of display entry for script->staticLevel */
		}


		#endregion
		
		#region Native Members
		
		[DllImport("js3250", CharSet=CharSet.Ansi)]
		static extern IntPtr JS_CompileScriptForPrincipals(IntPtr aJSContext, IntPtr aJSObject, IntPtr aJSPrincipals, string bytes, int length, string filename, int lineNumber);
		
		[DllImport("js3250")]
		static extern IntPtr JS_GetGlobalObject(IntPtr aJSContext);
		
		[DllImport("js3250")]
		static extern IntPtr JS_NewContext(IntPtr aJSRuntime, int stackchunksize);
		
		[DllImport("js3250")]
		static extern void JS_DestroyContextNoGC(IntPtr cx);
		
		[DllImport("js3250")]
		static extern IntPtr JS_BeginRequest(IntPtr cx);
		
		[DllImport("js3250")]
		static extern IntPtr JS_EndRequest(IntPtr cx);
		#endregion
		
		public AutoJSContext()
		{
			// obtain the JS runtime used by gecko
			nsIJSRuntimeService runtimeService = (nsIJSRuntimeService)Xpcom.GetService("@mozilla.org/js/xpc/RuntimeService;1");
			IntPtr jsRuntime = runtimeService.GetRuntime();
			
			// create a new JSContext
			cx = JS_NewContext(jsRuntime, 8192);
			
			// begin a new request
			JS_BeginRequest(cx);
			
			// push the context onto the context stack
			nsIJSContextStack contextStack = Xpcom.GetService<nsIJSContextStack>("@mozilla.org/js/xpc/ContextStack;1");
			contextStack.Push(cx);
			
			// obtain the system principal (no security checks) which we will use when compiling the empty script below
			nsIPrincipal system = Xpcom.GetService<nsIScriptSecurityManager>("@mozilla.org/scriptsecuritymanager;1").GetSystemPrincipal();
			IntPtr jsPrincipals = system.GetJSPrincipals(cx);
			
			// create a fake stack frame
			JSStackFrame frame = new JSStackFrame();
			frame.script = JS_CompileScriptForPrincipals(cx, JS_GetGlobalObject(cx), jsPrincipals, "", 0, "", 1);
			
			// put a pointer to the fake stack frame on the JSContext
			
			// frame.down = cx->fp
			IntPtr old = Marshal.ReadIntPtr(cx, OfsetOfFP);
			frame.down = old;
			
			IntPtr framePtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(JSStackFrame)));
			Marshal.StructureToPtr(frame, framePtr, true);
			
			// cx->fp = framePtr;
			Marshal.WriteIntPtr(cx, OfsetOfFP, framePtr);
		}
		
		//NOTE: these hard-coded field offsets are based on the unmanaged layout of JSContext objects.  this will
		// probably not work for versions other than 1.8, 1.9 and 1.9.1
		const int OfsetOfFP = 0x98;

		
		IntPtr cx;
		
		public void Dispose()
		{
			nsIJSContextStack contextStack = Xpcom.GetService<nsIJSContextStack>("@mozilla.org/js/xpc/ContextStack;1");
			contextStack.Pop();
			
			// free the memory allocated for the fake stack frame
			Marshal.FreeHGlobal(Marshal.ReadIntPtr(cx, OfsetOfFP));
			
			// end the request, destroy the context
			JS_EndRequest(cx);
			JS_DestroyContextNoGC(cx);
		}
	}
}
