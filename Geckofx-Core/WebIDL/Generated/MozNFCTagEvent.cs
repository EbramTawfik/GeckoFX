namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNFCTagEvent : WebIDLBase
    {
        
        public MozNFCTagEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Tag
        {
            get
            {
                return this.GetProperty<nsISupports>("tag");
            }
        }
        
        public nsISupports[] NdefRecords
        {
            get
            {
                return this.GetProperty<nsISupports[]>("ndefRecords");
            }
        }
    }
}
