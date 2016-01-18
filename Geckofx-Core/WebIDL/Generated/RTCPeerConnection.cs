namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCPeerConnection : WebIDLBase
    {
        
        public RTCPeerConnection(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports LocalDescription
        {
            get
            {
                return this.GetProperty<nsISupports>("localDescription");
            }
        }
        
        public nsISupports RemoteDescription
        {
            get
            {
                return this.GetProperty<nsISupports>("remoteDescription");
            }
        }
        
        public RTCSignalingState SignalingState
        {
            get
            {
                return this.GetProperty<RTCSignalingState>("signalingState");
            }
        }
        
        public RTCIceGatheringState IceGatheringState
        {
            get
            {
                return this.GetProperty<RTCIceGatheringState>("iceGatheringState");
            }
        }
        
        public RTCIceConnectionState IceConnectionState
        {
            get
            {
                return this.GetProperty<RTCIceConnectionState>("iceConnectionState");
            }
        }
        
        public Promise <object> PeerIdentity
        {
            get
            {
                return this.GetProperty<Promise <object>>("peerIdentity");
            }
        }
        
        public string IdpLoginUrl
        {
            get
            {
                return this.GetProperty<string>("idpLoginUrl");
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
        
        public void SetIdentityProvider(string provider)
        {
            this.CallVoidMethod("setIdentityProvider", provider);
        }
        
        public void SetIdentityProvider(string provider, string protocol)
        {
            this.CallVoidMethod("setIdentityProvider", provider, protocol);
        }
        
        public void SetIdentityProvider(string provider, string protocol, string username)
        {
            this.CallVoidMethod("setIdentityProvider", provider, protocol, username);
        }
        
        public Promise <string> GetIdentityAssertion()
        {
            return this.CallMethod<Promise <string>>("getIdentityAssertion");
        }
        
        public Promise < nsISupports > CreateOffer()
        {
            return this.CallMethod<Promise < nsISupports >>("createOffer");
        }
        
        public Promise < nsISupports > CreateOffer(object options)
        {
            return this.CallMethod<Promise < nsISupports >>("createOffer", options);
        }
        
        public Promise < nsISupports > CreateAnswer()
        {
            return this.CallMethod<Promise < nsISupports >>("createAnswer");
        }
        
        public Promise < nsISupports > CreateAnswer(object options)
        {
            return this.CallMethod<Promise < nsISupports >>("createAnswer", options);
        }
        
        public Promise SetLocalDescription(nsISupports description)
        {
            return this.CallMethod<Promise>("setLocalDescription", description);
        }
        
        public Promise SetRemoteDescription(nsISupports description)
        {
            return this.CallMethod<Promise>("setRemoteDescription", description);
        }
        
        public void UpdateIce()
        {
            this.CallVoidMethod("updateIce");
        }
        
        public void UpdateIce(object configuration)
        {
            this.CallVoidMethod("updateIce", configuration);
        }
        
        public Promise AddIceCandidate(nsISupports candidate)
        {
            return this.CallMethod<Promise>("addIceCandidate", candidate);
        }
        
        public object GetConfiguration()
        {
            return this.CallMethod<object>("getConfiguration");
        }
        
        public nsISupports[] GetLocalStreams()
        {
            return this.CallMethod<nsISupports[]>("getLocalStreams");
        }
        
        public nsISupports[] GetRemoteStreams()
        {
            return this.CallMethod<nsISupports[]>("getRemoteStreams");
        }
        
        public nsISupports GetStreamById(string streamId)
        {
            return this.CallMethod<nsISupports>("getStreamById", streamId);
        }
        
        public void AddStream(nsISupports stream)
        {
            this.CallVoidMethod("addStream", stream);
        }
        
        public void RemoveStream(nsISupports stream)
        {
            this.CallVoidMethod("removeStream", stream);
        }
        
        public nsISupports AddTrack(nsISupports track, nsISupports stream, nsISupports moreStreams)
        {
            return this.CallMethod<nsISupports>("addTrack", track, stream, moreStreams);
        }
        
        public void RemoveTrack(nsISupports sender)
        {
            this.CallVoidMethod("removeTrack", sender);
        }
        
        public nsISupports[] GetSenders()
        {
            return this.CallMethod<nsISupports[]>("getSenders");
        }
        
        public nsISupports[] GetReceivers()
        {
            return this.CallMethod<nsISupports[]>("getReceivers");
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public Promise < nsISupports > GetStats()
        {
            return this.CallMethod<Promise < nsISupports >>("getStats");
        }
        
        public Promise < nsISupports > GetStats(nsISupports selector)
        {
            return this.CallMethod<Promise < nsISupports >>("getStats", selector);
        }
        
        public nsISupports CreateDataChannel(string label)
        {
            return this.CallMethod<nsISupports>("createDataChannel", label);
        }
        
        public nsISupports CreateDataChannel(string label, object dataChannelDict)
        {
            return this.CallMethod<nsISupports>("createDataChannel", label, dataChannelDict);
        }
    }
}
