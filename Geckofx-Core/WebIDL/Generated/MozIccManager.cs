namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozIccManager : WebIDLBase
    {
        
        public MozIccManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string[] IccIds
        {
            get
            {
                return this.GetProperty<string[]>("iccIds");
            }
        }
        
        public nsISupports GetIccById(string iccId)
        {
            return this.CallMethod<nsISupports>("getIccById", iccId);
        }
    }
}
