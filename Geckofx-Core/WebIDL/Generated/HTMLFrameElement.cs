namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLFrameElement : WebIDLBase
    {
        
        public HTMLFrameElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public string Scrolling
        {
            get
            {
                return this.GetProperty<string>("scrolling");
            }
            set
            {
                this.SetProperty("scrolling", value);
            }
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
        
        public string FrameBorder
        {
            get
            {
                return this.GetProperty<string>("frameBorder");
            }
            set
            {
                this.SetProperty("frameBorder", value);
            }
        }
        
        public string LongDesc
        {
            get
            {
                return this.GetProperty<string>("longDesc");
            }
            set
            {
                this.SetProperty("longDesc", value);
            }
        }
        
        public bool NoResize
        {
            get
            {
                return this.GetProperty<bool>("noResize");
            }
            set
            {
                this.SetProperty("noResize", value);
            }
        }
        
        public nsIDOMDocument ContentDocument
        {
            get
            {
                return this.GetProperty<nsIDOMDocument>("contentDocument");
            }
        }
        
        public nsIDOMWindow ContentWindow
        {
            get
            {
                return this.GetProperty<nsIDOMWindow>("contentWindow");
            }
        }
        
        public string MarginHeight
        {
            get
            {
                return this.GetProperty<string>("marginHeight");
            }
            set
            {
                this.SetProperty("marginHeight", value);
            }
        }
        
        public string MarginWidth
        {
            get
            {
                return this.GetProperty<string>("marginWidth");
            }
            set
            {
                this.SetProperty("marginWidth", value);
            }
        }
    }
}
