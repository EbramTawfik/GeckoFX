namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMStringList : WebIDLBase
    {
        
        public DOMStringList(nsISupports thisObject) : 
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
        
        public bool Contains(nsAString @string)
        {
            return this.CallMethod<bool>("contains", @string);
        }
    }
}
