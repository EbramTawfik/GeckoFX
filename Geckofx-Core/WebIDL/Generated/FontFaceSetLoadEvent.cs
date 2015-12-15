namespace Gecko.WebIDL
{
    using System;
    
    
    public class FontFaceSetLoadEvent : WebIDLBase
    {
        
        public FontFaceSetLoadEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports[] Fontfaces
        {
            get
            {
                return this.GetProperty<nsISupports[]>("fontfaces");
            }
        }
    }
}
