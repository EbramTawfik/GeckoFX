namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaStreamList : WebIDLBase
    {
        
        public MediaStreamList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
    }
}
