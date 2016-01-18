namespace Gecko.WebIDL
{
    using System;
    
    
    public class BrowserFeedWriter : WebIDLBase
    {
        
        public BrowserFeedWriter(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void WriteContent()
        {
            this.CallVoidMethod("writeContent");
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
    }
}
