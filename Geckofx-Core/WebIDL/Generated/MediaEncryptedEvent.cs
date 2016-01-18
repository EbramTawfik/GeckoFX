namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaEncryptedEvent : WebIDLBase
    {
        
        public MediaEncryptedEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string InitDataType
        {
            get
            {
                return this.GetProperty<string>("initDataType");
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
