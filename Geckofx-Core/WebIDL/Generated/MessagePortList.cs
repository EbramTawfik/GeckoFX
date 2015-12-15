namespace Gecko.WebIDL
{
    using System;
    
    
    public class MessagePortList : WebIDLBase
    {
        
        public MessagePortList(nsISupports thisObject) : 
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
