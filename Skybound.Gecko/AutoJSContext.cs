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
using System.Text;

namespace Gecko
{
	/// <summary>
	/// Creates a scoped, fake "system principal" security context.  This class is used primarly to work around bugs in gecko
	/// which prevent methods on nsIDOMCSSStyleSheet from working outside of javascript.
	/// </summary>
	public class AutoJSContext : IDisposable
	{	
		#region Native Members

		[StructLayout(LayoutKind.Explicit)]
		private struct JSVal
		{
			[FieldOffset(0)]
			Int64 data;
		}

		[DllImport("mozjs", CharSet=CharSet.Ansi)]
		static extern IntPtr JS_CompileScriptForPrincipals(IntPtr aJSContext, IntPtr aJSObject, IntPtr aJSPrincipals, string bytes, int length, string filename, int lineNumber);
		
		[DllImport("mozjs")]
		static extern IntPtr JS_GetGlobalObject(IntPtr aJSContext);

		[DllImport("mozjs")]
		static extern IntPtr JS_NewContext(IntPtr aJSRuntime, int stackchunksize);

		[DllImport("mozjs")]
		static extern void JS_DestroyContextNoGC(IntPtr cx);

		[DllImport("mozjs")]
		static extern IntPtr JS_BeginRequest(IntPtr cx);

		[DllImport("mozjs")]
		static extern IntPtr JS_EndRequest(IntPtr cx);
		
		[DllImport("mozjs", CharSet = CharSet.Ansi)]
		static extern bool JS_EvaluateScript(IntPtr cx, IntPtr obj, string src, UInt32 length, string filename, UInt32 lineno, ref JSVal jsval);				
		
		[DllImport("mozjs")]
		static extern IntPtr JS_GetGlobalForScopeChain(IntPtr aJSContext);
		
		[DllImport("mozjs")]
		static extern bool JS_InitStandardClasses(IntPtr cx, IntPtr obj);

		[DllImport("mozjs")]
		static extern IntPtr JS_ValueToString(IntPtr cx, JSVal v);

		[DllImport("mozjs")]
		static extern IntPtr JS_EncodeString(IntPtr cx, IntPtr jsString);

		#endregion

		IntPtr _cx;

		public IntPtr ContextPointer { get { return _cx; } }

		public AutoJSContext()
		{
			var jsContextStack = Xpcom.GetService<nsIThreadJSContextStack>("@mozilla.org/js/xpc/ContextStack;1");
			_cx = jsContextStack.GetSafeJSContextAttribute();
			
			// begin a new request
			JS_BeginRequest(_cx);
			
			// push the context onto the context stack
			nsIJSContextStack contextStack = Xpcom.GetService<nsIJSContextStack>("@mozilla.org/js/xpc/ContextStack;1");
			contextStack.Push(_cx);
			
			// obtain the system principal (no security checks)
			nsIScriptSecurityManager securityManager = Xpcom.GetService<nsIScriptSecurityManager>("@mozilla.org/scriptsecuritymanager;1");
			nsIPrincipal system = securityManager.GetSystemPrincipal();
			IntPtr jsPrincipals = system.GetJSPrincipals(_cx);

			securityManager.PushContextPrincipal(_cx, IntPtr.Zero, system);
		}

		/// <summary>
		/// Evaluate javascript in the current context.
		/// </summary>
		/// <param name="jsScript"></param>
		/// <param name="jsval"></param>
		/// <returns></returns>
		public bool EvaluateScript(string jsScript, out string result)
		{
			JSVal ptr = new JSVal();
			IntPtr globalObject = AutoJSContext.JS_GetGlobalForScopeChain(_cx);
			bool ret = AutoJSContext.JS_EvaluateScript(_cx, globalObject, jsScript, (uint)jsScript.Length, "script", 1, ref ptr);		

			IntPtr jsStringPtr = JS_ValueToString(_cx, ptr);
			result = Marshal.PtrToStringAnsi(JS_EncodeString(_cx, jsStringPtr));
			return ret;
		}		

		public void Dispose()
		{
			nsIScriptSecurityManager securityManager = Xpcom.GetService<nsIScriptSecurityManager>("@mozilla.org/scriptsecuritymanager;1");

			securityManager.PopContextPrincipal(_cx);

			nsIJSContextStack contextStack = Xpcom.GetService<nsIJSContextStack>("@mozilla.org/js/xpc/ContextStack;1");
			contextStack.Pop();
			JS_EndRequest(_cx);
		}
	}
}
