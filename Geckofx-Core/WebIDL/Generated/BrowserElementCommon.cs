namespace Gecko.WebIDL
{
    using System;
    
    
    public class BrowserElementCommon : WebIDLBase
    {
        
        public BrowserElementCommon(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void SetVisible(bool visible)
        {
            this.CallVoidMethod("setVisible", visible);
        }
        
        public nsISupports GetVisible()
        {
            return this.CallMethod<nsISupports>("getVisible");
        }
        
        public void SetActive(bool active)
        {
            this.CallVoidMethod("setActive", active);
        }
        
        public bool GetActive()
        {
            return this.CallMethod<bool>("getActive");
        }
    }
}
