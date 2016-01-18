namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozInterAppConnection : WebIDLBase
    {
        
        public MozInterAppConnection(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Keyword
        {
            get
            {
                return this.GetProperty<nsAString>("keyword");
            }
        }
        
        public nsAString Publisher
        {
            get
            {
                return this.GetProperty<nsAString>("publisher");
            }
        }
        
        public nsAString Subscriber
        {
            get
            {
                return this.GetProperty<nsAString>("subscriber");
            }
        }
        
        public void Cancel()
        {
            this.CallVoidMethod("cancel");
        }
    }
}
