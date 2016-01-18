namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechRecognitionResultList : WebIDLBase
    {
        
        public SpeechRecognitionResultList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
