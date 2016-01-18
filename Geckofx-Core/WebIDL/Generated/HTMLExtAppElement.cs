namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLExtAppElement : WebIDLBase
    {
        
        public HTMLExtAppElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string GetCustomProperty(string name)
        {
            return this.CallMethod<string>("getCustomProperty", name);
        }
        
        public void PostMessage(string name)
        {
            this.CallVoidMethod("postMessage", name);
        }
    }
}
