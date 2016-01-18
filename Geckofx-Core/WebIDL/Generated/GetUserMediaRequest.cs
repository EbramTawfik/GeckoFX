namespace Gecko.WebIDL
{
    using System;
    
    
    public class GetUserMediaRequest : WebIDLBase
    {
        
        public GetUserMediaRequest(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ulong WindowID
        {
            get
            {
                return this.GetProperty<ulong>("windowID");
            }
        }
        
        public ulong InnerWindowID
        {
            get
            {
                return this.GetProperty<ulong>("innerWindowID");
            }
        }
        
        public nsAString CallID
        {
            get
            {
                return this.GetProperty<nsAString>("callID");
            }
        }
        
        public bool IsSecure
        {
            get
            {
                return this.GetProperty<bool>("isSecure");
            }
        }
        
        public object GetConstraints()
        {
            return this.CallMethod<object>("getConstraints");
        }
    }
}
