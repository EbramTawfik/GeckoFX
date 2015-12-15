namespace Gecko.WebIDL
{
    using System;
    
    
    public class Position : WebIDLBase
    {
        
        public Position(nsISupports thisObject) : 
                base(thisObject)
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
