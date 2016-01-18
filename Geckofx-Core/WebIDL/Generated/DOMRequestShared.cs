namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMRequestShared : WebIDLBase
    {
        
        public DOMRequestShared(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public DOMRequestReadyState ReadyState
        {
            get
            {
                return this.GetProperty<DOMRequestReadyState>("readyState");
            }
        }
        
        public object Result
        {
            get
            {
                return this.GetProperty<object>("result");
            }
        }
        
        public nsISupports Error
        {
            get
            {
                return this.GetProperty<nsISupports>("error");
            }
        }
    }
}
