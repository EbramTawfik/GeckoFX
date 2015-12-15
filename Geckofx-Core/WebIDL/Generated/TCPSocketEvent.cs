namespace Gecko.WebIDL
{
    using System;
    
    
    public class TCPSocketEvent : WebIDLBase
    {
        
        public TCPSocketEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public object Data
        {
            get
            {
                return this.GetProperty<object>("data");
            }
        }
    }
}
