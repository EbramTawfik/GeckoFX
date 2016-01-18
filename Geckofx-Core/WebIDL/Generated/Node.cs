namespace Gecko.WebIDL
{
    using System;
    
    
    public class Node : WebIDLBase
    {
        
        public Node(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort NodeType
        {
            get
            {
                return this.GetProperty<ushort>("nodeType");
            }
        }
        
        public nsAString NodeName
        {
            get
            {
                return this.GetProperty<nsAString>("nodeName");
            }
        }
        
        public nsAString BaseURI
        {
            get
            {
                return this.GetProperty<nsAString>("baseURI");
            }
        }
        
        public nsIDOMDocument OwnerDocument
        {
            get
            {
                return this.GetProperty<nsIDOMDocument>("ownerDocument");
            }
        }
        
        public nsIDOMNode ParentNode
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("parentNode");
            }
        }
        
        public nsIDOMElement ParentElement
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("parentElement");
            }
        }
        
        public nsISupports ChildNodes
        {
            get
            {
                return this.GetProperty<nsISupports>("childNodes");
            }
        }
        
        public nsIDOMNode FirstChild
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("firstChild");
            }
        }
        
        public nsIDOMNode LastChild
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("lastChild");
            }
        }
        
        public nsIDOMNode PreviousSibling
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("previousSibling");
            }
        }
        
        public nsIDOMNode NextSibling
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("nextSibling");
            }
        }
        
        public nsAString NodeValue
        {
            get
            {
                return this.GetProperty<nsAString>("nodeValue");
            }
            set
            {
                this.SetProperty("nodeValue", value);
            }
        }
        
        public nsAString TextContent
        {
            get
            {
                return this.GetProperty<nsAString>("textContent");
            }
            set
            {
                this.SetProperty("textContent", value);
            }
        }
        
        public nsAString NamespaceURI
        {
            get
            {
                return this.GetProperty<nsAString>("namespaceURI");
            }
        }
        
        public nsAString Prefix
        {
            get
            {
                return this.GetProperty<nsAString>("prefix");
            }
        }
        
        public nsAString LocalName
        {
            get
            {
                return this.GetProperty<nsAString>("localName");
            }
        }
        
        public nsISupports NodePrincipal
        {
            get
            {
                return this.GetProperty<nsISupports>("nodePrincipal");
            }
        }
        
        public nsISupports BaseURIObject
        {
            get
            {
                return this.GetProperty<nsISupports>("baseURIObject");
            }
        }
        
        public bool HasChildNodes()
        {
            return this.CallMethod<bool>("hasChildNodes");
        }
        
        public nsIDOMNode InsertBefore(nsIDOMNode node, nsIDOMNode child)
        {
            return this.CallMethod<nsIDOMNode>("insertBefore", node, child);
        }
        
        public nsIDOMNode AppendChild(nsIDOMNode node)
        {
            return this.CallMethod<nsIDOMNode>("appendChild", node);
        }
        
        public nsIDOMNode ReplaceChild(nsIDOMNode node, nsIDOMNode child)
        {
            return this.CallMethod<nsIDOMNode>("replaceChild", node, child);
        }
        
        public nsIDOMNode RemoveChild(nsIDOMNode child)
        {
            return this.CallMethod<nsIDOMNode>("removeChild", child);
        }
        
        public void Normalize()
        {
            this.CallVoidMethod("normalize");
        }
        
        public nsIDOMNode CloneNode()
        {
            return this.CallMethod<nsIDOMNode>("cloneNode");
        }
        
        public nsIDOMNode CloneNode(bool deep)
        {
            return this.CallMethod<nsIDOMNode>("cloneNode", deep);
        }
        
        public bool IsEqualNode(nsIDOMNode node)
        {
            return this.CallMethod<bool>("isEqualNode", node);
        }
        
        public ushort CompareDocumentPosition(nsIDOMNode other)
        {
            return this.CallMethod<ushort>("compareDocumentPosition", other);
        }
        
        public bool Contains(nsIDOMNode other)
        {
            return this.CallMethod<bool>("contains", other);
        }
        
        public nsAString LookupPrefix(nsAString @namespace)
        {
            return this.CallMethod<nsAString>("lookupPrefix", @namespace);
        }
        
        public nsAString LookupNamespaceURI(nsAString prefix)
        {
            return this.CallMethod<nsAString>("lookupNamespaceURI", prefix);
        }
        
        public bool IsDefaultNamespace(nsAString @namespace)
        {
            return this.CallMethod<bool>("isDefaultNamespace", @namespace);
        }
        
        public object SetUserData(nsAString key, object data)
        {
            return this.CallMethod<object>("setUserData", key, data);
        }
        
        public object GetUserData(nsAString key)
        {
            return this.CallMethod<object>("getUserData", key);
        }
        
        public nsISupports[] GetBoundMutationObservers()
        {
            return this.CallMethod<nsISupports[]>("getBoundMutationObservers");
        }
    }
}
