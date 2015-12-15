namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorOnLine : WebIDLBase
    {
        
        public NavigatorOnLine(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool OnLine
        {
            get
            {
                return this.GetProperty<bool>("onLine");
            }
        }
    }
}
