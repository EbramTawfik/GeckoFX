namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMRectList : WebIDLBase
    {
        
        public DOMRectList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
