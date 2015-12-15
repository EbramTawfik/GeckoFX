namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechGrammarList : WebIDLBase
    {
        
        public SpeechGrammarList(nsISupports thisObject) : 
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
        
        public void AddFromURI(nsAString src, float weight)
        {
            this.CallVoidMethod("addFromURI", src, weight);
        }
        
        public void AddFromString(nsAString @string, float weight)
        {
            this.CallVoidMethod("addFromString", @string, weight);
        }
    }
}
