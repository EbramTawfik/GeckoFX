namespace Gecko.WebIDL
{
    using System;
    
    
    public class NodeList : WebIDLBase
    {
        
        public NodeList(nsISupports thisObject) : 
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
