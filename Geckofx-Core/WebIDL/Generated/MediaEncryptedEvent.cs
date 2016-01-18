namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaEncryptedEvent : WebIDLBase
    {
        
        public MediaEncryptedEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString InitDataType
        {
            get
            {
                return this.GetProperty<nsAString>("initDataType");
            }
        }
        
        public IntPtr InitData
        {
            get
            {
                return this.GetProperty<IntPtr>("initData");
            }
        }
    }
}
