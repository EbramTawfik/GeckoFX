namespace Gecko.WebIDL
{
    using System;
    
    
    public class ConvolverNode : WebIDLBase
    {
        
        public ConvolverNode(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Buffer
        {
            get
            {
                return this.GetProperty<nsISupports>("buffer");
            }
            set
            {
                this.SetProperty("buffer", value);
            }
        }
        
        public bool Normalize
        {
            get
            {
                return this.GetProperty<bool>("normalize");
            }
            set
            {
                this.SetProperty("normalize", value);
            }
        }
    }
}
