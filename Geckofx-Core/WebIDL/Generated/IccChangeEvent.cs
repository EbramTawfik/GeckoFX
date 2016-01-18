namespace Gecko.WebIDL
{
    using System;
    
    
    public class IccChangeEvent : WebIDLBase
    {
        
        public IccChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string IccId
        {
            get
            {
                return this.GetProperty<string>("iccId");
            }
        }
    }
}
