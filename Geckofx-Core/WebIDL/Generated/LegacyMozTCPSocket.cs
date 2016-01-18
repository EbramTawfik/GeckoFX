namespace Gecko.WebIDL
{
    using System;
    
    
    public class LegacyMozTCPSocket : WebIDLBase
    {
        
        public LegacyMozTCPSocket(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Open(string host, ushort port)
        {
            return this.CallMethod<nsISupports>("open", host, port);
        }
        
        public nsISupports Open(string host, ushort port, object options)
        {
            return this.CallMethod<nsISupports>("open", host, port, options);
        }
        
        public nsISupports Listen(ushort port)
        {
            return this.CallMethod<nsISupports>("listen", port);
        }
        
        public nsISupports Listen(ushort port, object options)
        {
            return this.CallMethod<nsISupports>("listen", port, options);
        }
        
        public nsISupports Listen(ushort port, object options, ushort backlog)
        {
            return this.CallMethod<nsISupports>("listen", port, options, backlog);
        }
    }
}
