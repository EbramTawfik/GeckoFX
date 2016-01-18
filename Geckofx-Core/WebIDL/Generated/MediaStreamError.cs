namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaStreamError : WebIDLBase
    {
        
        public MediaStreamError(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public string Message
        {
            get
            {
                return this.GetProperty<string>("message");
            }
        }
        
        public string Constraint
        {
            get
            {
                return this.GetProperty<string>("constraint");
            }
        }
    }
}
