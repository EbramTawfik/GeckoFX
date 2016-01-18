namespace Gecko.WebIDL
{
    using System;
    
    
    public class DataErrorEvent : WebIDLBase
    {
        
        public DataErrorEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Message
        {
            get
            {
                return this.GetProperty<nsAString>("message");
            }
        }
    }
}
