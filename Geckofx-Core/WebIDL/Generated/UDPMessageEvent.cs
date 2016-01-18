namespace Gecko.WebIDL
{
    using System;
    
    
    public class UDPMessageEvent : WebIDLBase
    {
        
        public UDPMessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString RemoteAddress
        {
            get
            {
                return this.GetProperty<nsAString>("remoteAddress");
            }
        }
        
        public ushort RemotePort
        {
            get
            {
                return this.GetProperty<ushort>("remotePort");
            }
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
