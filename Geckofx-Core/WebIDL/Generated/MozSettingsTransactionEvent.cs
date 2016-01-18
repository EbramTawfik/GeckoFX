namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozSettingsTransactionEvent : WebIDLBase
    {
        
        public MozSettingsTransactionEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Error
        {
            get
            {
                return this.GetProperty<nsAString>("error");
            }
        }
    }
}
