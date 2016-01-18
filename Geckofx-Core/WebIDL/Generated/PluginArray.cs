namespace Gecko.WebIDL
{
    using System;
    
    
    public class PluginArray : WebIDLBase
    {
        
        public PluginArray(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public void Refresh()
        {
            this.CallVoidMethod("refresh");
        }
        
        public void Refresh(bool reloadDocuments)
        {
            this.CallVoidMethod("refresh", reloadDocuments);
        }
    }
}
