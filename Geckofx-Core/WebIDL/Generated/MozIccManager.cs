namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozIccManager : WebIDLBase
    {
        
        public MozIccManager(nsISupports thisObject) : 
                base(thisObject)
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
