namespace Gecko.WebIDL
{
    using System;
    
    
    public class BrowserFeedWriter : WebIDLBase
    {
        
        public BrowserFeedWriter(nsISupports thisObject) : 
                base(thisObject)
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
