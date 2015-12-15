namespace Gecko.WebIDL
{
    using System;
    
    
    public class FontFace : WebIDLBase
    {
        
        public FontFace(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Family
        {
            get
            {
                return this.GetProperty<nsAString>("family");
            }
            set
            {
                this.SetProperty("family", value);
            }
        }
        
        public nsAString Style
        {
            get
            {
                return this.GetProperty<nsAString>("style");
            }
            set
            {
                this.SetProperty("style", value);
            }
        }
        
        public nsAString Weight
        {
            get
            {
                return this.GetProperty<nsAString>("weight");
            }
            set
            {
                this.SetProperty("weight", value);
            }
        }
        
        public nsAString Stretch
        {
            get
            {
                return this.GetProperty<nsAString>("stretch");
            }
            set
            {
                this.SetProperty("stretch", value);
            }
        }
        
        public nsAString UnicodeRange
        {
            get
            {
                return this.GetProperty<nsAString>("unicodeRange");
            }
            set
            {
                this.SetProperty("unicodeRange", value);
            }
        }
        
        public nsAString Variant
        {
            get
            {
                return this.GetProperty<nsAString>("variant");
            }
            set
            {
                this.SetProperty("variant", value);
            }
        }
        
        public nsAString FeatureSettings
        {
            get
            {
                return this.GetProperty<nsAString>("featureSettings");
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
