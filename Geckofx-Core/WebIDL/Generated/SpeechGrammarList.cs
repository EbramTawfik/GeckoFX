namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechGrammarList : WebIDLBase
    {
        
        public SpeechGrammarList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public void AddFromURI(nsAString src)
        {
            this.CallVoidMethod("addFromURI", src);
        }
        
        public void AddFromURI(nsAString src, float weight)
        {
            this.CallVoidMethod("addFromURI", src, weight);
        }
        
        public void AddFromString(nsAString @string)
        {
            this.CallVoidMethod("addFromString", @string);
        }
        
        public void AddFromString(nsAString @string, float weight)
        {
            this.CallVoidMethod("addFromString", @string, weight);
        }
    }
}
