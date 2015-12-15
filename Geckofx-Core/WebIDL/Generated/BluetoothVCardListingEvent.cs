namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothVCardListingEvent : WebIDLBase
    {
        
        public BluetoothVCardListingEvent(nsISupports thisObject) : 
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
        
        public VCardOrderType Order
        {
            get
            {
                return this.GetProperty<VCardOrderType>("order");
            }
        }
        
        public nsAString SearchValue
        {
            get
            {
                return this.GetProperty<nsAString>("searchValue");
            }
        }
        
        public VCardSearchKeyType SearchKey
        {
            get
            {
                return this.GetProperty<VCardSearchKeyType>("searchKey");
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
