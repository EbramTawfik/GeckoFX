namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLEmbedElement : WebIDLBase
    {
        
        public HTMLEmbedElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Src
        {
            get
            {
                return this.GetProperty<string>("src");
            }
            set
            {
                this.SetProperty("src", value);
            }
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
            set
            {
                this.SetProperty("type", value);
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
        
        public string Height
        {
            get
            {
                return this.GetProperty<string>("height");
            }
            set
            {
                this.SetProperty("height", value);
            }
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
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
            set
            {
                this.SetProperty("name", value);
            }
        }
    }
}
