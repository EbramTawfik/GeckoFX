namespace Gecko.WebIDL
{
    using System;
    
    
    public class XSLTProcessor : WebIDLBase
    {
        
        public XSLTProcessor(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Flags
        {
            get
            {
                return this.GetProperty<uint>("flags");
            }
            set
            {
                this.SetProperty("flags", value);
            }
        }
        
        public void ImportStylesheet(nsIDOMNode style)
        {
            this.CallVoidMethod("importStylesheet", style);
        }
        
        public nsISupports TransformToFragment(nsIDOMNode source, nsIDOMDocument output)
        {
            return this.CallMethod<nsISupports>("transformToFragment", source, output);
        }
        
        public nsIDOMDocument TransformToDocument(nsIDOMNode source)
        {
            return this.CallMethod<nsIDOMDocument>("transformToDocument", source);
        }
        
        public void SetParameter(string namespaceURI, string localName, object value)
        {
            this.CallVoidMethod("setParameter", namespaceURI, localName, value);
        }
        
        public nsISupports GetParameter(string namespaceURI, string localName)
        {
            return this.CallMethod<nsISupports>("getParameter", namespaceURI, localName);
        }
        
        public void RemoveParameter(string namespaceURI, string localName)
        {
            this.CallVoidMethod("removeParameter", namespaceURI, localName);
        }
        
        public void ClearParameters()
        {
            this.CallVoidMethod("clearParameters");
        }
        
        public void Reset()
        {
            this.CallVoidMethod("reset");
        }
    }
}
