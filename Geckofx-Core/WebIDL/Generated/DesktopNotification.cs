namespace Gecko.WebIDL
{
    using System;
    
    
    public class DesktopNotification : WebIDLBase
    {
        
        public DesktopNotification(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void Show()
        {
            this.CallVoidMethod("show");
        }
    }
}
