namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozSettingsTransactionEvent : WebIDLBase
    {
        
        public MozSettingsTransactionEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Error
        {
            get
            {
                return this.GetProperty<string>("error");
            }
        }
    }
}
