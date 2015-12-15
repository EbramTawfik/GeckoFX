namespace Gecko.WebIDL
{
    using System;
    
    
    public class TVCurrentSourceChangedEvent : WebIDLBase
    {
        
        public TVCurrentSourceChangedEvent(nsISupports thisObject) : 
                base(thisObject)
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
