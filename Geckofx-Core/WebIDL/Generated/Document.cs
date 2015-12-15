namespace Gecko.WebIDL
{
    using System;
    
    
    public class Document : WebIDLBase
    {
        
        public Document(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Implementation
        {
            get
            {
                return this.GetProperty<nsISupports>("implementation");
            }
        }
        
        public nsAString URL
        {
            get
            {
                return this.GetProperty<nsAString>("URL");
            }
        }
        
        public nsAString DocumentURI
        {
            get
            {
                return this.GetProperty<nsAString>("documentURI");
            }
        }
        
        public nsAString CompatMode
        {
            get
            {
                return this.GetProperty<nsAString>("compatMode");
            }
        }
        
        public nsAString CharacterSet
        {
            get
            {
                return this.GetProperty<nsAString>("characterSet");
            }
        }
        
        public nsAString Charset
        {
            get
            {
                return this.GetProperty<nsAString>("charset");
            }
        }
        
        public nsAString InputEncoding
        {
            get
            {
                return this.GetProperty<nsAString>("inputEncoding");
            }
        }
        
        public nsAString ContentType
        {
            get
            {
                return this.GetProperty<nsAString>("contentType");
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
        
        public nsIDOMElement GetElementById(nsAString elementId)
        {
            return this.CallMethod<nsIDOMElement>("getElementById", elementId);
        }
        
        public nsIDOMElement CreateElement(nsAString localName)
        {
            return this.CallMethod<nsIDOMElement>("createElement", localName);
        }
        
        public nsIDOMElement CreateElementNS(nsAString @namespace, nsAString qualifiedName)
        {
            return this.CallMethod<nsIDOMElement>("createElementNS", @namespace, qualifiedName);
        }
        
        public nsISupports CreateDocumentFragment()
        {
            return this.CallMethod<nsISupports>("createDocumentFragment");
        }
        
        public nsIDOMText CreateTextNode(nsAString data)
        {
            return this.CallMethod<nsIDOMText>("createTextNode", data);
        }
        
        public nsISupports CreateComment(nsAString data)
        {
            return this.CallMethod<nsISupports>("createComment", data);
        }
        
        public nsISupports CreateProcessingInstruction(nsAString target, nsAString data)
        {
            return this.CallMethod<nsISupports>("createProcessingInstruction", target, data);
        }
        
        public nsIDOMNode ImportNode(nsIDOMNode node, bool deep)
        {
            return this.CallMethod<nsIDOMNode>("importNode", node, deep);
        }
        
        public nsIDOMNode AdoptNode(nsIDOMNode node)
        {
            return this.CallMethod<nsIDOMNode>("adoptNode", node);
        }
        
        public nsIDOMEvent CreateEvent(nsAString @interface)
        {
            return this.CallMethod<nsIDOMEvent>("createEvent", @interface);
        }
        
        public nsISupports CreateRange()
        {
            return this.CallMethod<nsISupports>("createRange");
        }
        
        public nsISupports CreateNodeIterator(nsIDOMNode root, uint whatToShow, nsISupports filter)
        {
            return this.CallMethod<nsISupports>("createNodeIterator", root, whatToShow, filter);
        }
        
        public nsISupports CreateTreeWalker(nsIDOMNode root, uint whatToShow, nsISupports filter)
        {
            return this.CallMethod<nsISupports>("createTreeWalker", root, whatToShow, filter);
        }
        
        public nsISupports CreateCDATASection(nsAString data)
        {
            return this.CallMethod<nsISupports>("createCDATASection", data);
        }
        
        public nsISupports CreateAttribute(nsAString name)
        {
            return this.CallMethod<nsISupports>("createAttribute", name);
        }
        
        public nsISupports CreateAttributeNS(nsAString @namespace, nsAString name)
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
        
        public nsAString Referrer
        {
            get
            {
                return this.GetProperty<nsAString>("referrer");
            }
        }
        
        public nsAString LastModified
        {
            get
            {
                return this.GetProperty<nsAString>("lastModified");
            }
        }
        
        public nsAString ReadyState
        {
            get
            {
                return this.GetProperty<nsAString>("readyState");
            }
        }
        
        public nsAString Title
        {
            get
            {
                return this.GetProperty<nsAString>("title");
            }
            set
            {
                this.SetProperty("title", value);
            }
        }
        
        public nsAString Dir
        {
            get
            {
                return this.GetProperty<nsAString>("dir");
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
        
        public void MozSetImageElement(nsAString aImageElementId, nsIDOMElement aImageElement)
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
        
        public object RegisterElement(nsAString name, object options)
        {
            return this.CallMethod<object>("registerElement", name, options);
        }
        
        public nsIDOMElement CreateElement(nsAString localName, nsAString typeExtension)
        {
            return this.CallMethod<nsIDOMElement>("createElement", localName, typeExtension);
        }
        
        public nsIDOMElement CreateElementNS(nsAString @namespace, nsAString qualifiedName, nsAString typeExtension)
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
        
        public nsAString SelectedStyleSheetSet
        {
            get
            {
                return this.GetProperty<nsAString>("selectedStyleSheetSet");
            }
            set
            {
                this.SetProperty("selectedStyleSheetSet", value);
            }
        }
        
        public nsAString LastStyleSheetSet
        {
            get
            {
                return this.GetProperty<nsAString>("lastStyleSheetSet");
            }
        }
        
        public nsAString PreferredStyleSheetSet
        {
            get
            {
                return this.GetProperty<nsAString>("preferredStyleSheetSet");
            }
        }
        
        public nsISupports StyleSheetSets
        {
            get
            {
                return this.GetProperty<nsISupports>("styleSheetSets");
            }
        }
        
        public void EnableStyleSheetsForSet(nsAString name)
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
        
        public nsIDOMElement QuerySelector(nsAString selectors)
        {
            return this.CallMethod<nsIDOMElement>("querySelector", selectors);
        }
        
        public nsISupports QuerySelectorAll(nsAString selectors)
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
        
        public nsAString ContentLanguage
        {
            get
            {
                return this.GetProperty<nsAString>("contentLanguage");
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
        
        public nsIDOMElement GetAnonymousElementByAttribute(nsIDOMElement elt, nsAString attrName, nsAString attrValue)
        {
            return this.CallMethod<nsIDOMElement>("getAnonymousElementByAttribute", elt, attrName, attrValue);
        }
        
        public nsIDOMElement GetBindingParent(nsIDOMNode node)
        {
            return this.CallMethod<nsIDOMElement>("getBindingParent", node);
        }
        
        public void LoadBindingDocument(nsAString documentURL)
        {
            this.CallVoidMethod("loadBindingDocument", documentURL);
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
        
        public void ObsoleteSheet(nsAString sheetURI)
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
