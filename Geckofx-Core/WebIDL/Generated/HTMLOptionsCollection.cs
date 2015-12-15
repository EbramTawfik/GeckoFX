namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLOptionsCollection : WebIDLBase
    {
        
        public HTMLOptionsCollection(nsISupports thisObject) : 
                base(thisObject)
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
