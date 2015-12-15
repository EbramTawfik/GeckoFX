namespace Gecko.WebIDL
{
    using System;
    
    
    public class PresentationAvailability : WebIDLBase
    {
        
        public PresentationAvailability(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool Value
        {
            get
            {
                return this.GetProperty<bool>("value");
            }
        }
    }
}
