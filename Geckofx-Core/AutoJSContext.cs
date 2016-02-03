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
using System.Collections;
using System.Runtime.InteropServices;
using Gecko.Interop;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko
{
    /// <summary>
    /// Creates a scoped, fake "system principal" security context.  This class is used primarly to work around bugs in gecko
    /// which prevent methods on nsIDOMCSSStyleSheet from working outside of javascript.
    /// </summary>
    public class AutoJSContext : IDisposable
    {
        #region fields

        private readonly IntPtr _cx;
        private readonly nsIDOMWindow _window;
        private JSAutoCompartment _defaultCompartment;
        private Stack<JSAutoCompartment> _compartmentStack = new Stack<JSAutoCompartment>();
        private nsIXPCComponents _nsIXPCComponents;
        private IntPtr _globalJSObject;

        /// <summary>
        /// These static fields allow AutoJSContext(IntPtr context) to work.
        /// </summary>
        private static Dictionary<IntPtr, IntPtr> _contextToGlobalDictionary = new Dictionary<IntPtr, IntPtr>();

        private static IntPtr _safeContext;

        #endregion

        #region Properties

        public IntPtr ContextPointer
        {
            get { return _cx; }
        }

        #endregion

        #region Connstructors

        public AutoJSContext(GeckoWindow window) :
            this(window.DomWindow)
        {
        }

        public AutoJSContext(nsISupports window) :
            this((nsIDOMWindow) window)
        {
        }

        public AutoJSContext(nsIDOMWindow window)
        {
            var context = SafeJSContext;
            var go = (nsIGlobalObject) window;

            using (var xpc = new ComPtr<nsIGlobalObject>(go, false))
            {
                int slot = xpc.GetSlotOfComMethod(new Func<IntPtr>(go.GetGlobalJSObject));
                var getGlobalJSObject = xpc.GetComMethod<GetGlobalJSObject>(Xpcom.IsLinux ? -1 : slot);
                _globalJSObject = getGlobalJSObject(go);
                if (_globalJSObject == IntPtr.Zero)
                    throw new ArgumentException(
                        "Window does not have a global JSObject. Purhaps the window doesn't have an initalized document?");

                _contextToGlobalDictionary[context] = _globalJSObject;
                _defaultCompartment = new JSAutoCompartment(SafeJSContext, _globalJSObject);
                _cx = context;
                _window = window;
            }
        }

        /// <summary>
        /// Create a AutoJSContext using the SafeJSContext.
        /// If context is IntPtr.Zero use the SafeJSContext
        /// (but SafeJSContext doesn't contain a Global object then try the BackstageJSContext instead)
        /// </summary>
        /// <param name="context"></param>
        [ObsoleteAttribute(
            "This constructor only works if a AutoJSContext(window) has previously been use for the same context.")]
        public AutoJSContext(IntPtr context)
        {
            // We can't just use nsIXPConnect::GetSafeJSContext(); because its marked as [noxpcom, nostdcall]
            // TODO: Enhance IDL compiler to not generate methods for noxpcom, nostdcall tagged methods.
            if (context == IntPtr.Zero)
                context = SafeJSContext;

            _globalJSObject = GetGlobalFromContext(context);
            if (_globalJSObject == IntPtr.Zero)
                throw new InvalidOperationException("JSContext don't store their default compartment object on the cx.");

            _defaultCompartment = new JSAutoCompartment(context, _globalJSObject);
            _cx = context;
        }

        /// <summary>
        /// Create a AutoJSContext using the SafeJSContext.
        /// </summary>
        [ObsoleteAttribute(
            "This constructor only works if a AutoJSContext(window) has previously been use for the SafeJSContext")]
        public AutoJSContext()
            : this(SafeJSContext)
        {
        }

        #endregion

        #region EvaluateScriptMethods

        /// <summary>
        /// Evaluate javascript in the current context, in the global scope.
        /// </summary>
        /// <param name="jsScript"></param>
        /// <param name="result"></param>
        /// <returns>result of javascript as string.</returns>
        public bool EvaluateScript(string jsScript, out string result)
        {
            var ptr = new JsVal();
            bool ret = SpiderMonkey.JS_EvaluateScript(ContextPointer, jsScript, (uint) jsScript.Length, "script", 1,
                ref ptr);

            result = ret ? ConvertValueToString(ptr) : null;
            return ret;
        }

        /// <summary>
        /// Evaluate javascript in specified window.
        /// Throws GeckoJavaScriptException on error.
        /// </summary>
        /// <param name="javascript"></param>
        /// <param name="window"></param>
        /// <returns>result of javascript as JsVal</returns>
        public JsVal EvaluateScript(string javascript, nsIDOMWindow window)
        {
            return EvaluateScript(javascript, (nsISupports) window, (nsISupports) window);
        }

        /// <summary>
        /// Evaluate JavaScript in specified window, and with specified scope.
        /// Throws GeckoJavaScriptException on error.
        /// </summary>
        /// <param name="javascript">The javascript to run.</param>
        /// <param name="window">The window to execuate javascript in. (ie. the global object)</param>
        /// <param name="scope">object to use as scope.</param>
        /// <returns>The return value of the script as a JsVal</returns>
        public JsVal EvaluateScript(string javascript, nsISupports window, nsISupports scope)
        {
            string msg = String.Empty;

            IntPtr globalObject = ConvertCOMObjectToJSObject(window);

            using (new JSAutoCompartment(ContextPointer, globalObject))
            {
                var old = SpiderMonkey.JS_SetErrorReporter(SpiderMonkey.JS_GetRuntime(ContextPointer),
                    (cx, message, report) => { msg = message; });
                try
                {
                    var retJsVal = new JsVal();
                    bool ret;
                    // If not running in window scope.
                    if (window != scope)
                    {
                        var scopeJSVal = JsVal.FromPtr(ConvertCOMObjectToJSObject(scope));
                        if (!SpiderMonkey.JS_SetProperty(ContextPointer, globalObject, "__RequestedScope", scopeJSVal))
                            throw new GeckoException("Failed to set __RequestedScope Property.");

                        javascript = InsertReturnStatement(javascript);
                        string s = "(function() { " + javascript + " }).call(this.__RequestedScope)";

                        ret = SpiderMonkey.JS_EvaluateScript(ContextPointer, s, (uint) s.Length, "script", 1,
                            ref retJsVal);
                    }
                    else
                    {
                        ret = SpiderMonkey.JS_EvaluateScript(ContextPointer, javascript, (uint) javascript.Length,
                            "script", 1, ref retJsVal);
                    }

                    if (!ret)
                        throw new GeckoJavaScriptException(String.Format("JSError : {0}", msg));

                    return retJsVal;
                }
                finally
                {
                    SpiderMonkey.JS_SetErrorReporter(SpiderMonkey.JS_GetRuntime(ContextPointer), old);
                }
            }
        }

        /// <summary>
        /// Evaluate JavaScript in the current context, in the global scope.
        /// Throws GeckoJavaScriptException on error.
        /// </summary>
        /// <param name="javaScript"></param>
        /// <returns></returns>
        public JsVal EvaluateScript(string javaScript)
        {
            return EvaluateScript(javaScript, _window);
        }


        /// <summary>
        /// Evaluate javascript in the current context, using specified scope.
        /// </summary>
        /// <param name="jsScript"></param>
        /// <param name="thisObject">a nsISupports com object that this (the scope) is set too.</param>
        /// <param name="result">The result of the operation as a string.</param>
        /// <returns>true on success, false on failure.</returns>
        public bool EvaluateScript(string jsScript, nsISupports thisObject, out string result)
        {
            result = null;
            try
            {
                result = ConvertValueToString(EvaluateScript(jsScript, (nsISupports) _window, thisObject));
            }
            catch (GeckoJavaScriptException exception)
            {
                return false;
            }

            return true;
        }

        #endregion

        #region static methods

        public static IntPtr SafeJSContext
        {
            get
            {
                if (_safeContext == IntPtr.Zero)
                {
                    // On mono - Marshal.GetComSlotForMethodInfo always return 3 as the the slot of the delegate isn't initalized (default value 0)
                    // So, regrettably we have to hard code the slot value.
                    // If this crashes on a gecko upgrade, then its likely that nsIXPConnect ABI has changed, and the slot number has to be adjusted.
                    const int GetSafeJSContextSlotPosition = 12;

                    ComPtr<nsIXPConnect> xpc = Xpcom.XPConnect;
                    int slot = xpc.GetSlotOfComMethod(new Func<IntPtr>(xpc.Instance.GetSafeJSContext));
                    var getSafeJSContext =
                        xpc.GetComMethod<Xpcom.GetSafeJSContextDelegate>(Xpcom.IsLinux
                            ? GetSafeJSContextSlotPosition
                            : slot);
                    _safeContext = getSafeJSContext(xpc.Instance);
                }
                return _safeContext;
            }
        }

        /// <summary>
        /// Helper method which attempts to find the global object in a Context.
        /// </summary>
        /// <returns>the Global object ptr or Null/Zero ptr if not found.</returns>
        internal static IntPtr GetGlobalFromContext(IntPtr context)
        {
            IntPtr globalObject = IntPtr.Zero;
            if (globalObject == IntPtr.Zero)
            {
                if (_contextToGlobalDictionary.ContainsKey(context))
                    return _contextToGlobalDictionary[context];
            }

            return globalObject;
        }

        #endregion

        #region Non Public methods

        /// <summary>
        /// Helper method for EvaluateScript.
        /// Tries to insert a return statement into a set of js statements that are going to be embeded into a function.
        /// </summary>
        /// <param name="js"></param>
        private string InsertReturnStatement(string js)
        {
            js = js.TrimEnd(' ', ';');
            var semiColons = js.Count(x => x == ';');
            if (semiColons == 0 && !js.Contains("return"))
                return "return " + js + ";";

            var index = Math.Max(js.LastIndexOf(';'), js.LastIndexOf('}'));
            var sub = js.Substring(index + 1);
            if (sub.Contains("return"))
                return js;

            return js.Substring(0, index + 1) + " return " + js.Substring(index + 1) + ";";
        }

        internal string ConvertValueToString(JsVal value)
        {
            if (value.IsString)
            {
                var v = Xpcom.XPConnect.Instance.JSValToVariant(ContextPointer, ref value);
                return nsString.Get(v.GetAsAString);
            }

            // Fallback for non string JsVal's
            // If the JsVal is not a string convert it to a JSString
            // then convert the JSString to a utf8 string.
            // NOTE: This fallback isn't ideal and may cause unicode replacement chars to appear.

            IntPtr jsp = SpiderMonkey.ToStringSlow(ContextPointer, value);
            var utf8StrPtr = SpiderMonkey.JS_EncodeStringToUTF8(ContextPointer, jsp);
            if (utf8StrPtr != IntPtr.Zero)
            {
                try
                {
                    var length = SpiderMonkey.JS_GetStringEncodingLength(ContextPointer, jsp);
                    byte[] result = new byte[length];
                    Marshal.Copy(utf8StrPtr, result, 0, length);
                    return Encoding.UTF8.GetString(result, 0, length);
                }
                finally
                {
                    SpiderMonkey.JS_Free(ContextPointer, utf8StrPtr);
                }
            }
            return null;
        }

        internal IntPtr ConvertCOMObjectToJSObject(nsISupports obj)
        {
            Guid guid = typeof (nsISupports).GUID;

            IntPtr globalObject = GetGlobalFromContext(ContextPointer);

            // In geckofx 45 the WrapNative no longer returns a 'holder'
            return Xpcom.XPConnect.Instance.WrapNative(ContextPointer, globalObject, obj, ref guid);
        }

        /// <summary>
        /// Gets the nsIXPCComponents which is the javascript 'Components' objects
        /// The Components objects is the main object XPConnect object.        
        /// </summary>
        /// <returns></returns>
        internal nsIXPCComponents GetComponentsObject()
        {
            if (_nsIXPCComponents == null)
            {
                var jsValue = new JsVal();
                SpiderMonkey.JS_ExecuteScript(ContextPointer, "this.myfunc = function(p1) { return Components; };",
                    out jsValue);

                jsValue = SpiderMonkey.JS_CallFunctionName(ContextPointer, _globalJSObject, "myfunc", new[] {jsValue});

                _nsIXPCComponents = Xpcom.QueryInterface<nsIXPCComponents>(jsValue.ToObject());
                if (_nsIXPCComponents == null)
                    throw new GeckoException(String.Format(
                        "Components object does not implement nsIXPCComponents. {0}", jsValue));
            }

            return _nsIXPCComponents;
        }

        #endregion

        #region IDisposable implementation.

        public void Dispose()
        {
            if (_defaultCompartment != null)
                _defaultCompartment.Dispose();
            _defaultCompartment = null;

            GC.SuppressFinalize(this);
        }

        #endregion
    }
}