namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLFrameElement : WebIDLBase
    {
        
        public HTMLFrameElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public nsAString Scrolling
        {
            get
            {
                return this.GetProperty<nsAString>("scrolling");
            }
            set
            {
                this.SetProperty("scrolling", value);
            }
        }
        
        public nsAString Src
        {
            get
            {
                return this.GetProperty<nsAString>("src");
            }
            set
            {
                this.SetProperty("src", value);
            }
        }
        
        public nsAString FrameBorder
        {
            get
            {
                return this.GetProperty<nsAString>("frameBorder");
            }
            set
            {
                this.SetProperty("frameBorder", value);
            }
        }
        
        public nsAString LongDesc
        {
            get
            {
                return this.GetProperty<nsAString>("longDesc");
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
        
        public nsAString MarginHeight
        {
            get
            {
                return this.GetProperty<nsAString>("marginHeight");
            }
            set
            {
                this.SetProperty("marginHeight", value);
            }
        }
        
        public nsAString MarginWidth
        {
            get
            {
                return this.GetProperty<nsAString>("marginWidth");
            }
            set
            {
                this.SetProperty("marginWidth", value);
            }
        }
    }
}
