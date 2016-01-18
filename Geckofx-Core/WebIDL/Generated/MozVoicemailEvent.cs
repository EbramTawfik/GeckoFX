namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozVoicemailEvent : WebIDLBase
    {
        
        public MozVoicemailEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Status
        {
            get
            {
                return this.GetProperty<nsISupports>("status");
            }
        }
    }
}
