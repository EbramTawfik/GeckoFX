namespace Gecko.WebIDL
{
    using System;
    
    
    public class VREyeParameters : WebIDLBase
    {
        
        public VREyeParameters(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports MinimumFieldOfView
        {
            get
            {
                return this.GetProperty<nsISupports>("minimumFieldOfView");
            }
        }
        
        public nsISupports MaximumFieldOfView
        {
            get
            {
                return this.GetProperty<nsISupports>("maximumFieldOfView");
            }
        }
        
        public nsISupports RecommendedFieldOfView
        {
            get
            {
                return this.GetProperty<nsISupports>("recommendedFieldOfView");
            }
        }
        
        public nsISupports EyeTranslation
        {
            get
            {
                return this.GetProperty<nsISupports>("eyeTranslation");
            }
        }
        
        public nsISupports CurrentFieldOfView
        {
            get
            {
                return this.GetProperty<nsISupports>("currentFieldOfView");
            }
        }
        
        public nsISupports RenderRect
        {
            get
            {
                return this.GetProperty<nsISupports>("renderRect");
            }
        }
    }
}
