namespace Gecko.WebIDL
{
    using System;
    
    
    public class Window : WebIDLBase
    {
        
        public Window(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMWindow WindowAttribute
        {
            get
            {
                return this.GetProperty<nsIDOMWindow>("window");
            }
        }
        
        public nsIDOMWindow Self
        {
            get
            {
                return this.GetProperty<nsIDOMWindow>("self");
            }
        }
        
        public nsIDOMDocument Document
        {
            get
            {
                return this.GetProperty<nsIDOMDocument>("document");
            }
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
            set
            {
                this.SetProperty("name", value);
            }
        }
        
        public nsIDOMLocation Location
        {
            get
            {
                return this.GetProperty<nsIDOMLocation>("location");
            }
        }
        
        public nsIDOMHistory History
        {
            get
            {
                return this.GetProperty<nsIDOMHistory>("history");
            }
        }
        
        public nsISupports Locationbar
        {
            get
            {
                return this.GetProperty<nsISupports>("locationbar");
            }
        }
        
        public nsISupports Menubar
        {
            get
            {
                return this.GetProperty<nsISupports>("menubar");
            }
        }
        
        public nsISupports Personalbar
        {
            get
            {
                return this.GetProperty<nsISupports>("personalbar");
            }
        }
        
        public nsISupports Scrollbars
        {
            get
            {
                return this.GetProperty<nsISupports>("scrollbars");
            }
        }
        
        public nsISupports Statusbar
        {
            get
            {
                return this.GetProperty<nsISupports>("statusbar");
            }
        }
        
        public nsISupports Toolbar
        {
            get
            {
                return this.GetProperty<nsISupports>("toolbar");
            }
        }
        
        public string Status
        {
            get
            {
                return this.GetProperty<string>("status");
            }
            set
            {
                this.SetProperty("status", value);
            }
        }
        
        public bool Closed
        {
            get
            {
                return this.GetProperty<bool>("closed");
            }
        }
        
        public nsIDOMWindow Frames
        {
            get
            {
                return this.GetProperty<nsIDOMWindow>("frames");
            }
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public nsIDOMWindow Top
        {
            get
            {
                return this.GetProperty<nsIDOMWindow>("top");
            }
        }
        
        public nsIDOMWindow PrivateRoot
        {
            get
            {
                return this.GetProperty<nsIDOMWindow>("privateRoot");
            }
        }
        
        public object Opener
        {
            get
            {
                return this.GetProperty<object>("opener");
            }
            set
            {
                this.SetProperty("opener", value);
            }
        }
        
        public nsIDOMWindow Parent
        {
            get
            {
                return this.GetProperty<nsIDOMWindow>("parent");
            }
        }
        
        public nsIDOMElement FrameElement
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("frameElement");
            }
        }
        
        public nsIDOMNavigator Navigator
        {
            get
            {
                return this.GetProperty<nsIDOMNavigator>("navigator");
            }
        }
        
        public nsISupports ApplicationCache
        {
            get
            {
                return this.GetProperty<nsISupports>("applicationCache");
            }
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public void Stop()
        {
            this.CallVoidMethod("stop");
        }
        
        public void Focus()
        {
            this.CallVoidMethod("focus");
        }
        
        public void Blur()
        {
            this.CallVoidMethod("blur");
        }
        
        public nsIDOMWindow Open()
        {
            return this.CallMethod<nsIDOMWindow>("open");
        }
        
        public nsIDOMWindow Open(string url)
        {
            return this.CallMethod<nsIDOMWindow>("open", url);
        }
        
        public nsIDOMWindow Open(string url, string target)
        {
            return this.CallMethod<nsIDOMWindow>("open", url, target);
        }
        
        public nsIDOMWindow Open(string url, string target, string features)
        {
            return this.CallMethod<nsIDOMWindow>("open", url, target, features);
        }
        
        public void Alert()
        {
            this.CallVoidMethod("alert");
        }
        
        public void Alert(string message)
        {
            this.CallVoidMethod("alert", message);
        }
        
        public bool Confirm()
        {
            return this.CallMethod<bool>("confirm");
        }
        
        public bool Confirm(string message)
        {
            return this.CallMethod<bool>("confirm", message);
        }
        
        public string Prompt()
        {
            return this.CallMethod<string>("prompt");
        }
        
        public string Prompt(string message)
        {
            return this.CallMethod<string>("prompt", message);
        }
        
        public string Prompt(string message, string @default)
        {
            return this.CallMethod<string>("prompt", message, @default);
        }
        
        public void Print()
        {
            this.CallVoidMethod("print");
        }
        
        public object ShowModalDialog(string url)
        {
            return this.CallMethod<object>("showModalDialog", url);
        }
        
        public object ShowModalDialog(string url, object argument)
        {
            return this.CallMethod<object>("showModalDialog", url, argument);
        }
        
        public object ShowModalDialog(string url, object argument, string options)
        {
            return this.CallMethod<object>("showModalDialog", url, argument, options);
        }
        
        public void PostMessage(object message, string targetOrigin)
        {
            this.CallVoidMethod("postMessage", message, targetOrigin);
        }
        
        public void PostMessage(object message, string targetOrigin, Object[] transfer)
        {
            this.CallVoidMethod("postMessage", message, targetOrigin, transfer);
        }
        
        public void CaptureEvents()
        {
            this.CallVoidMethod("captureEvents");
        }
        
        public void ReleaseEvents()
        {
            this.CallVoidMethod("releaseEvents");
        }
        
        public nsISelection GetSelection()
        {
            return this.CallMethod<nsISelection>("getSelection");
        }
        
        public nsIDOMCSSStyleDeclaration GetComputedStyle(nsIDOMElement elt)
        {
            return this.CallMethod<nsIDOMCSSStyleDeclaration>("getComputedStyle", elt);
        }
        
        public nsIDOMCSSStyleDeclaration GetComputedStyle(nsIDOMElement elt, string pseudoElt)
        {
            return this.CallMethod<nsIDOMCSSStyleDeclaration>("getComputedStyle", elt, pseudoElt);
        }
        
        public nsISupports Screen
        {
            get
            {
                return this.GetProperty<nsISupports>("screen");
            }
        }
        
        public object InnerWidth
        {
            get
            {
                return this.GetProperty<object>("innerWidth");
            }
            set
            {
                this.SetProperty("innerWidth", value);
            }
        }
        
        public object InnerHeight
        {
            get
            {
                return this.GetProperty<object>("innerHeight");
            }
            set
            {
                this.SetProperty("innerHeight", value);
            }
        }
        
        public int ScrollX
        {
            get
            {
                return this.GetProperty<int>("scrollX");
            }
        }
        
        public int PageXOffset
        {
            get
            {
                return this.GetProperty<int>("pageXOffset");
            }
        }
        
        public int ScrollY
        {
            get
            {
                return this.GetProperty<int>("scrollY");
            }
        }
        
        public int PageYOffset
        {
            get
            {
                return this.GetProperty<int>("pageYOffset");
            }
        }
        
        public object ScreenX
        {
            get
            {
                return this.GetProperty<object>("screenX");
            }
            set
            {
                this.SetProperty("screenX", value);
            }
        }
        
        public object ScreenY
        {
            get
            {
                return this.GetProperty<object>("screenY");
            }
            set
            {
                this.SetProperty("screenY", value);
            }
        }
        
        public object OuterWidth
        {
            get
            {
                return this.GetProperty<object>("outerWidth");
            }
            set
            {
                this.SetProperty("outerWidth", value);
            }
        }
        
        public object OuterHeight
        {
            get
            {
                return this.GetProperty<object>("outerHeight");
            }
            set
            {
                this.SetProperty("outerHeight", value);
            }
        }
        
        public nsISupports MatchMedia(string query)
        {
            return this.CallMethod<nsISupports>("matchMedia", query);
        }
        
        public void MoveTo(int x, int y)
        {
            this.CallVoidMethod("moveTo", x, y);
        }
        
        public void MoveBy(int x, int y)
        {
            this.CallVoidMethod("moveBy", x, y);
        }
        
        public void ResizeTo(int x, int y)
        {
            this.CallVoidMethod("resizeTo", x, y);
        }
        
        public void ResizeBy(int x, int y)
        {
            this.CallVoidMethod("resizeBy", x, y);
        }
        
        public void Scroll(double x, double y)
        {
            this.CallVoidMethod("scroll", x, y);
        }
        
        public void Scroll()
        {
            this.CallVoidMethod("scroll");
        }
        
        public void Scroll(object options)
        {
            this.CallVoidMethod("scroll", options);
        }
        
        public void ScrollTo(double x, double y)
        {
            this.CallVoidMethod("scrollTo", x, y);
        }
        
        public void ScrollTo()
        {
            this.CallVoidMethod("scrollTo");
        }
        
        public void ScrollTo(object options)
        {
            this.CallVoidMethod("scrollTo", options);
        }
        
        public void ScrollBy(double x, double y)
        {
            this.CallVoidMethod("scrollBy", x, y);
        }
        
        public void ScrollBy()
        {
            this.CallVoidMethod("scrollBy");
        }
        
        public void ScrollBy(object options)
        {
            this.CallVoidMethod("scrollBy", options);
        }
        
        public void MozScrollSnap()
        {
            this.CallVoidMethod("mozScrollSnap");
        }
        
        public void CancelAnimationFrame(int handle)
        {
            this.CallVoidMethod("cancelAnimationFrame", handle);
        }
        
        public nsISupports Performance
        {
            get
            {
                return this.GetProperty<nsISupports>("performance");
            }
        }
        
        public nsISupports Caches
        {
            get
            {
                return this.GetProperty<nsISupports>("caches");
            }
        }
        
        public nsISupports Controllers
        {
            get
            {
                return this.GetProperty<nsISupports>("controllers");
            }
        }
        
        public nsIDOMElement RealFrameElement
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("realFrameElement");
            }
        }
        
        public float MozInnerScreenX
        {
            get
            {
                return this.GetProperty<float>("mozInnerScreenX");
            }
        }
        
        public float MozInnerScreenY
        {
            get
            {
                return this.GetProperty<float>("mozInnerScreenY");
            }
        }
        
        public float DevicePixelRatio
        {
            get
            {
                return this.GetProperty<float>("devicePixelRatio");
            }
        }
        
        public int ScrollMinX
        {
            get
            {
                return this.GetProperty<int>("scrollMinX");
            }
        }
        
        public int ScrollMinY
        {
            get
            {
                return this.GetProperty<int>("scrollMinY");
            }
        }
        
        public int ScrollMaxX
        {
            get
            {
                return this.GetProperty<int>("scrollMaxX");
            }
        }
        
        public int ScrollMaxY
        {
            get
            {
                return this.GetProperty<int>("scrollMaxY");
            }
        }
        
        public bool FullScreen
        {
            get
            {
                return this.GetProperty<bool>("fullScreen");
            }
            set
            {
                this.SetProperty("fullScreen", value);
            }
        }
        
        public ulong MozPaintCount
        {
            get
            {
                return this.GetProperty<ulong>("mozPaintCount");
            }
        }
        
        public nsISupports MozSelfSupport
        {
            get
            {
                return this.GetProperty<nsISupports>("MozSelfSupport");
            }
        }
        
        public object Content
        {
            get
            {
                return this.GetProperty<object>("content");
            }
        }
        
        public object @__content
        {
            get
            {
                return this.GetProperty<object>("__content");
            }
        }
        
        public nsIDOMEventTarget WindowRoot
        {
            get
            {
                return this.GetProperty<nsIDOMEventTarget>("windowRoot");
            }
        }
        
        public nsIDOMCSSStyleDeclaration GetDefaultComputedStyle(nsIDOMElement elt)
        {
            return this.CallMethod<nsIDOMCSSStyleDeclaration>("getDefaultComputedStyle", elt);
        }
        
        public nsIDOMCSSStyleDeclaration GetDefaultComputedStyle(nsIDOMElement elt, string pseudoElt)
        {
            return this.CallMethod<nsIDOMCSSStyleDeclaration>("getDefaultComputedStyle", elt, pseudoElt);
        }
        
        public void ScrollByLines(int numLines)
        {
            this.CallVoidMethod("scrollByLines", numLines);
        }
        
        public void ScrollByLines(int numLines, object options)
        {
            this.CallVoidMethod("scrollByLines", numLines, options);
        }
        
        public void ScrollByPages(int numPages)
        {
            this.CallVoidMethod("scrollByPages", numPages);
        }
        
        public void ScrollByPages(int numPages, object options)
        {
            this.CallVoidMethod("scrollByPages", numPages, options);
        }
        
        public void SizeToContent()
        {
            this.CallVoidMethod("sizeToContent");
        }
        
        public void Back()
        {
            this.CallVoidMethod("back");
        }
        
        public void Forward()
        {
            this.CallVoidMethod("forward");
        }
        
        public void Home()
        {
            this.CallVoidMethod("home");
        }
        
        public void UpdateCommands(string action)
        {
            this.CallVoidMethod("updateCommands", action);
        }
        
        public void UpdateCommands(string action, nsISelection sel)
        {
            this.CallVoidMethod("updateCommands", action, sel);
        }
        
        public void UpdateCommands(string action, nsISelection sel, short reason)
        {
            this.CallVoidMethod("updateCommands", action, sel, reason);
        }
        
        public bool Find()
        {
            return this.CallMethod<bool>("find");
        }
        
        public bool Find(string str)
        {
            return this.CallMethod<bool>("find", str);
        }
        
        public bool Find(string str, bool caseSensitive)
        {
            return this.CallMethod<bool>("find", str, caseSensitive);
        }
        
        public bool Find(string str, bool caseSensitive, bool backwards)
        {
            return this.CallMethod<bool>("find", str, caseSensitive, backwards);
        }
        
        public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround)
        {
            return this.CallMethod<bool>("find", str, caseSensitive, backwards, wrapAround);
        }
        
        public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord)
        {
            return this.CallMethod<bool>("find", str, caseSensitive, backwards, wrapAround, wholeWord);
        }
        
        public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames)
        {
            return this.CallMethod<bool>("find", str, caseSensitive, backwards, wrapAround, wholeWord, searchInFrames);
        }
        
        public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames, bool showDialog)
        {
            return this.CallMethod<bool>("find", str, caseSensitive, backwards, wrapAround, wholeWord, searchInFrames, showDialog);
        }
        
        public void Dump(string str)
        {
            this.CallVoidMethod("dump", str);
        }
        
        public void SetResizable(bool resizable)
        {
            this.CallVoidMethod("setResizable", resizable);
        }
        
        public nsIDOMWindow OpenDialog()
        {
            return this.CallMethod<nsIDOMWindow>("openDialog");
        }
        
        public nsIDOMWindow OpenDialog(string url)
        {
            return this.CallMethod<nsIDOMWindow>("openDialog", url);
        }
        
        public nsIDOMWindow OpenDialog(string url, string name)
        {
            return this.CallMethod<nsIDOMWindow>("openDialog", url, name);
        }
        
        public nsIDOMWindow OpenDialog(string url, string name, string options)
        {
            return this.CallMethod<nsIDOMWindow>("openDialog", url, name, options);
        }
        
        public nsIDOMWindow OpenDialog(string url, string name, string options, object extraArguments)
        {
            return this.CallMethod<nsIDOMWindow>("openDialog", url, name, options, extraArguments);
        }
        
        public object GetInterface(nsISupports iid)
        {
            return this.CallMethod<object>("getInterface", iid);
        }
        
        public nsISupports Console
        {
            get
            {
                return this.GetProperty<nsISupports>("console");
            }
        }
    }
}
