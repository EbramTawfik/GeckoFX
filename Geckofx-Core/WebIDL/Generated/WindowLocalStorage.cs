namespace Gecko.WebIDL
{
    using System;
    
    
    public class WindowLocalStorage : WebIDLBase
    {
        
        public WindowLocalStorage(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
