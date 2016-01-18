namespace Gecko.WebIDL
{
    using System;
    
    
    public class PeerConnectionImpl : WebIDLBase
    {
        
        public PeerConnectionImpl(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Certificate
        {
            get
            {
                return this.GetProperty<nsISupports>("certificate");
            }
            set
            {
                this.SetProperty("certificate", value);
            }
        }
        
        public string Fingerprint
        {
            get
            {
                return this.GetProperty<string>("fingerprint");
            }
        }
        
        public string LocalDescription
        {
            get
            {
                return this.GetProperty<string>("localDescription");
            }
        }
        
        public string RemoteDescription
        {
            get
            {
                return this.GetProperty<string>("remoteDescription");
            }
        }
        
        public PCImplIceConnectionState IceConnectionState
        {
            get
            {
                return this.GetProperty<PCImplIceConnectionState>("iceConnectionState");
            }
        }
        
        public PCImplIceGatheringState IceGatheringState
        {
            get
            {
                return this.GetProperty<PCImplIceGatheringState>("iceGatheringState");
            }
        }
        
        public PCImplSignalingState SignalingState
        {
            get
            {
                return this.GetProperty<PCImplSignalingState>("signalingState");
            }
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
            set
            {
                this.SetProperty("id", value);
            }
        }
        
        public string PeerIdentity
        {
            get
            {
                return this.GetProperty<string>("peerIdentity");
            }
            set
            {
                this.SetProperty("peerIdentity", value);
            }
        }
        
        public bool PrivacyRequested
        {
            get
            {
                return this.GetProperty<bool>("privacyRequested");
            }
        }
        
        public void Initialize(nsISupports observer, nsIDOMWindow window, object iceServers, nsISupports thread)
        {
            this.CallVoidMethod("initialize", observer, window, iceServers, thread);
        }
        
        public void CreateOffer()
        {
            this.CallVoidMethod("createOffer");
        }
        
        public void CreateOffer(object options)
        {
            this.CallVoidMethod("createOffer", options);
        }
        
        public void CreateAnswer()
        {
            this.CallVoidMethod("createAnswer");
        }
        
        public void SetLocalDescription(int action, string sdp)
        {
            this.CallVoidMethod("setLocalDescription", action, sdp);
        }
        
        public void SetRemoteDescription(int action, string sdp)
        {
            this.CallVoidMethod("setRemoteDescription", action, sdp);
        }
        
        public void GetStats(nsISupports selector)
        {
            this.CallVoidMethod("getStats", selector);
        }
        
        public void AddTrack(nsISupports track, nsISupports streams)
        {
            this.CallVoidMethod("addTrack", track, streams);
        }
        
        public void RemoveTrack(nsISupports track)
        {
            this.CallVoidMethod("removeTrack", track);
        }
        
        public void ReplaceTrack(nsISupports thisTrack, nsISupports withTrack)
        {
            this.CallVoidMethod("replaceTrack", thisTrack, withTrack);
        }
        
        public void CloseStreams()
        {
            this.CallVoidMethod("closeStreams");
        }
        
        public nsISupports[] GetLocalStreams()
        {
            return this.CallMethod<nsISupports[]>("getLocalStreams");
        }
        
        public nsISupports[] GetRemoteStreams()
        {
            return this.CallMethod<nsISupports[]>("getRemoteStreams");
        }
        
        public void AddIceCandidate(string candidate, string mid, ushort level)
        {
            this.CallVoidMethod("addIceCandidate", candidate, mid, level);
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public bool PluginCrash(ulong pluginId, string name)
        {
            return this.CallMethod<bool>("pluginCrash", pluginId, name);
        }
        
        public nsISupports CreateDataChannel(string label, string protocol, ushort type, bool outOfOrderAllowed, ushort maxTime, ushort maxNum, bool externalNegotiated, ushort stream)
        {
            return this.CallMethod<nsISupports>("createDataChannel", label, protocol, type, outOfOrderAllowed, maxTime, maxNum, externalNegotiated, stream);
        }
    }
}
