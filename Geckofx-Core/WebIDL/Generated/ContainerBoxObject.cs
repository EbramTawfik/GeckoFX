namespace Gecko.WebIDL
{
    using System;
    
    
    public class ContainerBoxObject : WebIDLBase
    {
        
        public ContainerBoxObject(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports DocShell
        {
            get
            {
                return this.GetProperty<nsISupports>("docShell");
            }
        }
    }
}
