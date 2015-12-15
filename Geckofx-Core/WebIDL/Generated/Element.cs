namespace Gecko.WebIDL
{
    using System;
    
    
    public class Element : WebIDLBase
    {
        
        public Element(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString TagName
        {
            get
            {
                return this.GetProperty<nsAString>("tagName");
            }
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
            }
            set
            {
                this.SetProperty("id", value);
            }
        }
        
        public nsAString ClassName
        {
            get
            {
                return this.GetProperty<nsAString>("className");
            }
            set
            {
                this.SetProperty("className", value);
            }
        }
        
        public nsISupports ClassList
        {
            get
            {
                return this.GetProperty<nsISupports>("classList");
            }
        }
        
        public nsISupports Attributes
        {
            get
            {
                return this.GetProperty<nsISupports>("attributes");
            }
        }
        
        public float FontSizeInflation
        {
            get
            {
                return this.GetProperty<float>("fontSizeInflation");
            }
        }
        
        public nsAString[] GetAttributeNames()
        {
            return this.CallMethod<nsAString[]>("getAttributeNames");
        }
        
        public nsAString GetAttribute(nsAString name)
        {
            return this.CallMethod<nsAString>("getAttribute", name);
        }
        
        public nsAString GetAttributeNS(nsAString @namespace, nsAString localName)
        {
            return this.CallMethod<nsAString>("getAttributeNS", @namespace, localName);
        }
        
        public void SetAttribute(nsAString name, nsAString value)
        {
            this.CallVoidMethod("setAttribute", name, value);
        }
        
        public void SetAttributeNS(nsAString @namespace, nsAString name, nsAString value)
        {
            this.CallVoidMethod("setAttributeNS", @namespace, name, value);
        }
        
        public void RemoveAttribute(nsAString name)
        {
            this.CallVoidMethod("removeAttribute", name);
        }
        
        public void RemoveAttributeNS(nsAString @namespace, nsAString localName)
        {
            this.CallVoidMethod("removeAttributeNS", @namespace, localName);
        }
        
        public bool HasAttribute(nsAString name)
        {
            return this.CallMethod<bool>("hasAttribute", name);
        }
        
        public bool HasAttributeNS(nsAString @namespace, nsAString localName)
        {
            return this.CallMethod<bool>("hasAttributeNS", @namespace, localName);
        }
        
        public bool HasAttributes()
        {
            return this.CallMethod<bool>("hasAttributes");
        }
        
        public nsIDOMElement Closest(nsAString selector)
        {
            return this.CallMethod<nsIDOMElement>("closest", selector);
        }
        
        public bool Matches(nsAString selector)
        {
            return this.CallMethod<bool>("matches", selector);
        }
        
        public bool WebkitMatchesSelector(nsAString selector)
        {
            return this.CallMethod<bool>("webkitMatchesSelector", selector);
        }
        
        public nsISupports GetElementsByTagName(nsAString localName)
        {
            return this.CallMethod<nsISupports>("getElementsByTagName", localName);
        }
        
        public nsISupports GetElementsByTagNameNS(nsAString @namespace, nsAString localName)
        {
            return this.CallMethod<nsISupports>("getElementsByTagNameNS", @namespace, localName);
        }
        
        public nsISupports GetElementsByClassName(nsAString classNames)
        {
            return this.CallMethod<nsISupports>("getElementsByClassName", classNames);
        }
        
        public bool MozMatchesSelector(nsAString selector)
        {
            return this.CallMethod<bool>("mozMatchesSelector", selector);
        }
        
        public void SetPointerCapture(int pointerId)
        {
            this.CallVoidMethod("setPointerCapture", pointerId);
        }
        
        public void ReleasePointerCapture(int pointerId)
        {
            this.CallVoidMethod("releasePointerCapture", pointerId);
        }
        
        public void SetCapture(bool retargetToElement)
        {
            this.CallVoidMethod("setCapture", retargetToElement);
        }
        
        public void ReleaseCapture()
        {
            this.CallVoidMethod("releaseCapture");
        }
        
        public void MozRequestFullScreen(object options)
        {
            this.CallVoidMethod("mozRequestFullScreen", options);
        }
        
        public void MozRequestPointerLock()
        {
            this.CallVoidMethod("mozRequestPointerLock");
        }
        
        public nsISupports GetAttributeNode(nsAString name)
        {
            return this.CallMethod<nsISupports>("getAttributeNode", name);
        }
        
        public nsISupports SetAttributeNode(nsISupports newAttr)
        {
            return this.CallMethod<nsISupports>("setAttributeNode", newAttr);
        }
        
        public nsISupports RemoveAttributeNode(nsISupports oldAttr)
        {
            return this.CallMethod<nsISupports>("removeAttributeNode", oldAttr);
        }
        
        public nsISupports GetAttributeNodeNS(nsAString namespaceURI, nsAString localName)
        {
            return this.CallMethod<nsISupports>("getAttributeNodeNS", namespaceURI, localName);
        }
        
        public nsISupports SetAttributeNodeNS(nsISupports newAttr)
        {
            return this.CallMethod<nsISupports>("setAttributeNodeNS", newAttr);
        }
        
        public bool ScrollByNoFlush(int dx, int dy)
        {
            return this.CallMethod<bool>("scrollByNoFlush", dx, dy);
        }
        
        public int ScrollTop
        {
            get
            {
                return this.GetProperty<int>("scrollTop");
            }
            set
            {
                this.SetProperty("scrollTop", value);
            }
        }
        
        public int ScrollLeft
        {
            get
            {
                return this.GetProperty<int>("scrollLeft");
            }
            set
            {
                this.SetProperty("scrollLeft", value);
            }
        }
        
        public int ScrollWidth
        {
            get
            {
                return this.GetProperty<int>("scrollWidth");
            }
        }
        
        public int ScrollHeight
        {
            get
            {
                return this.GetProperty<int>("scrollHeight");
            }
        }
        
        public int ClientTop
        {
            get
            {
                return this.GetProperty<int>("clientTop");
            }
        }
        
        public int ClientLeft
        {
            get
            {
                return this.GetProperty<int>("clientLeft");
            }
        }
        
        public int ClientWidth
        {
            get
            {
                return this.GetProperty<int>("clientWidth");
            }
        }
        
        public int ClientHeight
        {
            get
            {
                return this.GetProperty<int>("clientHeight");
            }
        }
        
        public int ScrollTopMin
        {
            get
            {
                return this.GetProperty<int>("scrollTopMin");
            }
        }
        
        public int ScrollTopMax
        {
            get
            {
                return this.GetProperty<int>("scrollTopMax");
            }
        }
        
        public int ScrollLeftMin
        {
            get
            {
                return this.GetProperty<int>("scrollLeftMin");
            }
        }
        
        public int ScrollLeftMax
        {
            get
            {
                return this.GetProperty<int>("scrollLeftMax");
            }
        }
        
        public nsISupports GetClientRects()
        {
            return this.CallMethod<nsISupports>("getClientRects");
        }
        
        public nsISupports GetBoundingClientRect()
        {
            return this.CallMethod<nsISupports>("getBoundingClientRect");
        }
        
        public void ScrollIntoView(bool top)
        {
            this.CallVoidMethod("scrollIntoView", top);
        }
        
        public void ScrollIntoView(object options)
        {
            this.CallVoidMethod("scrollIntoView", options);
        }
        
        public void Scroll(double x, double y)
        {
            this.CallVoidMethod("scroll", x, y);
        }
        
        public void Scroll(object options)
        {
            this.CallVoidMethod("scroll", options);
        }
        
        public void ScrollTo(double x, double y)
        {
            this.CallVoidMethod("scrollTo", x, y);
        }
        
        public void ScrollTo(object options)
        {
            this.CallVoidMethod("scrollTo", options);
        }
        
        public void ScrollBy(double x, double y)
        {
            this.CallVoidMethod("scrollBy", x, y);
        }
        
        public void ScrollBy(object options)
        {
            this.CallVoidMethod("scrollBy", options);
        }
        
        public void MozScrollSnap()
        {
            this.CallVoidMethod("mozScrollSnap");
        }
        
        public nsISupports UndoManager
        {
            get
            {
                return this.GetProperty<nsISupports>("undoManager");
            }
        }
        
        public bool UndoScope
        {
            get
            {
                return this.GetProperty<bool>("undoScope");
            }
            set
            {
                this.SetProperty("undoScope", value);
            }
        }
        
        public nsAString InnerHTML
        {
            get
            {
                return this.GetProperty<nsAString>("innerHTML");
            }
            set
            {
                this.SetProperty("innerHTML", value);
            }
        }
        
        public nsAString OuterHTML
        {
            get
            {
                return this.GetProperty<nsAString>("outerHTML");
            }
            set
            {
                this.SetProperty("outerHTML", value);
            }
        }
        
        public void InsertAdjacentHTML(nsAString position, nsAString text)
        {
            this.CallVoidMethod("insertAdjacentHTML", position, text);
        }
        
        public nsIDOMElement QuerySelector(nsAString selectors)
        {
            return this.CallMethod<nsIDOMElement>("querySelector", selectors);
        }
        
        public nsISupports QuerySelectorAll(nsAString selectors)
        {
            return this.CallMethod<nsISupports>("querySelectorAll", selectors);
        }
        
        public nsISupports ShadowRoot
        {
            get
            {
                return this.GetProperty<nsISupports>("shadowRoot");
            }
        }
        
        public nsISupports CreateShadowRoot()
        {
            return this.CallMethod<nsISupports>("createShadowRoot");
        }
        
        public nsISupports GetDestinationInsertionPoints()
        {
            return this.CallMethod<nsISupports>("getDestinationInsertionPoints");
        }
    }
}
