namespace Gecko.WebIDL
{
    using System;
    
    
    public class ContainerBoxObject : WebIDLBase
    {
        
        public ContainerBoxObject(nsISupports thisObject) : 
                base(thisObject)
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
