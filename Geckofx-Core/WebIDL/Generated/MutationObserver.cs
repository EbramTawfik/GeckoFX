namespace Gecko.WebIDL
{
    using System;
    
    
    public class MutationObserver : WebIDLBase
    {
        
        public MutationObserver(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool MergeAttributeRecords
        {
            get
            {
                return this.GetProperty<bool>("mergeAttributeRecords");
            }
            set
            {
                this.SetProperty("mergeAttributeRecords", value);
            }
        }
        
        public void Observe(nsIDOMNode target)
        {
            this.CallVoidMethod("observe", target);
        }
        
        public void Observe(nsIDOMNode target, object options)
        {
            this.CallVoidMethod("observe", target, options);
        }
        
        public void Disconnect()
        {
            this.CallVoidMethod("disconnect");
        }
        
        public nsISupports[] TakeRecords()
        {
            return this.CallMethod<nsISupports[]>("takeRecords");
        }
        
        public object[] GetObservingInfo()
        {
            return this.CallMethod<object[]>("getObservingInfo");
        }
    }
}
