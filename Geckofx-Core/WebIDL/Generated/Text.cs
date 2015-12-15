namespace Gecko.WebIDL
{
    using System;
    
    
    public class Text : WebIDLBase
    {
        
        public Text(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString WholeText
        {
            get
            {
                return this.GetProperty<nsAString>("wholeText");
            }
        }
        
        public nsIDOMText SplitText(uint offset)
        {
            return this.CallMethod<nsIDOMText>("splitText", offset);
        }
    }
}
