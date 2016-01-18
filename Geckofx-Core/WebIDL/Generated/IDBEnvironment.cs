namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBEnvironment : WebIDLBase
    {
        
        public IDBEnvironment(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports IndexedDB
        {
            get
            {
                return this.GetProperty<nsISupports>("indexedDB");
            }
        }
    }
}
