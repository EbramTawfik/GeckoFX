namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMQuad : WebIDLBase
    {
        
        public DOMQuad(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports P1
        {
            get
            {
                return this.GetProperty<nsISupports>("p1");
            }
        }
        
        public nsISupports P2
        {
            get
            {
                return this.GetProperty<nsISupports>("p2");
            }
        }
        
        public nsISupports P3
        {
            get
            {
                return this.GetProperty<nsISupports>("p3");
            }
        }
        
        public nsISupports P4
        {
            get
            {
                return this.GetProperty<nsISupports>("p4");
            }
        }
        
        public nsISupports Bounds
        {
            get
            {
                return this.GetProperty<nsISupports>("bounds");
            }
        }
    }
}
