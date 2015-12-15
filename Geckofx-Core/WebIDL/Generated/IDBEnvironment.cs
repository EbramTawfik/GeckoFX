namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBEnvironment : WebIDLBase
    {
        
        public IDBEnvironment(nsISupports thisObject) : 
                base(thisObject)
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
