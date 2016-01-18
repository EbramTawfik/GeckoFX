namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozFrameLoaderOwner : WebIDLBase
    {
        
        public MozFrameLoaderOwner(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports FrameLoader
        {
            get
            {
                return this.GetProperty<nsISupports>("frameLoader");
            }
        }
        
        public void SetIsPrerendered()
        {
            this.CallVoidMethod("setIsPrerendered");
        }
        
        public void SwapFrameLoaders(nsISupports aOtherOwner)
        {
            this.CallVoidMethod("swapFrameLoaders", aOtherOwner);
        }
    }
}
