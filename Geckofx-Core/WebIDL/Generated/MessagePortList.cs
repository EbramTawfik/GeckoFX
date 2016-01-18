namespace Gecko.WebIDL
{
    using System;
    
    
    public class MessagePortList : WebIDLBase
    {
        
        public MessagePortList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
