namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothPbapRequestHandle : WebIDLBase
    {
        
        public BluetoothPbapRequestHandle(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports ReplyTovCardPulling(nsIDOMBlob vcardObject)
        {
            return this.CallMethod<nsISupports>("replyTovCardPulling", vcardObject);
        }
        
        public nsISupports ReplyToPhonebookPulling(nsIDOMBlob vcardObject, ulong phonebookSize)
        {
            return this.CallMethod<nsISupports>("replyToPhonebookPulling", vcardObject, phonebookSize);
        }
        
        public nsISupports ReplyTovCardListing(nsIDOMBlob vcardObject, ulong phonebookSize)
        {
            return this.CallMethod<nsISupports>("replyTovCardListing", vcardObject, phonebookSize);
        }
    }
}
