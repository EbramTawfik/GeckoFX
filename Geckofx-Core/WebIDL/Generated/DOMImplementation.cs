namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMImplementation : WebIDLBase
    {
        
        public DOMImplementation(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool HasFeature(nsAString feature, nsAString version)
        {
            return this.CallMethod<bool>("hasFeature", feature, version);
        }
        
        public nsISupports CreateDocumentType(nsAString qualifiedName, nsAString publicId, nsAString systemId)
        {
            return this.CallMethod<nsISupports>("createDocumentType", qualifiedName, publicId, systemId);
        }
        
        public nsIDOMDocument CreateDocument(nsAString @namespace, nsAString qualifiedName, nsISupports doctype)
        {
            return this.CallMethod<nsIDOMDocument>("createDocument", @namespace, qualifiedName, doctype);
        }
        
        public nsIDOMDocument CreateHTMLDocument(nsAString title)
        {
            return this.CallMethod<nsIDOMDocument>("createHTMLDocument", title);
        }
    }
}
