namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozApplicationEvent : WebIDLBase
    {
        
        public MozApplicationEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Application
        {
            get
            {
                return this.GetProperty<nsISupports>("application");
            }
        }
    }
}
