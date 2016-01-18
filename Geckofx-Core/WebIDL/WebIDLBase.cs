using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.WebIDL
{
    public class WebIDLBase
    {
        private readonly nsISupports _thisObject;
        private readonly nsIDOMWindow _globalWindow;        

        public WebIDLBase(nsIDOMWindow globalWindow, nsISupports thisObject)
        {
            _globalWindow = globalWindow;
            _thisObject = thisObject;
        }

        public T GetProperty<T>(string propertyName)
        {
            using (var context = new AutoJSContext(_globalWindow))
            {
                var jsObject = context.ConvertCOMObjectToJSObject(_thisObject);
                var result = SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject, propertyName);
                if (result.IsUndefined)
                    throw new GeckoException(String.Format("Property {0} of type {1} does not exist on object", propertyName, typeof(T).Name));
                var retObject = result.ToObject();
                return ConvertObject<T>(retObject);
            }
        }

        public void SetProperty(string propertyName, object value)
        {
            throw new NotImplementedException("Set Property hasn't been implemented yet.");
        }

        public void CallVoidMethod(string methodName, params object[] paramObjects)
        {
            using (var context = new AutoJSContext(_globalWindow))
            {
                var jsObject = context.ConvertCOMObjectToJSObject(_thisObject);

                // TODO: convert paramObjects into jsVal array
                var collection = new List<JsVal>();
                // TODO: remove code dup with CallMethod
#if true
                foreach (var p in paramObjects)
                {
                    JsVal val;
                    if (p is string)
                        SpiderMonkey.JS_ExecuteScript(context.ContextPointer, '"' + p.ToString() + '"', out val);
                    else
                        SpiderMonkey.JS_ExecuteScript(context.ContextPointer, p.ToString(), out val);
                    collection.Add(val);                    
                }                
#else
                //var val = SpiderMonkey.JS_GetNegativeInfinityValue(context.ContextPointer);
                //var val = SpiderMonkey.JS_ParseJSON(context.ContextPointer, "something");
                JsVal val;
                SpiderMonkey.JS_ExecuteScript(context.ContextPointer, "1", out val);

                collection.Add(val);
                
#endif
                SpiderMonkey.JS_CallFunctionName(context.ContextPointer, jsObject, methodName, collection.ToArray() );
            }
        }

        public T CallMethod<T>(string methodName, params object[] paramObjects)
        {
            using (var context = new AutoJSContext(_globalWindow))
            {
                var jsObject = context.ConvertCOMObjectToJSObject(_thisObject);

                var collection = new List<JsVal>();
                foreach (var p in paramObjects)
                {
                    JsVal val;
                    if (p is nsAString || p is nsACString || p is nsAUTF8String)
                        SpiderMonkey.JS_ExecuteScript(context.ContextPointer, '"' + p.ToString() + '"', out val);
                    else if (p is nsISupports)
                    {
                        // This returns a  [xpconnect wrapped nsISupports] - why may or may not be good enought - if not could try and access the objects wrappedJSObject property?
                        val = SpiderMonkey.JS_CallFunctionName(context.ContextPointer, jsObject, "valueOf");
                    }
                    else
                        SpiderMonkey.JS_ExecuteScript(context.ContextPointer, p.ToString(), out val);
                    collection.Add(val);
                }      
                var retObject = SpiderMonkey.JS_CallFunctionName(context.ContextPointer, jsObject, methodName, collection.ToArray()).ToObject();
                return ConvertObject<T>(retObject);
            }
        }

        private T ConvertObject<T>(object o)
        {
            if (typeof(T).IsValueType)
                return (T)Convert.ChangeType(o, typeof(T));
            else
                return (T)o;
        }
    }
}
