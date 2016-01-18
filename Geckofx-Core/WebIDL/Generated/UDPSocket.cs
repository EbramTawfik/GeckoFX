namespace Gecko.WebIDL
{
    using System;
    
    
    public class UDPSocket : WebIDLBase
    {
        
        public UDPSocket(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString LocalAddress
        {
            get
            {
                return this.GetProperty<nsAString>("localAddress");
            }
        }
        
        public System.Nullable<ushort> LocalPort
        {
            get
            {
                return this.GetProperty<System.Nullable<ushort>>("localPort");
            }
        }
        
        public nsAString RemoteAddress
        {
            get
            {
                return this.GetProperty<nsAString>("remoteAddress");
            }
        }
        
        public System.Nullable<ushort> RemotePort
        {
            get
            {
                return this.GetProperty<System.Nullable<ushort>>("remotePort");
            }
        }
        
        public bool AddressReuse
        {
            get
            {
                return this.GetProperty<bool>("addressReuse");
            }
        }
        
        public bool Loopback
        {
            get
            {
                return this.GetProperty<bool>("loopback");
            }
        }
        
        public SocketReadyState ReadyState
        {
            get
            {
                return this.GetProperty<SocketReadyState>("readyState");
            }
        }
        
        public Promise Opened
        {
            get
            {
                return this.GetProperty<Promise>("opened");
            }
        }
        
        public Promise Closed
        {
            get
            {
                return this.GetProperty<Promise>("closed");
            }
        }
        
        public Promise Close()
        {
            return this.CallMethod<Promise>("close");
        }
        
        public void JoinMulticastGroup(nsAString multicastGroupAddress)
        {
            this.CallVoidMethod("joinMulticastGroup", multicastGroupAddress);
        }
        
        public void LeaveMulticastGroup(nsAString multicastGroupAddress)
        {
            this.CallVoidMethod("leaveMulticastGroup", multicastGroupAddress);
        }
        
        public bool Send(WebIDLUnion<nsAString,nsIDOMBlob,IntPtr,IntPtr> data)
        {
            return this.CallMethod<bool>("send", data);
        }
        
        public bool Send(WebIDLUnion<nsAString,nsIDOMBlob,IntPtr,IntPtr> data, nsAString remoteAddress)
        {
            return this.CallMethod<bool>("send", data, remoteAddress);
        }
        
        public bool Send(WebIDLUnion<nsAString,nsIDOMBlob,IntPtr,IntPtr> data, nsAString remoteAddress, System.Nullable<ushort> remotePort)
        {
            return this.CallMethod<bool>("send", data, remoteAddress, remotePort);
        }
    }
}
