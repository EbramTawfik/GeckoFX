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
        
        public string NodeName
        {
            get
            {
                return this.GetProperty<string>("nodeName");
            }
        }
        
        public string BaseURI
        {
            get
            {
                return this.GetProperty<string>("baseURI");
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
        
        public string NodeValue
        {
            get
            {
                return this.GetProperty<string>("nodeValue");
            }
            set
            {
                this.SetProperty("nodeValue", value);
            }
        }
        
        public string TextContent
        {
            get
            {
                return this.GetProperty<string>("textContent");
            }
            set
            {
                this.SetProperty("textContent", value);
            }
        }
        
        public string NamespaceURI
        {
            get
            {
                return this.GetProperty<string>("namespaceURI");
            }
        }
        
        public string Prefix
        {
            get
            {
                return this.GetProperty<string>("prefix");
            }
        }
        
        public string LocalName
        {
            get
            {
                return this.GetProperty<string>("localName");
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
        
        public string LookupPrefix(string @namespace)
        {
            return this.CallMethod<string>("lookupPrefix", @namespace);
        }
        
        public string LookupNamespaceURI(string prefix)
        {
            return this.CallMethod<string>("lookupNamespaceURI", prefix);
        }
        
        public bool IsDefaultNamespace(string @namespace)
        {
            return this.CallMethod<bool>("isDefaultNamespace", @namespace);
        }
        
        public object SetUserData(string key, object data)
        {
            return this.CallMethod<object>("setUserData", key, data);
        }
        
        public object GetUserData(string key)
        {
            return this.CallMethod<object>("getUserData", key);
        }
        
        public nsISupports[] GetBoundMutationObservers()
        {
            return this.CallMethod<nsISupports[]>("getBoundMutationObservers");
        }
    }
}
