using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.WebIDL
{
    public class WebIDLBase
    {
        private readonly nsISupports _thisObject;

        public WebIDLBase(nsISupports thisObject)
        {
            this._thisObject = thisObject;
        }

        public T GetProperty<T>(string propertyName)
        {
            using (var context = new AutoJSContext())
            {
                var jsObject = context.ConvertCOMObjectToJSObject(_thisObject);
                var retObject = SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject, propertyName).ToObject();
                return ConvertObject<T>(retObject);
            }
        }

        public void SetProperty(string propertyName, object value)
        {
            throw new NotImplementedException("Set Property hasn't been implemented yet.");
        }

        public void CallVoidMethod(string methodName, params object[] paramObjects)
        {
            using (var context = new AutoJSContext())
            {
                var jsObject = context.ConvertCOMObjectToJSObject(_thisObject);

                // TODO: convert paramObjects into jsVal array
                SpiderMonkey.JS_CallFunctionName(context.ContextPointer, jsObject, methodName, new JsVal[0]);
            }
        }

        public T CallMethod<T>(string methodName, params object[] paramObjects)
        {
            using (var context = new AutoJSContext())
            {
                var jsObject = context.ConvertCOMObjectToJSObject(_thisObject);

                // TODO: convert paramObjects into jsVal array
                var retObject = SpiderMonkey.JS_CallFunctionName(context.ContextPointer, jsObject, methodName, new JsVal[0]).ToObject();
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
