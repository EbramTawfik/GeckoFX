namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozIcc : WebIDLBase
    {
        
        public MozIcc(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public WebIDLUnion<nsISupports,nsISupports,nsISupports> IccInfo
        {
            get
            {
                return this.GetProperty<WebIDLUnion<nsISupports,nsISupports,nsISupports>>("iccInfo");
            }
        }
        
        public IccCardState CardState
        {
            get
            {
                return this.GetProperty<IccCardState>("cardState");
            }
        }
        
        public void SendStkResponse(object command, object response)
        {
            this.CallVoidMethod("sendStkResponse", command, response);
        }
        
        public void SendStkMenuSelection(ushort itemIdentifier, bool helpRequested)
        {
            this.CallVoidMethod("sendStkMenuSelection", itemIdentifier, helpRequested);
        }
        
        public void SendStkTimerExpiration(object timer)
        {
            this.CallVoidMethod("sendStkTimerExpiration", timer);
        }
        
        public void SendStkEventDownload(object @event)
        {
            this.CallVoidMethod("sendStkEventDownload", @event);
        }
        
        public nsISupports GetCardLock(IccLockType lockType)
        {
            return this.CallMethod<nsISupports>("getCardLock", lockType);
        }
        
        public nsISupports UnlockCardLock(object info)
        {
            return this.CallMethod<nsISupports>("unlockCardLock", info);
        }
        
        public nsISupports SetCardLock(object info)
        {
            return this.CallMethod<nsISupports>("setCardLock", info);
        }
        
        public nsISupports GetCardLockRetryCount(IccLockType lockType)
        {
            return this.CallMethod<nsISupports>("getCardLockRetryCount", lockType);
        }
        
        public nsISupports ReadContacts(IccContactType contactType)
        {
            return this.CallMethod<nsISupports>("readContacts", contactType);
        }
        
        public nsISupports UpdateContact(IccContactType contactType, nsISupports contact, nsAString pin2)
        {
            return this.CallMethod<nsISupports>("updateContact", contactType, contact, pin2);
        }
        
        public nsISupports MatchMvno(IccMvnoType mvnoType, nsAString matchData)
        {
            return this.CallMethod<nsISupports>("matchMvno", mvnoType, matchData);
        }
        
        public Promise <bool> GetServiceState(IccService service)
        {
            return this.CallMethod<Promise <bool>>("getServiceState", service);
        }
    }
}
