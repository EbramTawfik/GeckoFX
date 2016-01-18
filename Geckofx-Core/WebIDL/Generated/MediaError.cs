namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaError : WebIDLBase
    {
        
        public MediaError(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
