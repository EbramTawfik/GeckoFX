namespace Gecko.WebIDL
{
    using System;
    
    
    public class OffscreenCanvas : WebIDLBase
    {
        
        public OffscreenCanvas(nsISupports thisObject) : 
                base(thisObject)
        {
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
        
        public nsISupports GetContext(nsAString contextId, object contextOptions)
        {
            return this.CallMethod<nsISupports>("getContext", contextId, contextOptions);
        }
    }
}
