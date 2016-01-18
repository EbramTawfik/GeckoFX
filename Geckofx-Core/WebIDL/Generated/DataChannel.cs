namespace Gecko.WebIDL
{
    using System;
    
    
    public class DataChannel : WebIDLBase
    {
        
        public DataChannel(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Label
        {
            get
            {
                return this.GetProperty<string>("label");
            }
        }
        
        public bool Reliable
        {
            get
            {
                return this.GetProperty<bool>("reliable");
            }
        }
        
        public RTCDataChannelState ReadyState
        {
            get
            {
                return this.GetProperty<RTCDataChannelState>("readyState");
            }
        }
        
        public uint BufferedAmount
        {
            get
            {
                return this.GetProperty<uint>("bufferedAmount");
            }
        }
        
        public uint BufferedAmountLowThreshold
        {
            get
            {
                return this.GetProperty<uint>("bufferedAmountLowThreshold");
            }
            set
            {
                this.SetProperty("bufferedAmountLowThreshold", value);
            }
        }
        
        public RTCDataChannelType BinaryType
        {
            get
            {
                return this.GetProperty<RTCDataChannelType>("binaryType");
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
        
        public string Protocol
        {
            get
            {
                return this.GetProperty<string>("protocol");
            }
        }
        
        public bool Ordered
        {
            get
            {
                return this.GetProperty<bool>("ordered");
            }
        }
        
        public ushort Id
        {
            get
            {
                return this.GetProperty<ushort>("id");
            }
        }
        
        public ushort Stream
        {
            get
            {
                return this.GetProperty<ushort>("stream");
            }
        }
    }
}
