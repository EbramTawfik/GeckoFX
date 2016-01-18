namespace Gecko.WebIDL
{
    using System;
    
    
    public class MimeType : WebIDLBase
    {
        
        public MimeType(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Description
        {
            get
            {
                return this.GetProperty<nsAString>("description");
            }
        }
        
        public nsISupports EnabledPlugin
        {
            get
            {
                return this.GetProperty<nsISupports>("enabledPlugin");
            }
        }
        
        public nsAString Suffixes
        {
            get
            {
                return this.GetProperty<nsAString>("suffixes");
            }
        }
        
        public nsAString Type
        {
            get
            {
                return this.GetProperty<nsAString>("type");
            }
        }
    }
}
