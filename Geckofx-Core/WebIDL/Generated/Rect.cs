namespace Gecko.WebIDL
{
    using System;
    
    
    public class Rect : WebIDLBase
    {
        
        public Rect(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Top
        {
            get
            {
                return this.GetProperty<nsISupports>("top");
            }
        }
        
        public nsISupports Right
        {
            get
            {
                return this.GetProperty<nsISupports>("right");
            }
        }
        
        public nsISupports Bottom
        {
            get
            {
                return this.GetProperty<nsISupports>("bottom");
            }
        }
        
        public nsISupports Left
        {
            get
            {
                return this.GetProperty<nsISupports>("left");
            }
        }
    }
}
