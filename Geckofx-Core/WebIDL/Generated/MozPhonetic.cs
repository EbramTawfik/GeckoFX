namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozPhonetic : WebIDLBase
    {
        
        public MozPhonetic(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Phonetic
        {
            get
            {
                return this.GetProperty<nsAString>("phonetic");
            }
        }
    }
}
