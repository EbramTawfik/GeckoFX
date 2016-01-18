namespace Gecko.WebIDL
{
    using System;
    
    
    public class TelephonyCallId : WebIDLBase
    {
        
        public TelephonyCallId(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Number
        {
            get
            {
                return this.GetProperty<nsAString>("number");
            }
        }
        
        public CallIdPresentation NumberPresentation
        {
            get
            {
                return this.GetProperty<CallIdPresentation>("numberPresentation");
            }
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
        
        public CallIdPresentation NamePresentation
        {
            get
            {
                return this.GetProperty<CallIdPresentation>("namePresentation");
            }
        }
    }
}
