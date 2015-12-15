namespace Gecko.WebIDL
{
    using System;
    
    
    public class ActivityRequestHandler : WebIDLBase
    {
        
        public ActivityRequestHandler(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public object Source
        {
            get
            {
                return this.GetProperty<object>("source");
            }
        }
        
        public void PostResult(object result)
        {
            this.CallVoidMethod("postResult", result);
        }
        
        public void PostError(nsAString error)
        {
            this.CallVoidMethod("postError", error);
        }
    }
}
