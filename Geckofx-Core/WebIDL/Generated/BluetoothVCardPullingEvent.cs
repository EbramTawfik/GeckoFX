namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothVCardPullingEvent : WebIDLBase
    {
        
        public BluetoothVCardPullingEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public VCardVersion Format
        {
            get
            {
                return this.GetProperty<VCardVersion>("format");
            }
        }
        
        public VCardProperties[] PropSelector
        {
            get
            {
                return this.GetProperty<VCardProperties[]>("propSelector");
            }
        }
        
        public nsISupports Handle
        {
            get
            {
                return this.GetProperty<nsISupports>("handle");
            }
        }
    }
}
