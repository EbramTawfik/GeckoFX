namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLIFrameElement : WebIDLBase
    {
        
        public HTMLIFrameElement(nsISupports thisObject) : 
                base(thisObject)
        {
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
        
        public nsAString Srcdoc
        {
            get
            {
                return this.GetProperty<nsAString>("srcdoc");
            }
            set
            {
                this.SetProperty("srcdoc", value);
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
        
        public nsISupports Sandbox
        {
            get
            {
                return this.GetProperty<nsISupports>("sandbox");
            }
        }
        
        public bool AllowFullscreen
        {
            get
            {
                return this.GetProperty<bool>("allowFullscreen");
            }
            set
            {
                this.SetProperty("allowFullscreen", value);
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
        
        public nsAString ReferrerPolicy
        {
            get
            {
                return this.GetProperty<nsAString>("referrerPolicy");
            }
            set
            {
                this.SetProperty("referrerPolicy", value);
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
        
        public nsIDOMDocument GetSVGDocument()
        {
            return this.CallMethod<nsIDOMDocument>("getSVGDocument");
        }
        
        public bool Mozbrowser
        {
            get
            {
                return this.GetProperty<bool>("mozbrowser");
            }
            set
            {
                this.SetProperty("mozbrowser", value);
            }
        }
        
        public nsAString AppManifestURL
        {
            get
            {
                return this.GetProperty<nsAString>("appManifestURL");
            }
        }
    }
}
