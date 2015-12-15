namespace Gecko.WebIDL
{
    using System;
    
    
    public class IccChangeEvent : WebIDLBase
    {
        
        public IccChangeEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString IccId
        {
            get
            {
                return this.GetProperty<nsAString>("iccId");
            }
        }
    }
}
