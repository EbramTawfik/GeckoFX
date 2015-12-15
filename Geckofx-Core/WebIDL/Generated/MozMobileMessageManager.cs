namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozMobileMessageManager : WebIDLBase
    {
        
        public MozMobileMessageManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports GetSegmentInfoForText(nsAString text)
        {
            return this.CallMethod<nsISupports>("getSegmentInfoForText", text);
        }
        
        public nsISupports Send(nsAString number, nsAString text, object sendParameters)
        {
            return this.CallMethod<nsISupports>("send", number, text, sendParameters);
        }
        
        public nsISupports[] Send(nsAString[] numbers, nsAString text, object sendParameters)
        {
            return this.CallMethod<nsISupports[]>("send", numbers, text, sendParameters);
        }
        
        public nsISupports SendMMS(object parameters, object sendParameters)
        {
            return this.CallMethod<nsISupports>("sendMMS", parameters, sendParameters);
        }
        
        public nsISupports GetMessage(int id)
        {
            return this.CallMethod<nsISupports>("getMessage", id);
        }
        
        public nsISupports Delete(int id)
        {
            return this.CallMethod<nsISupports>("delete", id);
        }
        
        public nsISupports Delete(nsISupports message)
        {
            return this.CallMethod<nsISupports>("delete", message);
        }
        
        public nsISupports Delete(WebIDLUnion<System.Int32,nsISupports,nsISupports> @params)
        {
            return this.CallMethod<nsISupports>("delete", @params);
        }
        
        public nsISupports GetMessages(object filter, bool reverse)
        {
            return this.CallMethod<nsISupports>("getMessages", filter, reverse);
        }
        
        public nsISupports MarkMessageRead(int id, bool read, bool sendReadReport)
        {
            return this.CallMethod<nsISupports>("markMessageRead", id, read, sendReadReport);
        }
        
        public nsISupports GetThreads()
        {
            return this.CallMethod<nsISupports>("getThreads");
        }
        
        public nsISupports RetrieveMMS(int id)
        {
            return this.CallMethod<nsISupports>("retrieveMMS", id);
        }
        
        public nsISupports RetrieveMMS(nsISupports message)
        {
            return this.CallMethod<nsISupports>("retrieveMMS", message);
        }
        
        public Promise <object> GetSmscAddress(uint serviceId)
        {
            return this.CallMethod<Promise <object>>("getSmscAddress", serviceId);
        }
        
        public Promise SetSmscAddress(object smscAddress, uint serviceId)
        {
            return this.CallMethod<Promise>("setSmscAddress", smscAddress, serviceId);
        }
    }
}
