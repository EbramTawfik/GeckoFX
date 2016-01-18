namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaKeySession : WebIDLBase
    {
        
        public MediaKeySession(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Error
        {
            get
            {
                return this.GetProperty<nsISupports>("error");
            }
        }
        
        public string KeySystem
        {
            get
            {
                return this.GetProperty<string>("keySystem");
            }
        }
        
        public string SessionId
        {
            get
            {
                return this.GetProperty<string>("sessionId");
            }
        }
        
        public double Expiration
        {
            get
            {
                return this.GetProperty<double>("expiration");
            }
        }
        
        public Promise Closed
        {
            get
            {
                return this.GetProperty<Promise>("closed");
            }
        }
        
        public nsISupports KeyStatuses
        {
            get
            {
                return this.GetProperty<nsISupports>("keyStatuses");
            }
        }
        
        public Promise GenerateRequest(string initDataType, IntPtr initData)
        {
            return this.CallMethod<Promise>("generateRequest", initDataType, initData);
        }
        
        public Promise <bool> Load(string sessionId)
        {
            return this.CallMethod<Promise <bool>>("load", sessionId);
        }
        
        public Promise Update(IntPtr response)
        {
            return this.CallMethod<Promise>("update", response);
        }
        
        public Promise Close()
        {
            return this.CallMethod<Promise>("close");
        }
        
        public Promise Remove()
        {
            return this.CallMethod<Promise>("remove");
        }
    }
}
