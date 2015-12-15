namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothPhonebookPullingEvent : WebIDLBase
    {
        
        public BluetoothPhonebookPullingEvent(nsISupports thisObject) : 
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
        
        public uint MaxListCount
        {
            get
            {
                return this.GetProperty<uint>("maxListCount");
            }
        }
        
        public uint ListStartOffset
        {
            get
            {
                return this.GetProperty<uint>("listStartOffset");
            }
        }
        
        public VCardProperties[] VcardSelector
        {
            get
            {
                return this.GetProperty<VCardProperties[]>("vcardSelector");
            }
        }
        
        public VCardSelectorOp VcardSelectorOperator
        {
            get
            {
                return this.GetProperty<VCardSelectorOp>("vcardSelectorOperator");
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
