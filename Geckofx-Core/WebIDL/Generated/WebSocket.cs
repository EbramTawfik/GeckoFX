namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebSocket : WebIDLBase
    {
        
        public WebSocket(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Url
        {
            get
            {
                return this.GetProperty<string>("url");
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
        
        public string Extensions
        {
            get
            {
                return this.GetProperty<string>("extensions");
            }
        }
        
        public string Protocol
        {
            get
            {
                return this.GetProperty<string>("protocol");
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
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public void Close(ushort code)
        {
            this.CallVoidMethod("close", code);
        }
        
        public void Close(ushort code, string reason)
        {
            this.CallVoidMethod("close", code, reason);
        }
        
        public void Send(string data)
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
