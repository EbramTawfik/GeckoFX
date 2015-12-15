namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLCanvasElement : WebIDLBase
    {
        
        public HTMLCanvasElement(nsISupports thisObject) : 
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
        
        public nsAString ToDataURL(nsAString type, object encoderOptions)
        {
            return this.CallMethod<nsAString>("toDataURL", type, encoderOptions);
        }
        
        public bool MozOpaque
        {
            get
            {
                return this.GetProperty<bool>("mozOpaque");
            }
            set
            {
                this.SetProperty("mozOpaque", value);
            }
        }
        
        public nsISupports MozGetAsFile(nsAString name, nsAString type)
        {
            return this.CallMethod<nsISupports>("mozGetAsFile", name, type);
        }
        
        public nsISupports MozGetIPCContext(nsAString contextId)
        {
            return this.CallMethod<nsISupports>("MozGetIPCContext", contextId);
        }
        
        public nsISupports CaptureStream(double frameRate)
        {
            return this.CallMethod<nsISupports>("captureStream", frameRate);
        }
        
        public nsISupports TransferControlToOffscreen()
        {
            return this.CallMethod<nsISupports>("transferControlToOffscreen");
        }
    }
}
