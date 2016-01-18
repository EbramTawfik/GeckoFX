namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLImageElement : WebIDLBase
    {
        
        public HTMLImageElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public nsAString Srcset
        {
            get
            {
                return this.GetProperty<nsAString>("srcset");
            }
            set
            {
                this.SetProperty("srcset", value);
            }
        }
        
        public nsAString CrossOrigin
        {
            get
            {
                return this.GetProperty<nsAString>("crossOrigin");
            }
            set
            {
                this.SetProperty("crossOrigin", value);
            }
        }
        
        public nsAString UseMap
        {
            get
            {
                return this.GetProperty<nsAString>("useMap");
            }
            set
            {
                this.SetProperty("useMap", value);
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
        
        public bool IsMap
        {
            get
            {
                return this.GetProperty<bool>("isMap");
            }
            set
            {
                this.SetProperty("isMap", value);
            }
        }
        
        public uint Width
        {
            get
            {
                return this.GetProperty<uint>("width");
            }
            set
            {
                this.SetProperty("width", value);
            }
        }
        
        public uint Height
        {
            get
            {
                return this.GetProperty<uint>("height");
            }
            set
            {
                this.SetProperty("height", value);
            }
        }
        
        public uint NaturalWidth
        {
            get
            {
                return this.GetProperty<uint>("naturalWidth");
            }
        }
        
        public uint NaturalHeight
        {
            get
            {
                return this.GetProperty<uint>("naturalHeight");
            }
        }
        
        public bool Complete
        {
            get
            {
                return this.GetProperty<bool>("complete");
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
        
        public nsAString Border
        {
            get
            {
                return this.GetProperty<nsAString>("border");
            }
            set
            {
                this.SetProperty("border", value);
            }
        }
        
        public nsAString Sizes
        {
            get
            {
                return this.GetProperty<nsAString>("sizes");
            }
            set
            {
                this.SetProperty("sizes", value);
            }
        }
        
        public nsAString CurrentSrc
        {
            get
            {
                return this.GetProperty<nsAString>("currentSrc");
            }
        }
        
        public nsAString Lowsrc
        {
            get
            {
                return this.GetProperty<nsAString>("lowsrc");
            }
            set
            {
                this.SetProperty("lowsrc", value);
            }
        }
        
        public int X
        {
            get
            {
                return this.GetProperty<int>("x");
            }
        }
        
        public int Y
        {
            get
            {
                return this.GetProperty<int>("y");
            }
        }
    }
}
