namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLFontElement : WebIDLBase
    {
        
        public HTMLFontElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public nsAString Face
        {
            get
            {
                return this.GetProperty<nsAString>("face");
            }
            set
            {
                this.SetProperty("face", value);
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
    }
}
