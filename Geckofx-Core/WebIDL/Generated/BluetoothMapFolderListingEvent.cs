namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothMapFolderListingEvent : WebIDLBase
    {
        
        public BluetoothMapFolderListingEvent(nsISupports thisObject) : 
                base(thisObject)
        {
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
        
        public nsISupports Handle
        {
            get
            {
                return this.GetProperty<nsISupports>("handle");
            }
        }
    }
}
