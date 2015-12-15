namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLExtAppElement : WebIDLBase
    {
        
        public HTMLExtAppElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString GetCustomProperty(nsAString name)
        {
            return this.CallMethod<nsAString>("getCustomProperty", name);
        }
        
        public void PostMessage(nsAString name)
        {
            this.CallVoidMethod("postMessage", name);
        }
    }
}
