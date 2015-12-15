namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaKeyError : WebIDLBase
    {
        
        public MediaKeyError(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint SystemCode
        {
            get
            {
                return this.GetProperty<uint>("systemCode");
            }
        }
    }
}
