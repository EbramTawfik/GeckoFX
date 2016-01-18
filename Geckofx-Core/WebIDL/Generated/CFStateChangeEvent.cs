namespace Gecko.WebIDL
{
    using System;
    
    
    public class CFStateChangeEvent : WebIDLBase
    {
        
        public CFStateChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort Action
        {
            get
            {
                return this.GetProperty<ushort>("action");
            }
        }
        
        public ushort Reason
        {
            get
            {
                return this.GetProperty<ushort>("reason");
            }
        }
        
        public nsAString Number
        {
            get
            {
                return this.GetProperty<nsAString>("number");
            }
        }
        
        public ushort TimeSeconds
        {
            get
            {
                return this.GetProperty<ushort>("timeSeconds");
            }
        }
        
        public ushort ServiceClass
        {
            get
            {
                return this.GetProperty<ushort>("serviceClass");
            }
        }
    }
}
