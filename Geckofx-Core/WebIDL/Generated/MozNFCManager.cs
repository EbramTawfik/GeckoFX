namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNFCManager : WebIDLBase
    {
        
        public MozNFCManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise <bool> CheckP2PRegistration(string manifestUrl)
        {
            return this.CallMethod<Promise <bool>>("checkP2PRegistration", manifestUrl);
        }
        
        public void NotifyUserAcceptedP2P(string manifestUrl)
        {
            this.CallVoidMethod("notifyUserAcceptedP2P", manifestUrl);
        }
        
        public void NotifySendFileStatus(byte status, string requestId)
        {
            this.CallVoidMethod("notifySendFileStatus", status, requestId);
        }
        
        public Promise StartPoll()
        {
            return this.CallMethod<Promise>("startPoll");
        }
        
        public Promise StopPoll()
        {
            return this.CallMethod<Promise>("stopPoll");
        }
        
        public Promise PowerOff()
        {
            return this.CallMethod<Promise>("powerOff");
        }
    }
}
