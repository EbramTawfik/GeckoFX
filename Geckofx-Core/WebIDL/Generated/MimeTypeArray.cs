namespace Gecko.WebIDL
{
    using System;
    
    
    public class MimeTypeArray : WebIDLBase
    {
        
        public MimeTypeArray(nsISupports thisObject) : 
                base(thisObject)
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
