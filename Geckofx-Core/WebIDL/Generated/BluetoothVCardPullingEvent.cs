namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothVCardPullingEvent : WebIDLBase
    {
        
        public BluetoothVCardPullingEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
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
