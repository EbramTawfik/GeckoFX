namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCSessionDescription : WebIDLBase
    {
        
        public RTCSessionDescription(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public RTCSdpType Type
        {
            get
            {
                return this.GetProperty<RTCSdpType>("type");
            }
            set
            {
                this.SetProperty("type", value);
            }
        }
        
        public string Sdp
        {
            get
            {
                return this.GetProperty<string>("sdp");
            }
            set
            {
                this.SetProperty("sdp", value);
            }
        }
    }
}
