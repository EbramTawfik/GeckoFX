namespace Gecko.WebIDL
{
    using System;
    
    
    public class MimeType : WebIDLBase
    {
        
        public MimeType(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Description
        {
            get
            {
                return this.GetProperty<string>("description");
            }
        }
        
        public nsISupports EnabledPlugin
        {
            get
            {
                return this.GetProperty<nsISupports>("enabledPlugin");
            }
        }
        
        public string Suffixes
        {
            get
            {
                return this.GetProperty<string>("suffixes");
            }
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
        }
    }
}
