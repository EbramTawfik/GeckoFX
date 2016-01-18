namespace Gecko.WebIDL
{
    using System;
    
    
    public class MimeTypeArray : WebIDLBase
    {
        
        public MimeTypeArray(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
