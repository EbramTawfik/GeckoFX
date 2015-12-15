namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLHRElement : WebIDLBase
    {
        
        public HTMLHRElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Align
        {
            get
            {
                return this.GetProperty<nsAString>("align");
            }
            set
            {
                this.SetProperty("align", value);
            }
        }
        
        public nsAString Color
        {
            get
            {
                return this.GetProperty<nsAString>("color");
            }
            set
            {
                this.SetProperty("color", value);
            }
        }
        
        public bool NoShade
        {
            get
            {
                return this.GetProperty<bool>("noShade");
            }
            set
            {
                this.SetProperty("noShade", value);
            }
        }
        
        public nsAString Size
        {
            get
            {
                return this.GetProperty<nsAString>("size");
            }
            set
            {
                this.SetProperty("size", value);
            }
        }
        
        public nsAString Width
        {
            get
            {
                return this.GetProperty<nsAString>("width");
            }
            set
            {
                this.SetProperty("width", value);
            }
        }
    }
}
