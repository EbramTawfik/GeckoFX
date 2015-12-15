namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebSocket : WebIDLBase
    {
        
        public WebSocket(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Url
        {
            get
            {
                return this.GetProperty<nsAString>("url");
            }
        }
        
        public ushort ReadyState
        {
            get
            {
                return this.GetProperty<ushort>("readyState");
            }
        }
        
        public uint BufferedAmount
        {
            get
            {
                return this.GetProperty<uint>("bufferedAmount");
            }
        }
        
        public nsAString Extensions
        {
            get
            {
                return this.GetProperty<nsAString>("extensions");
            }
        }
        
        public nsAString Protocol
        {
            get
            {
                return this.GetProperty<nsAString>("protocol");
            }
        }
        
        public BinaryType BinaryType
        {
            get
            {
                return this.GetProperty<BinaryType>("binaryType");
            }
            set
            {
                this.SetProperty("binaryType", value);
            }
        }
        
        public void Close(ushort code, nsAString reason)
        {
            this.CallVoidMethod("close", code, reason);
        }
        
        public void Send(nsAString data)
        {
            this.CallVoidMethod("send", data);
        }
        
        public void Send(nsIDOMBlob data)
        {
            this.CallVoidMethod("send", data);
        }
        
        public void Send(IntPtr data)
        {
            this.CallVoidMethod("send", data);
        }
    }
}
