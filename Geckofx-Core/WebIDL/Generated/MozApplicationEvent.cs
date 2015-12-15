namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozApplicationEvent : WebIDLBase
    {
        
        public MozApplicationEvent(nsISupports thisObject) : 
                base(thisObject)
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
