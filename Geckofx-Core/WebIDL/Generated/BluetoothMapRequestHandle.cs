namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothMapRequestHandle : WebIDLBase
    {
        
        public BluetoothMapRequestHandle(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise ReplyToFolderListing(int masId, string folders)
        {
            return this.CallMethod<Promise>("replyToFolderListing", masId, folders);
        }
        
        public Promise ReplyToMessagesListing(int masId, nsIDOMBlob messageslisting, bool newmessage, string timestamp, uint size)
        {
            return this.CallMethod<Promise>("replyToMessagesListing", masId, messageslisting, newmessage, timestamp, size);
        }
        
        public Promise ReplyToGetMessage(int masId, nsIDOMBlob bmessage)
        {
            return this.CallMethod<Promise>("replyToGetMessage", masId, bmessage);
        }
        
        public Promise ReplyToSetMessageStatus(int masId, bool status)
        {
            return this.CallMethod<Promise>("replyToSetMessageStatus", masId, status);
        }
        
        public Promise ReplyToSendMessage(int masId, string handleId, bool status)
        {
            return this.CallMethod<Promise>("replyToSendMessage", masId, handleId, status);
        }
        
        public Promise ReplyToMessageUpdate(int masId, bool status)
        {
            return this.CallMethod<Promise>("replyToMessageUpdate", masId, status);
        }
    }
}
