namespace Gecko.WebIDL
{
    using System;
    
    
    public class LegacyMozTCPSocket : WebIDLBase
    {
        
        public LegacyMozTCPSocket(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Open(nsAString host, ushort port, object options)
        {
            return this.CallMethod<nsISupports>("open", host, port, options);
        }
        
        public nsISupports Listen(ushort port, object options, ushort backlog)
        {
            return this.CallMethod<nsISupports>("listen", port, options, backlog);
        }
    }
}
