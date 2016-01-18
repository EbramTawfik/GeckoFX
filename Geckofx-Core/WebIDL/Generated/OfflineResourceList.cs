namespace Gecko.WebIDL
{
    using System;
    
    
    public class OfflineResourceList : WebIDLBase
    {
        
        public OfflineResourceList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort Status
        {
            get
            {
                return this.GetProperty<ushort>("status");
            }
        }
        
        public void Update()
        {
            this.CallVoidMethod("update");
        }
        
        public void SwapCache()
        {
            this.CallVoidMethod("swapCache");
        }
        
        public nsISupports MozItems
        {
            get
            {
                return this.GetProperty<nsISupports>("mozItems");
            }
        }
        
        public uint MozLength
        {
            get
            {
                return this.GetProperty<uint>("mozLength");
            }
        }
        
        public bool MozHasItem(string uri)
        {
            return this.CallMethod<bool>("mozHasItem", uri);
        }
        
        public void MozAdd(string uri)
        {
            this.CallVoidMethod("mozAdd", uri);
        }
        
        public void MozRemove(string uri)
        {
            this.CallVoidMethod("mozRemove", uri);
        }
    }
}
