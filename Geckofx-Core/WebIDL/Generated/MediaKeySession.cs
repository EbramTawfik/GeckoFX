namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaKeySession : WebIDLBase
    {
        
        public MediaKeySession(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Error
        {
            get
            {
                return this.GetProperty<nsISupports>("error");
            }
        }
        
        public nsAString KeySystem
        {
            get
            {
                return this.GetProperty<nsAString>("keySystem");
            }
        }
        
        public nsAString SessionId
        {
            get
            {
                return this.GetProperty<nsAString>("sessionId");
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
        
        public Promise GenerateRequest(nsAString initDataType, IntPtr initData)
        {
            return this.CallMethod<Promise>("generateRequest", initDataType, initData);
        }
        
        public Promise <bool> Load(nsAString sessionId)
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
