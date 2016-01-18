namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLAppletElement : WebIDLBase
    {
        
        public HTMLAppletElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public string Alt
        {
            get
            {
                return this.GetProperty<string>("alt");
            }
            set
            {
                this.SetProperty("alt", value);
            }
        }
        
        public string Archive
        {
            get
            {
                return this.GetProperty<string>("archive");
            }
            set
            {
                this.SetProperty("archive", value);
            }
        }
        
        public string Code
        {
            get
            {
                return this.GetProperty<string>("code");
            }
            set
            {
                this.SetProperty("code", value);
            }
        }
        
        public string CodeBase
        {
            get
            {
                return this.GetProperty<string>("codeBase");
            }
            set
            {
                this.SetProperty("codeBase", value);
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
        
        public string _object
        {
            get
            {
                return this.GetProperty<string>("_object");
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
