namespace Gecko.WebIDL
{
    using System;
    
    
    public class ChromeNodeList : WebIDLBase
    {
        
        public ChromeNodeList(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void Append(nsIDOMNode aNode)
        {
            this.CallVoidMethod("append", aNode);
        }
        
        public void Remove(nsIDOMNode aNode)
        {
            this.CallVoidMethod("remove", aNode);
        }
    }
}
