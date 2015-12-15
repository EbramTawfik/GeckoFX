namespace Gecko.WebIDL
{
    using System;
    
    
    public class PluginArray : WebIDLBase
    {
        
        public PluginArray(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public void Refresh(bool reloadDocuments)
        {
            this.CallVoidMethod("refresh", reloadDocuments);
        }
    }
}
