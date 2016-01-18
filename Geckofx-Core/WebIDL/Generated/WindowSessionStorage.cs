namespace Gecko.WebIDL
{
    using System;
    
    
    public class WindowSessionStorage : WebIDLBase
    {
        
        public WindowSessionStorage(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports SessionStorage
        {
            get
            {
                return this.GetProperty<nsISupports>("sessionStorage");
            }
        }
    }
}
