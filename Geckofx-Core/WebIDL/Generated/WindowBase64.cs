namespace Gecko.WebIDL
{
    using System;
    
    
    public class WindowBase64 : WebIDLBase
    {
        
        public WindowBase64(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Btoa(string btoa)
        {
            return this.CallMethod<string>("btoa", btoa);
        }
        
        public string Atob(string atob)
        {
            return this.CallMethod<string>("atob", atob);
        }
    }
}
