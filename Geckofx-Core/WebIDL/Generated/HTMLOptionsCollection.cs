namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLOptionsCollection : WebIDLBase
    {
        
        public HTMLOptionsCollection(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
            set
            {
                this.SetProperty("length", value);
            }
        }
        
        public int SelectedIndex
        {
            get
            {
                return this.GetProperty<int>("selectedIndex");
            }
            set
            {
                this.SetProperty("selectedIndex", value);
            }
        }
    }
}
