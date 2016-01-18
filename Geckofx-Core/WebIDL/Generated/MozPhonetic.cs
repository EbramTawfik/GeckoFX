namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozPhonetic : WebIDLBase
    {
        
        public MozPhonetic(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Phonetic
        {
            get
            {
                return this.GetProperty<string>("phonetic");
            }
        }
    }
}
