namespace Gecko.WebIDL
{
    using System;
    
    
    public class CreateOfferRequest : WebIDLBase
    {
        
        public CreateOfferRequest(nsISupports thisObject) : 
                base(thisObject)
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
    }
}
