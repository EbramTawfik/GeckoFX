namespace Gecko.WebIDL
{
    using System;
    
    
    public class TelephonyCallId : WebIDLBase
    {
        
        public TelephonyCallId(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Number
        {
            get
            {
                return this.GetProperty<string>("number");
            }
        }
        
        public CallIdPresentation NumberPresentation
        {
            get
            {
                return this.GetProperty<CallIdPresentation>("numberPresentation");
            }
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
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
