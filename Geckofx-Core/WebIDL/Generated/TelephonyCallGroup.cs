namespace Gecko.WebIDL
{
    using System;
    
    
    public class TelephonyCallGroup : WebIDLBase
    {
        
        public TelephonyCallGroup(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Calls
        {
            get
            {
                return this.GetProperty<nsISupports>("calls");
            }
        }
        
        public TelephonyCallGroupState State
        {
            get
            {
                return this.GetProperty<TelephonyCallGroupState>("state");
            }
        }
        
        public Promise Add(nsISupports call)
        {
            return this.CallMethod<Promise>("add", call);
        }
        
        public Promise Add(nsISupports call, nsISupports secondCall)
        {
            return this.CallMethod<Promise>("add", call, secondCall);
        }
        
        public Promise Remove(nsISupports call)
        {
            return this.CallMethod<Promise>("remove", call);
        }
        
        public Promise HangUp()
        {
            return this.CallMethod<Promise>("hangUp");
        }
        
        public Promise Hold()
        {
            return this.CallMethod<Promise>("hold");
        }
        
        public Promise Resume()
        {
            return this.CallMethod<Promise>("resume");
        }
    }
}
