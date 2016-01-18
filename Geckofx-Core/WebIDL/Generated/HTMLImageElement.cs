namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLImageElement : WebIDLBase
    {
        
        public HTMLImageElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public string Srcset
        {
            get
            {
                return this.GetProperty<string>("srcset");
            }
            set
            {
                this.SetProperty("srcset", value);
            }
        }
        
        public string CrossOrigin
        {
            get
            {
                return this.GetProperty<string>("crossOrigin");
            }
            set
            {
                this.SetProperty("crossOrigin", value);
            }
        }
        
        public string UseMap
        {
            get
            {
                return this.GetProperty<string>("useMap");
            }
            set
            {
                this.SetProperty("useMap", value);
            }
        }
        
        public string ReferrerPolicy
        {
            get
            {
                return this.GetProperty<string>("referrerPolicy");
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
        
        public string Border
        {
            get
            {
                return this.GetProperty<string>("border");
            }
            set
            {
                this.SetProperty("border", value);
            }
        }
        
        public string Sizes
        {
            get
            {
                return this.GetProperty<string>("sizes");
            }
            set
            {
                this.SetProperty("sizes", value);
            }
        }
        
        public string CurrentSrc
        {
            get
            {
                return this.GetProperty<string>("currentSrc");
            }
        }
        
        public string Lowsrc
        {
            get
            {
                return this.GetProperty<string>("lowsrc");
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
