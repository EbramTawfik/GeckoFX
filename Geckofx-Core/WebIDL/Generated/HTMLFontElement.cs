namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLFontElement : WebIDLBase
    {
        
        public HTMLFontElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public string Face
        {
            get
            {
                return this.GetProperty<string>("face");
            }
            set
            {
                this.SetProperty("face", value);
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
    }
}
