namespace Gecko.WebIDL
{
    using System;
    
    
    public class BarProp : WebIDLBase
    {
        
        public BarProp(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool Visible
        {
            get
            {
                return this.GetProperty<bool>("visible");
            }
            set
            {
                this.SetProperty("visible", value);
            }
        }
    }
}
