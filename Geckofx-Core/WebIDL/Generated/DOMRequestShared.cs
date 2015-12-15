namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMRequestShared : WebIDLBase
    {
        
        public DOMRequestShared(nsISupports thisObject) : 
                base(thisObject)
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
