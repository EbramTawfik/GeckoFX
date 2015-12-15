namespace Gecko.WebIDL
{
    using System;
    
    
    public class StyleSheetList : WebIDLBase
    {
        
        public StyleSheetList(nsISupports thisObject) : 
                base(thisObject)
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
