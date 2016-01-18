namespace Gecko.WebIDL
{
    using System;
    
    
    public class Position : WebIDLBase
    {
        
        public Position(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Coords
        {
            get
            {
                return this.GetProperty<nsISupports>("coords");
            }
        }
        
        public nsISupports Timestamp
        {
            get
            {
                return this.GetProperty<nsISupports>("timestamp");
            }
        }
    }
}
