namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLDirectoryElement : WebIDLBase
    {
        
        public HTMLDirectoryElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool Compact
        {
            get
            {
                return this.GetProperty<bool>("compact");
            }
            set
            {
                this.SetProperty("compact", value);
            }
        }
    }
}
