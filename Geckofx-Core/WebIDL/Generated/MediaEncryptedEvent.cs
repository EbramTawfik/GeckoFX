namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaEncryptedEvent : WebIDLBase
    {
        
        public MediaEncryptedEvent(nsISupports thisObject) : 
                base(thisObject)
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
