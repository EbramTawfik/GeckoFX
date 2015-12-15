namespace Gecko.WebIDL
{
    using System;
    
    
    public class RequestSyncTask : WebIDLBase
    {
        
        public RequestSyncTask(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports App
        {
            get
            {
                return this.GetProperty<nsISupports>("app");
            }
        }
        
        public RequestSyncTaskPolicyState State
        {
            get
            {
                return this.GetProperty<RequestSyncTaskPolicyState>("state");
            }
        }
        
        public int OverwrittenMinInterval
        {
            get
            {
                return this.GetProperty<int>("overwrittenMinInterval");
            }
        }
        
        public USVString Task
        {
            get
            {
                return this.GetProperty<USVString>("task");
            }
        }
        
        public nsISupports LastSync
        {
            get
            {
                return this.GetProperty<nsISupports>("lastSync");
            }
        }
        
        public USVString WakeUpPage
        {
            get
            {
                return this.GetProperty<USVString>("wakeUpPage");
            }
        }
        
        public bool OneShot
        {
            get
            {
                return this.GetProperty<bool>("oneShot");
            }
        }
        
        public int MinInterval
        {
            get
            {
                return this.GetProperty<int>("minInterval");
            }
        }
        
        public bool WifiOnly
        {
            get
            {
                return this.GetProperty<bool>("wifiOnly");
            }
        }
        
        public object Data
        {
            get
            {
                return this.GetProperty<object>("data");
            }
        }
        
        public Promise SetPolicy(RequestSyncTaskPolicyState aState, int ovewrittenMinInterval)
        {
            return this.CallMethod<Promise>("setPolicy", aState, ovewrittenMinInterval);
        }
        
        public Promise RunNow()
        {
            return this.CallMethod<Promise>("runNow");
        }
    }
}
