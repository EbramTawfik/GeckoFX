namespace Gecko.WebIDL
{
    using System;
    
    
    public class RecordErrorEvent : WebIDLBase
    {
        
        public RecordErrorEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
    }
}
