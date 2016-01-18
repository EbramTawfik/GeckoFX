namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCIceCandidate : WebIDLBase
    {
        
        public RTCIceCandidate(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Candidate
        {
            get
            {
                return this.GetProperty<string>("candidate");
            }
            set
            {
                this.SetProperty("candidate", value);
            }
        }
        
        public string SdpMid
        {
            get
            {
                return this.GetProperty<string>("sdpMid");
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
