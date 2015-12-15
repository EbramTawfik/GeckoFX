namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaError : WebIDLBase
    {
        
        public MediaError(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public ushort Code
        {
            get
            {
                return this.GetProperty<ushort>("code");
            }
        }
    }
}
