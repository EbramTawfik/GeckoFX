namespace Gecko.WebIDL
{
    using System;
    
    
    public class ScrollViewChangeEvent : WebIDLBase
    {
        
        public ScrollViewChangeEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public ScrollState State
        {
            get
            {
                return this.GetProperty<ScrollState>("state");
            }
        }
    }
}
