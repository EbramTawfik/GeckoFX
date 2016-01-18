namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothVCardListingEvent : WebIDLBase
    {
        
        public BluetoothVCardListingEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public VCardOrderType Order
        {
            get
            {
                return this.GetProperty<VCardOrderType>("order");
            }
        }
        
        public string SearchValue
        {
            get
            {
                return this.GetProperty<string>("searchValue");
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
