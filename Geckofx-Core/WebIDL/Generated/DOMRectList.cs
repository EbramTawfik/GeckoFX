namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMRectList : WebIDLBase
    {
        
        public DOMRectList(nsISupports thisObject) : 
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
