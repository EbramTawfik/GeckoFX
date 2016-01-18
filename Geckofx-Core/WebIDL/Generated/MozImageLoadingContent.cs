namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozImageLoadingContent : WebIDLBase
    {
        
        public MozImageLoadingContent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool LoadingEnabled
        {
            get
            {
                return this.GetProperty<bool>("loadingEnabled");
            }
            set
            {
                this.SetProperty("loadingEnabled", value);
            }
        }
        
        public short ImageBlockingStatus
        {
            get
            {
                return this.GetProperty<short>("imageBlockingStatus");
            }
        }
        
        public nsISupports CurrentURI
        {
            get
            {
                return this.GetProperty<nsISupports>("currentURI");
            }
        }
        
        public void AddObserver(nsISupports aObserver)
        {
            this.CallVoidMethod("addObserver", aObserver);
        }
        
        public void RemoveObserver(nsISupports aObserver)
        {
            this.CallVoidMethod("removeObserver", aObserver);
        }
        
        public nsISupports GetRequest(int aRequestType)
        {
            return this.CallMethod<nsISupports>("getRequest", aRequestType);
        }
        
        public int GetRequestType(nsISupports aRequest)
        {
            return this.CallMethod<int>("getRequestType", aRequest);
        }
        
        public nsISupports LoadImageWithChannel(nsISupports aChannel)
        {
            return this.CallMethod<nsISupports>("loadImageWithChannel", aChannel);
        }
        
        public void ForceReload()
        {
            this.CallVoidMethod("forceReload");
        }
        
        public void ForceReload(bool aNotify)
        {
            this.CallVoidMethod("forceReload", aNotify);
        }
        
        public void ForceImageState(bool aForce, ulong aState)
        {
            this.CallVoidMethod("forceImageState", aForce, aState);
        }
    }
}
