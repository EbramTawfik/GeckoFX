namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozInterAppConnectionRequest : WebIDLBase
    {
        
        public MozInterAppConnectionRequest(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Keyword
        {
            get
            {
                return this.GetProperty<string>("keyword");
            }
        }
        
        public nsISupports Port
        {
            get
            {
                return this.GetProperty<nsISupports>("port");
            }
        }
        
        public string From
        {
            get
            {
                return this.GetProperty<string>("from");
            }
        }
    }
}
