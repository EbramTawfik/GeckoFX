namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozInterAppConnection : WebIDLBase
    {
        
        public MozInterAppConnection(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Keyword
        {
            get
            {
                return this.GetProperty<string>("keyword");
            }
        }
        
        public string Publisher
        {
            get
            {
                return this.GetProperty<string>("publisher");
            }
        }
        
        public string Subscriber
        {
            get
            {
                return this.GetProperty<string>("subscriber");
            }
        }
        
        public void Cancel()
        {
            this.CallVoidMethod("cancel");
        }
    }
}
