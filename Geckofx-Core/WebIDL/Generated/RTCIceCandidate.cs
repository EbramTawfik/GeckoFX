namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCIceCandidate : WebIDLBase
    {
        
        public RTCIceCandidate(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Candidate
        {
            get
            {
                return this.GetProperty<nsAString>("candidate");
            }
            set
            {
                this.SetProperty("candidate", value);
            }
        }
        
        public nsAString SdpMid
        {
            get
            {
                return this.GetProperty<nsAString>("sdpMid");
            }
            set
            {
                this.SetProperty("sdpMid", value);
            }
        }
        
        public System.Nullable<ushort> SdpMLineIndex
        {
            get
            {
                return this.GetProperty<System.Nullable<ushort>>("sdpMLineIndex");
            }
            set
            {
                this.SetProperty("sdpMLineIndex", value);
            }
        }
    }
}
