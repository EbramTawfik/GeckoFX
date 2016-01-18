namespace Gecko.WebIDL
{
    using System;
    
    
    public class TVCurrentSourceChangedEvent : WebIDLBase
    {
        
        public TVCurrentSourceChangedEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Source
        {
            get
            {
                return this.GetProperty<nsISupports>("source");
            }
        }
    }
}
