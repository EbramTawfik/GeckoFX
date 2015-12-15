namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozVoicemailEvent : WebIDLBase
    {
        
        public MozVoicemailEvent(nsISupports thisObject) : 
                base(thisObject)
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
