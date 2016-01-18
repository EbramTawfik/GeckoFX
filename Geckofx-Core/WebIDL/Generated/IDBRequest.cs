namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBRequest : WebIDLBase
    {
        
        public IDBRequest(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public WebIDLUnion<nsISupports,nsISupports,nsISupports> Source
        {
            get
            {
                return this.GetProperty<WebIDLUnion<nsISupports,nsISupports,nsISupports>>("source");
            }
        }
        
        public nsISupports Transaction
        {
            get
            {
                return this.GetProperty<nsISupports>("transaction");
            }
        }
        
        public IDBRequestReadyState ReadyState
        {
            get
            {
                return this.GetProperty<IDBRequestReadyState>("readyState");
            }
        }
    }
}
