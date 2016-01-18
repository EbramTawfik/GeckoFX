namespace Gecko.WebIDL
{
    using System;
    
    
    public class TCPSocket : WebIDLBase
    {
        
        public TCPSocket(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public USVString Host
        {
            get
            {
                return this.GetProperty<USVString>("host");
            }
        }
        
        public ushort Port
        {
            get
            {
                return this.GetProperty<ushort>("port");
            }
        }
        
        public bool Ssl
        {
            get
            {
                return this.GetProperty<bool>("ssl");
            }
        }
        
        public ulong BufferedAmount
        {
            get
            {
                return this.GetProperty<ulong>("bufferedAmount");
            }
        }
        
        public TCPReadyState ReadyState
        {
            get
            {
                return this.GetProperty<TCPReadyState>("readyState");
            }
        }
        
        public TCPSocketBinaryType BinaryType
        {
            get
            {
                return this.GetProperty<TCPSocketBinaryType>("binaryType");
            }
        }
        
        public void UpgradeToSecure()
        {
            this.CallVoidMethod("upgradeToSecure");
        }
        
        public void Suspend()
        {
            this.CallVoidMethod("suspend");
        }
        
        public void Resume()
        {
            this.CallVoidMethod("resume");
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public bool Send(ByteString data)
        {
            return this.CallMethod<bool>("send", data);
        }
        
        public bool Send(IntPtr data)
        {
            return this.CallMethod<bool>("send", data);
        }
        
        public bool Send(IntPtr data, uint byteOffset)
        {
            return this.CallMethod<bool>("send", data, byteOffset);
        }
        
        public bool Send(IntPtr data, uint byteOffset, uint byteLength)
        {
            return this.CallMethod<bool>("send", data, byteOffset, byteLength);
        }
    }
}
