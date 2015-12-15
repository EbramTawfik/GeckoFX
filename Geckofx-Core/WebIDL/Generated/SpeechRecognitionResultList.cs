namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechRecognitionResultList : WebIDLBase
    {
        
        public SpeechRecognitionResultList(nsISupports thisObject) : 
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
