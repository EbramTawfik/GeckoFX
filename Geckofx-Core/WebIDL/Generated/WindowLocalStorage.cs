namespace Gecko.WebIDL
{
    using System;
    
    
    public class WindowLocalStorage : WebIDLBase
    {
        
        public WindowLocalStorage(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports LocalStorage
        {
            get
            {
                return this.GetProperty<nsISupports>("localStorage");
            }
        }
    }
}
