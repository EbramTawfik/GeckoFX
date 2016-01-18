namespace Gecko.WebIDL
{
    using System;
    
    
    public class UDPSocket : WebIDLBase
    {
        
        public UDPSocket(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string LocalAddress
        {
            get
            {
                return this.GetProperty<string>("localAddress");
            }
        }
        
        public System.Nullable<ushort> LocalPort
        {
            get
            {
                return this.GetProperty<System.Nullable<ushort>>("localPort");
            }
        }
        
        public string RemoteAddress
        {
            get
            {
                return this.GetProperty<string>("remoteAddress");
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
        
        public void JoinMulticastGroup(string multicastGroupAddress)
        {
            this.CallVoidMethod("joinMulticastGroup", multicastGroupAddress);
        }
        
        public void LeaveMulticastGroup(string multicastGroupAddress)
        {
            this.CallVoidMethod("leaveMulticastGroup", multicastGroupAddress);
        }
        
        public bool Send(WebIDLUnion<System.String,nsIDOMBlob,IntPtr,IntPtr> data)
        {
            return this.CallMethod<bool>("send", data);
        }
        
        public bool Send(WebIDLUnion<System.String,nsIDOMBlob,IntPtr,IntPtr> data, string remoteAddress)
        {
            return this.CallMethod<bool>("send", data, remoteAddress);
        }
        
        public bool Send(WebIDLUnion<System.String,nsIDOMBlob,IntPtr,IntPtr> data, string remoteAddress, System.Nullable<ushort> remotePort)
        {
            return this.CallMethod<bool>("send", data, remoteAddress, remotePort);
        }
    }
}
