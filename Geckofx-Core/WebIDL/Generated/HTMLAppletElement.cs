namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLAppletElement : WebIDLBase
    {
        
        public HTMLAppletElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public nsAString Alt
        {
            get
            {
                return this.GetProperty<nsAString>("alt");
            }
            set
            {
                this.SetProperty("alt", value);
            }
        }
        
        public nsAString Archive
        {
            get
            {
                return this.GetProperty<nsAString>("archive");
            }
            set
            {
                this.SetProperty("archive", value);
            }
        }
        
        public nsAString Code
        {
            get
            {
                return this.GetProperty<nsAString>("code");
            }
            set
            {
                this.SetProperty("code", value);
            }
        }
        
        public nsAString CodeBase
        {
            get
            {
                return this.GetProperty<nsAString>("codeBase");
            }
            set
            {
                this.SetProperty("codeBase", value);
            }
        }
        
        public nsAString Height
        {
            get
            {
                return this.GetProperty<nsAString>("height");
            }
            set
            {
                this.SetProperty("height", value);
            }
        }
        
        public uint Hspace
        {
            get
            {
                return this.GetProperty<uint>("hspace");
            }
            set
            {
                this.SetProperty("hspace", value);
            }
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
            set
            {
                this.SetProperty("name", value);
            }
        }
        
        public nsAString _object
        {
            get
            {
                return this.GetProperty<nsAString>("_object");
            }
            set
            {
                this.SetProperty("_object", value);
            }
        }
        
        public uint Vspace
        {
            get
            {
                return this.GetProperty<uint>("vspace");
            }
            set
            {
                this.SetProperty("vspace", value);
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
