namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozSettingsTransactionEvent : WebIDLBase
    {
        
        public MozSettingsTransactionEvent(nsISupports thisObject) : 
                base(thisObject)
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
