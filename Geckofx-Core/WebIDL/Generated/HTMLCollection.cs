namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLCollection : WebIDLBase
    {
        
        public HTMLCollection(nsISupports thisObject) : 
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
