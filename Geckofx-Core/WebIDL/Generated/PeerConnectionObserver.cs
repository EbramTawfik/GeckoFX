namespace Gecko.WebIDL
{
    using System;
    
    
    public class PeerConnectionObserver : WebIDLBase
    {
        
        public PeerConnectionObserver(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void OnCreateOfferSuccess(string offer)
        {
            this.CallVoidMethod("onCreateOfferSuccess", offer);
        }
        
        public void OnCreateOfferError(uint name, string message)
        {
            this.CallVoidMethod("onCreateOfferError", name, message);
        }
        
        public void OnCreateAnswerSuccess(string answer)
        {
            this.CallVoidMethod("onCreateAnswerSuccess", answer);
        }
        
        public void OnCreateAnswerError(uint name, string message)
        {
            this.CallVoidMethod("onCreateAnswerError", name, message);
        }
        
        public void OnSetLocalDescriptionSuccess()
        {
            this.CallVoidMethod("onSetLocalDescriptionSuccess");
        }
        
        public void OnSetRemoteDescriptionSuccess()
        {
            this.CallVoidMethod("onSetRemoteDescriptionSuccess");
        }
        
        public void OnSetLocalDescriptionError(uint name, string message)
        {
            this.CallVoidMethod("onSetLocalDescriptionError", name, message);
        }
        
        public void OnSetRemoteDescriptionError(uint name, string message)
        {
            this.CallVoidMethod("onSetRemoteDescriptionError", name, message);
        }
        
        public void OnAddIceCandidateSuccess()
        {
            this.CallVoidMethod("onAddIceCandidateSuccess");
        }
        
        public void OnAddIceCandidateError(uint name, string message)
        {
            this.CallVoidMethod("onAddIceCandidateError", name, message);
        }
        
        public void OnIceCandidate(ushort level, string mid, string candidate)
        {
            this.CallVoidMethod("onIceCandidate", level, mid, candidate);
        }
        
        public void OnNegotiationNeeded()
        {
            this.CallVoidMethod("onNegotiationNeeded");
        }
        
        public void OnGetStatsSuccess()
        {
            this.CallVoidMethod("onGetStatsSuccess");
        }
        
        public void OnGetStatsSuccess(object report)
        {
            this.CallVoidMethod("onGetStatsSuccess", report);
        }
        
        public void OnGetStatsError(uint name, string message)
        {
            this.CallVoidMethod("onGetStatsError", name, message);
        }
        
        public void OnReplaceTrackSuccess()
        {
            this.CallVoidMethod("onReplaceTrackSuccess");
        }
        
        public void OnReplaceTrackError(uint name, string message)
        {
            this.CallVoidMethod("onReplaceTrackError", name, message);
        }
        
        public void NotifyDataChannel(nsISupports channel)
        {
            this.CallVoidMethod("notifyDataChannel", channel);
        }
        
        public void OnStateChange(PCObserverStateType state)
        {
            this.CallVoidMethod("onStateChange", state);
        }
        
        public void OnAddStream(nsISupports stream)
        {
            this.CallVoidMethod("onAddStream", stream);
        }
        
        public void OnRemoveStream(nsISupports stream)
        {
            this.CallVoidMethod("onRemoveStream", stream);
        }
        
        public void OnAddTrack(nsISupports track)
        {
            this.CallVoidMethod("onAddTrack", track);
        }
        
        public void OnRemoveTrack(nsISupports track)
        {
            this.CallVoidMethod("onRemoveTrack", track);
        }
    }
}
