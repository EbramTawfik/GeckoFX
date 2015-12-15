namespace Gecko.WebIDL
{
    using System;
    
    
    public class WindowBase64 : WebIDLBase
    {
        
        public WindowBase64(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Btoa(nsAString btoa)
        {
            return this.CallMethod<nsAString>("btoa", btoa);
        }
        
        public nsAString Atob(nsAString atob)
        {
            return this.CallMethod<nsAString>("atob", atob);
        }
    }
}
