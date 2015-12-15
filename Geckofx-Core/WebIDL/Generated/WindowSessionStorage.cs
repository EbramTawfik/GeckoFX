namespace Gecko.WebIDL
{
    using System;
    
    
    public class WindowSessionStorage : WebIDLBase
    {
        
        public WindowSessionStorage(nsISupports thisObject) : 
                base(thisObject)
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
