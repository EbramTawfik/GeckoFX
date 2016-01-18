namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLHRElement : WebIDLBase
    {
        
        public HTMLHRElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Align
        {
            get
            {
                return this.GetProperty<string>("align");
            }
            set
            {
                this.SetProperty("align", value);
            }
        }
        
        public string Color
        {
            get
            {
                return this.GetProperty<string>("color");
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
        
        public string Size
        {
            get
            {
                return this.GetProperty<string>("size");
            }
            set
            {
                this.SetProperty("size", value);
            }
        }
        
        public string Width
        {
            get
            {
                return this.GetProperty<string>("width");
            }
            set
            {
                this.SetProperty("width", value);
            }
        }
    }
}
