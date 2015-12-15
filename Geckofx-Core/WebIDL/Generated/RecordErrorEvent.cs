namespace Gecko.WebIDL
{
    using System;
    
    
    public class RecordErrorEvent : WebIDLBase
    {
        
        public RecordErrorEvent(nsISupports thisObject) : 
                base(thisObject)
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
