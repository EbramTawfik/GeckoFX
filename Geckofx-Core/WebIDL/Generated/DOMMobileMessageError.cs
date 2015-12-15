namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMMobileMessageError : WebIDLBase
    {
        
        public DOMMobileMessageError(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public WebIDLUnion<nsISupports,nsISupports> Data
        {
            get
            {
                return this.GetProperty<WebIDLUnion<nsISupports,nsISupports>>("data");
            }
        }
    }
}
