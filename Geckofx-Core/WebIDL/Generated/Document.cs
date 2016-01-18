namespace Gecko.WebIDL
{
    using System;
    
    
    public class Document : WebIDLBase
    {
        
        public Document(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Implementation
        {
            get
            {
                return this.GetProperty<nsISupports>("implementation");
            }
        }
        
        public string URL
        {
            get
            {
                return this.GetProperty<string>("URL");
            }
        }
        
        public string DocumentURI
        {
            get
            {
                return this.GetProperty<string>("documentURI");
            }
        }
        
        public string CompatMode
        {
            get
            {
                return this.GetProperty<string>("compatMode");
            }
        }
        
        public string CharacterSet
        {
            get
            {
                return this.GetProperty<string>("characterSet");
            }
        }
        
        public string Charset
        {
            get
            {
                return this.GetProperty<string>("charset");
            }
        }
        
        public string InputEncoding
        {
            get
            {
                return this.GetProperty<string>("inputEncoding");
            }
        }
        
        public string ContentType
        {
            get
            {
                return this.GetProperty<string>("contentType");
            }
        }
        
        public nsISupports Doctype
        {
            get
            {
                return this.GetProperty<nsISupports>("doctype");
            }
        }
        
        public nsIDOMElement DocumentElement
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("documentElement");
            }
        }
        
        public nsISupports GetElementsByTagName(string localName)
        {
            return this.CallMethod<nsISupports>("getElementsByTagName", localName);
        }
        
        public nsISupports GetElementsByTagNameNS(string @namespace, string localName)
        {
            return this.CallMethod<nsISupports>("getElementsByTagNameNS", @namespace, localName);
        }
        
        public nsISupports GetElementsByClassName(string classNames)
        {
            return this.CallMethod<nsISupports>("getElementsByClassName", classNames);
        }
        
        public nsIDOMElement GetElementById(string elementId)
        {
            return this.CallMethod<nsIDOMElement>("getElementById", elementId);
        }
        
        public nsIDOMElement CreateElement(string localName)
        {
            return this.CallMethod<nsIDOMElement>("createElement", localName);
        }
        
        public nsIDOMElement CreateElementNS(string @namespace, string qualifiedName)
        {
            return this.CallMethod<nsIDOMElement>("createElementNS", @namespace, qualifiedName);
        }
        
        public nsISupports CreateDocumentFragment()
        {
            return this.CallMethod<nsISupports>("createDocumentFragment");
        }
        
        public nsIDOMText CreateTextNode(string data)
        {
            return this.CallMethod<nsIDOMText>("createTextNode", data);
        }
        
        public nsISupports CreateComment(string data)
        {
            return this.CallMethod<nsISupports>("createComment", data);
        }
        
        public nsISupports CreateProcessingInstruction(string target, string data)
        {
            return this.CallMethod<nsISupports>("createProcessingInstruction", target, data);
        }
        
        public nsIDOMNode ImportNode(nsIDOMNode node)
        {
            return this.CallMethod<nsIDOMNode>("importNode", node);
        }
        
        public nsIDOMNode ImportNode(nsIDOMNode node, bool deep)
        {
            return this.CallMethod<nsIDOMNode>("importNode", node, deep);
        }
        
        public nsIDOMNode AdoptNode(nsIDOMNode node)
        {
            return this.CallMethod<nsIDOMNode>("adoptNode", node);
        }
        
        public nsIDOMEvent CreateEvent(string @interface)
        {
            return this.CallMethod<nsIDOMEvent>("createEvent", @interface);
        }
        
        public nsISupports CreateRange()
        {
            return this.CallMethod<nsISupports>("createRange");
        }
        
        public nsISupports CreateNodeIterator(nsIDOMNode root)
        {
            return this.CallMethod<nsISupports>("createNodeIterator", root);
        }
        
        public nsISupports CreateNodeIterator(nsIDOMNode root, uint whatToShow)
        {
            return this.CallMethod<nsISupports>("createNodeIterator", root, whatToShow);
        }
        
        public nsISupports CreateNodeIterator(nsIDOMNode root, uint whatToShow, nsISupports filter)
        {
            return this.CallMethod<nsISupports>("createNodeIterator", root, whatToShow, filter);
        }
        
        public nsISupports CreateTreeWalker(nsIDOMNode root)
        {
            return this.CallMethod<nsISupports>("createTreeWalker", root);
        }
        
        public nsISupports CreateTreeWalker(nsIDOMNode root, uint whatToShow)
        {
            return this.CallMethod<nsISupports>("createTreeWalker", root, whatToShow);
        }
        
        public nsISupports CreateTreeWalker(nsIDOMNode root, uint whatToShow, nsISupports filter)
        {
            return this.CallMethod<nsISupports>("createTreeWalker", root, whatToShow, filter);
        }
        
        public nsISupports CreateCDATASection(string data)
        {
            return this.CallMethod<nsISupports>("createCDATASection", data);
        }
        
        public nsISupports CreateAttribute(string name)
        {
            return this.CallMethod<nsISupports>("createAttribute", name);
        }
        
        public nsISupports CreateAttributeNS(string @namespace, string name)
        {
            return this.CallMethod<nsISupports>("createAttributeNS", @namespace, name);
        }
        
        public nsIDOMLocation Location
        {
            get
            {
                return this.GetProperty<nsIDOMLocation>("location");
            }
        }
        
        public string Referrer
        {
            get
            {
                return this.GetProperty<string>("referrer");
            }
        }
        
        public string LastModified
        {
            get
            {
                return this.GetProperty<string>("lastModified");
            }
        }
        
        public string ReadyState
        {
            get
            {
                return this.GetProperty<string>("readyState");
            }
        }
        
        public string Title
        {
            get
            {
                return this.GetProperty<string>("title");
            }
            set
            {
                this.SetProperty("title", value);
            }
        }
        
        public string Dir
        {
            get
            {
                return this.GetProperty<string>("dir");
            }
            set
            {
                this.SetProperty("dir", value);
            }
        }
        
        public nsIDOMWindow DefaultView
        {
            get
            {
                return this.GetProperty<nsIDOMWindow>("defaultView");
            }
        }
        
        public nsIDOMElement ActiveElement
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("activeElement");
            }
        }
        
        public bool MozSyntheticDocument
        {
            get
            {
                return this.GetProperty<bool>("mozSyntheticDocument");
            }
        }
        
        public nsIDOMElement CurrentScript
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("currentScript");
            }
        }
        
        public nsISupports DocumentURIObject
        {
            get
            {
                return this.GetProperty<nsISupports>("documentURIObject");
            }
        }
        
        public uint ReferrerPolicy
        {
            get
            {
                return this.GetProperty<uint>("referrerPolicy");
            }
        }
        
        public bool HasFocus()
        {
            return this.CallMethod<bool>("hasFocus");
        }
        
        public void ReleaseCapture()
        {
            this.CallVoidMethod("releaseCapture");
        }
        
        public void MozSetImageElement(string aImageElementId, nsIDOMElement aImageElement)
        {
            this.CallVoidMethod("mozSetImageElement", aImageElementId, aImageElement);
        }
        
        public bool MozFullScreenEnabled
        {
            get
            {
                return this.GetProperty<bool>("mozFullScreenEnabled");
            }
        }
        
        public nsIDOMElement MozFullScreenElement
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("mozFullScreenElement");
            }
        }
        
        public bool MozFullScreen
        {
            get
            {
                return this.GetProperty<bool>("mozFullScreen");
            }
        }
        
        public void MozCancelFullScreen()
        {
            this.CallVoidMethod("mozCancelFullScreen");
        }
        
        public nsIDOMElement MozPointerLockElement
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("mozPointerLockElement");
            }
        }
        
        public void MozExitPointerLock()
        {
            this.CallVoidMethod("mozExitPointerLock");
        }
        
        public object RegisterElement(string name)
        {
            return this.CallMethod<object>("registerElement", name);
        }
        
        public object RegisterElement(string name, object options)
        {
            return this.CallMethod<object>("registerElement", name, options);
        }
        
        public nsIDOMElement CreateElement(string localName, string typeExtension)
        {
            return this.CallMethod<nsIDOMElement>("createElement", localName, typeExtension);
        }
        
        public nsIDOMElement CreateElementNS(string @namespace, string qualifiedName, string typeExtension)
        {
            return this.CallMethod<nsIDOMElement>("createElementNS", @namespace, qualifiedName, typeExtension);
        }
        
        public bool Hidden
        {
            get
            {
                return this.GetProperty<bool>("hidden");
            }
        }
        
        public bool MozHidden
        {
            get
            {
                return this.GetProperty<bool>("mozHidden");
            }
        }
        
        public VisibilityState VisibilityState
        {
            get
            {
                return this.GetProperty<VisibilityState>("visibilityState");
            }
        }
        
        public VisibilityState MozVisibilityState
        {
            get
            {
                return this.GetProperty<VisibilityState>("mozVisibilityState");
            }
        }
        
        public nsISupports StyleSheets
        {
            get
            {
                return this.GetProperty<nsISupports>("styleSheets");
            }
        }
        
        public string SelectedStyleSheetSet
        {
            get
            {
                return this.GetProperty<string>("selectedStyleSheetSet");
            }
            set
            {
                this.SetProperty("selectedStyleSheetSet", value);
            }
        }
        
        public string LastStyleSheetSet
        {
            get
            {
                return this.GetProperty<string>("lastStyleSheetSet");
            }
        }
        
        public string PreferredStyleSheetSet
        {
            get
            {
                return this.GetProperty<string>("preferredStyleSheetSet");
            }
        }
        
        public nsISupports StyleSheetSets
        {
            get
            {
                return this.GetProperty<nsISupports>("styleSheetSets");
            }
        }
        
        public void EnableStyleSheetsForSet(string name)
        {
            this.CallVoidMethod("enableStyleSheetsForSet", name);
        }
        
        public nsIDOMElement ElementFromPoint(float x, float y)
        {
            return this.CallMethod<nsIDOMElement>("elementFromPoint", x, y);
        }
        
        public nsISupports CaretPositionFromPoint(float x, float y)
        {
            return this.CallMethod<nsISupports>("caretPositionFromPoint", x, y);
        }
        
        public nsISupports UndoManager
        {
            get
            {
                return this.GetProperty<nsISupports>("undoManager");
            }
        }
        
        public nsIDOMElement QuerySelector(string selectors)
        {
            return this.CallMethod<nsIDOMElement>("querySelector", selectors);
        }
        
        public nsISupports QuerySelectorAll(string selectors)
        {
            return this.CallMethod<nsISupports>("querySelectorAll", selectors);
        }
        
        public nsISupports Timeline
        {
            get
            {
                return this.GetProperty<nsISupports>("timeline");
            }
        }
        
        public bool StyleSheetChangeEventsEnabled
        {
            get
            {
                return this.GetProperty<bool>("styleSheetChangeEventsEnabled");
            }
            set
            {
                this.SetProperty("styleSheetChangeEventsEnabled", value);
            }
        }
        
        public nsISupports DocShell
        {
            get
            {
                return this.GetProperty<nsISupports>("docShell");
            }
        }
        
        public string ContentLanguage
        {
            get
            {
                return this.GetProperty<string>("contentLanguage");
            }
        }
        
        public nsISupports DocumentLoadGroup
        {
            get
            {
                return this.GetProperty<nsISupports>("documentLoadGroup");
            }
        }
        
        public nsISupports GetAnonymousNodes(nsIDOMElement elt)
        {
            return this.CallMethod<nsISupports>("getAnonymousNodes", elt);
        }
        
        public nsIDOMElement GetAnonymousElementByAttribute(nsIDOMElement elt, string attrName, string attrValue)
        {
            return this.CallMethod<nsIDOMElement>("getAnonymousElementByAttribute", elt, attrName, attrValue);
        }
        
        public nsIDOMElement GetBindingParent(nsIDOMNode node)
        {
            return this.CallMethod<nsIDOMElement>("getBindingParent", node);
        }
        
        public void LoadBindingDocument(string documentURL)
        {
            this.CallVoidMethod("loadBindingDocument", documentURL);
        }
        
        public nsISupports CreateTouch()
        {
            return this.CallMethod<nsISupports>("createTouch");
        }
        
        public nsISupports CreateTouch(nsIDOMWindow view)
        {
            return this.CallMethod<nsISupports>("createTouch", view);
        }
        
        public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target)
        {
            return this.CallMethod<nsISupports>("createTouch", view, target);
        }
        
        public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier)
        {
            return this.CallMethod<nsISupports>("createTouch", view, target, identifier);
        }
        
        public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX)
        {
            return this.CallMethod<nsISupports>("createTouch", view, target, identifier, pageX);
        }
        
        public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY)
        {
            return this.CallMethod<nsISupports>("createTouch", view, target, identifier, pageX, pageY);
        }
        
        public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY, int screenX)
        {
            return this.CallMethod<nsISupports>("createTouch", view, target, identifier, pageX, pageY, screenX);
        }
        
        public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY, int screenX, int screenY)
        {
            return this.CallMethod<nsISupports>("createTouch", view, target, identifier, pageX, pageY, screenX, screenY);
        }
        
        public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX)
        {
            return this.CallMethod<nsISupports>("createTouch", view, target, identifier, pageX, pageY, screenX, screenY, clientX);
        }
        
        public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY)
        {
            return this.CallMethod<nsISupports>("createTouch", view, target, identifier, pageX, pageY, screenX, screenY, clientX, clientY);
        }
        
        public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX)
        {
            return this.CallMethod<nsISupports>("createTouch", view, target, identifier, pageX, pageY, screenX, screenY, clientX, clientY, radiusX);
        }
        
        public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY)
        {
            return this.CallMethod<nsISupports>("createTouch", view, target, identifier, pageX, pageY, screenX, screenY, clientX, clientY, radiusX, radiusY);
        }
        
        public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY, float rotationAngle)
        {
            return this.CallMethod<nsISupports>("createTouch", view, target, identifier, pageX, pageY, screenX, screenY, clientX, clientY, radiusX, radiusY, rotationAngle);
        }
        
        public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY, float rotationAngle, float force)
        {
            return this.CallMethod<nsISupports>("createTouch", view, target, identifier, pageX, pageY, screenX, screenY, clientX, clientY, radiusX, radiusY, rotationAngle, force);
        }
        
        public nsISupports CreateTouchList(nsISupports touch, nsISupports touches)
        {
            return this.CallMethod<nsISupports>("createTouchList", touch, touches);
        }
        
        public nsISupports CreateTouchList()
        {
            return this.CallMethod<nsISupports>("createTouchList");
        }
        
        public nsISupports CreateTouchList(nsISupports[] touches)
        {
            return this.CallMethod<nsISupports>("createTouchList", touches);
        }
        
        public void ObsoleteSheet(nsISupports sheetURI)
        {
            this.CallVoidMethod("obsoleteSheet", sheetURI);
        }
        
        public void ObsoleteSheet(string sheetURI)
        {
            this.CallVoidMethod("obsoleteSheet", sheetURI);
        }
        
        public bool IsSrcdocDocument
        {
            get
            {
                return this.GetProperty<bool>("isSrcdocDocument");
            }
        }
        
        public nsISupports InsertAnonymousContent(nsIDOMElement aElement)
        {
            return this.CallMethod<nsISupports>("insertAnonymousContent", aElement);
        }
        
        public void RemoveAnonymousContent(nsISupports aContent)
        {
            this.CallVoidMethod("removeAnonymousContent", aContent);
        }
        
        public bool UserHasInteracted
        {
            get
            {
                return this.GetProperty<bool>("userHasInteracted");
            }
        }
    }
}
