namespace Gecko.WebIDL
{
    using System;
    
    
    public class XMLDocument : WebIDLBase
    {
        
        public XMLDocument(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool Load(nsAString url)
        {
            return this.CallMethod<bool>("load", url);
        }
        
        public bool Async
        {
            get
            {
                return this.GetProperty<bool>("async");
            }
            set
            {
                this.SetProperty("async", value);
            }
        }
    }
}
