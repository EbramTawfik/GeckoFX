namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozIccManager : WebIDLBase
    {
        
        public MozIccManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString[] IccIds
        {
            get
            {
                return this.GetProperty<nsAString[]>("iccIds");
            }
        }
        
        public nsISupports GetIccById(nsAString iccId)
        {
            return this.CallMethod<nsISupports>("getIccById", iccId);
        }
    }
}
