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
        
        public nsAString Fingerprint
        {
            get
            {
                return this.GetProperty<nsAString>("fingerprint");
            }
        }
        
        public nsAString LocalDescription
        {
            get
            {
                return this.GetProperty<nsAString>("localDescription");
            }
        }
        
        public nsAString RemoteDescription
        {
            get
            {
                return this.GetProperty<nsAString>("remoteDescription");
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
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
            }
            set
            {
                this.SetProperty("id", value);
            }
        }
        
        public nsAString PeerIdentity
        {
            get
            {
                return this.GetProperty<nsAString>("peerIdentity");
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
        
        public void SetLocalDescription(int action, nsAString sdp)
        {
            this.CallVoidMethod("setLocalDescription", action, sdp);
        }
        
        public void SetRemoteDescription(int action, nsAString sdp)
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
        
        public void AddIceCandidate(nsAString candidate, nsAString mid, ushort level)
        {
            this.CallVoidMethod("addIceCandidate", candidate, mid, level);
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public bool PluginCrash(ulong pluginId, nsAString name)
        {
            return this.CallMethod<bool>("pluginCrash", pluginId, name);
        }
        
        public nsISupports CreateDataChannel(nsAString label, nsAString protocol, ushort type, bool outOfOrderAllowed, ushort maxTime, ushort maxNum, bool externalNegotiated, ushort stream)
        {
            return this.CallMethod<nsISupports>("createDataChannel", label, protocol, type, outOfOrderAllowed, maxTime, maxNum, externalNegotiated, stream);
        }
    }
}
