namespace Gecko.WebIDL
{
    using System;
    
    
    public class StyleSheetList : WebIDLBase
    {
        
        public StyleSheetList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
    }
}
