namespace Gecko.WebIDL
{
    using System;
    
    
    public class CallsList : WebIDLBase
    {
        
        public CallsList(nsISupports thisObject) : 
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
