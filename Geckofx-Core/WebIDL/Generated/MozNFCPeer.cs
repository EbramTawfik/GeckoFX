namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNFCPeer : WebIDLBase
    {
        
        public MozNFCPeer(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool IsLost
        {
            get
            {
                return this.GetProperty<bool>("isLost");
            }
        }
        
        public Promise SendNDEF(nsISupports[] records)
        {
            return this.CallMethod<Promise>("sendNDEF", records);
        }
        
        public Promise SendFile(nsIDOMBlob blob)
        {
            return this.CallMethod<Promise>("sendFile", blob);
        }
        
        public nsAString Session
        {
            get
            {
                return this.GetProperty<nsAString>("session");
            }
            set
            {
                this.SetProperty("session", value);
            }
        }
        
        public void NotifyLost()
        {
            this.CallVoidMethod("notifyLost");
        }
    }
}
