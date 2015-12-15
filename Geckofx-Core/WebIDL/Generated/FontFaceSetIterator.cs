namespace Gecko.WebIDL
{
    using System;
    
    
    public class FontFaceSetIterator : WebIDLBase
    {
        
        public FontFaceSetIterator(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public object Next()
        {
            return this.CallMethod<object>("next");
        }
    }
}
