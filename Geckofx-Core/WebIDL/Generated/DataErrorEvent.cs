namespace Gecko.WebIDL
{
    using System;
    
    
    public class DataErrorEvent : WebIDLBase
    {
        
        public DataErrorEvent(nsISupports thisObject) : 
                base(thisObject)
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
