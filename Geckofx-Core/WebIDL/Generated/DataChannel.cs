namespace Gecko.WebIDL
{
    using System;
    
    
    public class DataChannel : WebIDLBase
    {
        
        public DataChannel(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Label
        {
            get
            {
                return this.GetProperty<nsAString>("label");
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
        
        public nsAString Protocol
        {
            get
            {
                return this.GetProperty<nsAString>("protocol");
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
