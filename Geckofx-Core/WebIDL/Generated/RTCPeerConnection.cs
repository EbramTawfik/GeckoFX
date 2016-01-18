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
        
        public nsAString IdpLoginUrl
        {
            get
            {
                return this.GetProperty<nsAString>("idpLoginUrl");
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
        
        public void SetIdentityProvider(nsAString provider)
        {
            this.CallVoidMethod("setIdentityProvider", provider);
        }
        
        public void SetIdentityProvider(nsAString provider, nsAString protocol)
        {
            this.CallVoidMethod("setIdentityProvider", provider, protocol);
        }
        
        public void SetIdentityProvider(nsAString provider, nsAString protocol, nsAString username)
        {
            this.CallVoidMethod("setIdentityProvider", provider, protocol, username);
        }
        
        public Promise < nsAString > GetIdentityAssertion()
        {
            return this.CallMethod<Promise < nsAString >>("getIdentityAssertion");
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
        
        public nsISupports GetStreamById(nsAString streamId)
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
        
        public nsISupports CreateDataChannel(nsAString label)
        {
            return this.CallMethod<nsISupports>("createDataChannel", label);
        }
        
        public nsISupports CreateDataChannel(nsAString label, object dataChannelDict)
        {
            return this.CallMethod<nsISupports>("createDataChannel", label, dataChannelDict);
        }
    }
}
