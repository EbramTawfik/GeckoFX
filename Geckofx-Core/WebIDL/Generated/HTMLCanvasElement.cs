namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLCanvasElement : WebIDLBase
    {
        
        public HTMLCanvasElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public nsISupports GetContext(string contextId)
        {
            return this.CallMethod<nsISupports>("getContext", contextId);
        }
        
        public nsISupports GetContext(string contextId, object contextOptions)
        {
            return this.CallMethod<nsISupports>("getContext", contextId, contextOptions);
        }
        
        public string ToDataURL()
        {
            return this.CallMethod<string>("toDataURL");
        }
        
        public string ToDataURL(string type)
        {
            return this.CallMethod<string>("toDataURL", type);
        }
        
        public string ToDataURL(string type, object encoderOptions)
        {
            return this.CallMethod<string>("toDataURL", type, encoderOptions);
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
        
        public nsISupports MozGetAsFile(string name)
        {
            return this.CallMethod<nsISupports>("mozGetAsFile", name);
        }
        
        public nsISupports MozGetAsFile(string name, string type)
        {
            return this.CallMethod<nsISupports>("mozGetAsFile", name, type);
        }
        
        public nsISupports MozGetIPCContext(string contextId)
        {
            return this.CallMethod<nsISupports>("MozGetIPCContext", contextId);
        }
        
        public nsISupports CaptureStream()
        {
            return this.CallMethod<nsISupports>("captureStream");
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
