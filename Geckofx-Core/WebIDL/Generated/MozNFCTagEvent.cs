namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNFCTagEvent : WebIDLBase
    {
        
        public MozNFCTagEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
