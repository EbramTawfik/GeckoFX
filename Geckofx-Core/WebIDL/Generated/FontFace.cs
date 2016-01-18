namespace Gecko.WebIDL
{
    using System;
    
    
    public class FontFace : WebIDLBase
    {
        
        public FontFace(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Family
        {
            get
            {
                return this.GetProperty<string>("family");
            }
            set
            {
                this.SetProperty("family", value);
            }
        }
        
        public string Style
        {
            get
            {
                return this.GetProperty<string>("style");
            }
            set
            {
                this.SetProperty("style", value);
            }
        }
        
        public string Weight
        {
            get
            {
                return this.GetProperty<string>("weight");
            }
            set
            {
                this.SetProperty("weight", value);
            }
        }
        
        public string Stretch
        {
            get
            {
                return this.GetProperty<string>("stretch");
            }
            set
            {
                this.SetProperty("stretch", value);
            }
        }
        
        public string UnicodeRange
        {
            get
            {
                return this.GetProperty<string>("unicodeRange");
            }
            set
            {
                this.SetProperty("unicodeRange", value);
            }
        }
        
        public string Variant
        {
            get
            {
                return this.GetProperty<string>("variant");
            }
            set
            {
                this.SetProperty("variant", value);
            }
        }
        
        public string FeatureSettings
        {
            get
            {
                return this.GetProperty<string>("featureSettings");
            }
            set
            {
                this.SetProperty("featureSettings", value);
            }
        }
        
        public FontFaceLoadStatus Status
        {
            get
            {
                return this.GetProperty<FontFaceLoadStatus>("status");
            }
        }
        
        public Promise < nsISupports > Loaded
        {
            get
            {
                return this.GetProperty<Promise < nsISupports >>("loaded");
            }
        }
        
        public Promise < nsISupports > Load()
        {
            return this.CallMethod<Promise < nsISupports >>("load");
        }
    }
}
