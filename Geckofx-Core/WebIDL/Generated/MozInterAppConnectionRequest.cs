namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozInterAppConnectionRequest : WebIDLBase
    {
        
        public MozInterAppConnectionRequest(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Keyword
        {
            get
            {
                return this.GetProperty<nsAString>("keyword");
            }
        }
        
        public nsISupports Port
        {
            get
            {
                return this.GetProperty<nsISupports>("port");
            }
        }
        
        public nsAString From
        {
            get
            {
                return this.GetProperty<nsAString>("from");
            }
        }
    }
}
