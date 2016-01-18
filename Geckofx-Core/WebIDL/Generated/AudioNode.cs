namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioNode : WebIDLBase
    {
        
        public AudioNode(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Context
        {
            get
            {
                return this.GetProperty<nsISupports>("context");
            }
        }
        
        public uint NumberOfInputs
        {
            get
            {
                return this.GetProperty<uint>("numberOfInputs");
            }
        }
        
        public uint NumberOfOutputs
        {
            get
            {
                return this.GetProperty<uint>("numberOfOutputs");
            }
        }
        
        public uint ChannelCount
        {
            get
            {
                return this.GetProperty<uint>("channelCount");
            }
            set
            {
                this.SetProperty("channelCount", value);
            }
        }
        
        public ChannelCountMode ChannelCountMode
        {
            get
            {
                return this.GetProperty<ChannelCountMode>("channelCountMode");
            }
            set
            {
                this.SetProperty("channelCountMode", value);
            }
        }
        
        public ChannelInterpretation ChannelInterpretation
        {
            get
            {
                return this.GetProperty<ChannelInterpretation>("channelInterpretation");
            }
            set
            {
                this.SetProperty("channelInterpretation", value);
            }
        }
        
        public nsISupports Connect(nsISupports destination)
        {
            return this.CallMethod<nsISupports>("connect", destination);
        }
        
        public nsISupports Connect(nsISupports destination, uint output)
        {
            return this.CallMethod<nsISupports>("connect", destination, output);
        }
        
        public nsISupports Connect(nsISupports destination, uint output, uint input)
        {
            return this.CallMethod<nsISupports>("connect", destination, output, input);
        }
        
        public void Disconnect()
        {
            this.CallVoidMethod("disconnect");
        }
        
        public void Disconnect(uint output)
        {
            this.CallVoidMethod("disconnect", output);
        }
        
        public uint Id
        {
            get
            {
                return this.GetProperty<uint>("id");
            }
        }
    }
}
