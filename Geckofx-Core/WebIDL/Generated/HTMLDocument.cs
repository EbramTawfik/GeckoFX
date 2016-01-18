namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLDocument : WebIDLBase
    {
        
        public HTMLDocument(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Domain
        {
            get
            {
                return this.GetProperty<nsAString>("domain");
            }
            set
            {
                this.SetProperty("domain", value);
            }
        }
        
        public nsAString Cookie
        {
            get
            {
                return this.GetProperty<nsAString>("cookie");
            }
            set
            {
                this.SetProperty("cookie", value);
            }
        }
        
        public nsISupports Body
        {
            get
            {
                return this.GetProperty<nsISupports>("body");
            }
            set
            {
                this.SetProperty("body", value);
            }
        }
        
        public nsISupports Head
        {
            get
            {
                return this.GetProperty<nsISupports>("head");
            }
        }
        
        public nsISupports Images
        {
            get
            {
                return this.GetProperty<nsISupports>("images");
            }
        }
        
        public nsISupports Embeds
        {
            get
            {
                return this.GetProperty<nsISupports>("embeds");
            }
        }
        
        public nsISupports Plugins
        {
            get
            {
                return this.GetProperty<nsISupports>("plugins");
            }
        }
        
        public nsISupports Links
        {
            get
            {
                return this.GetProperty<nsISupports>("links");
            }
        }
        
        public nsISupports Forms
        {
            get
            {
                return this.GetProperty<nsISupports>("forms");
            }
        }
        
        public nsISupports Scripts
        {
            get
            {
                return this.GetProperty<nsISupports>("scripts");
            }
        }
        
        public nsAString DesignMode
        {
            get
            {
                return this.GetProperty<nsAString>("designMode");
            }
            set
            {
                this.SetProperty("designMode", value);
            }
        }
        
        public nsAString FgColor
        {
            get
            {
                return this.GetProperty<nsAString>("fgColor");
            }
            set
            {
                this.SetProperty("fgColor", value);
            }
        }
        
        public nsAString LinkColor
        {
            get
            {
                return this.GetProperty<nsAString>("linkColor");
            }
            set
            {
                this.SetProperty("linkColor", value);
            }
        }
        
        public nsAString VlinkColor
        {
            get
            {
                return this.GetProperty<nsAString>("vlinkColor");
            }
            set
            {
                this.SetProperty("vlinkColor", value);
            }
        }
        
        public nsAString AlinkColor
        {
            get
            {
                return this.GetProperty<nsAString>("alinkColor");
            }
            set
            {
                this.SetProperty("alinkColor", value);
            }
        }
        
        public nsAString BgColor
        {
            get
            {
                return this.GetProperty<nsAString>("bgColor");
            }
            set
            {
                this.SetProperty("bgColor", value);
            }
        }
        
        public nsISupports Anchors
        {
            get
            {
                return this.GetProperty<nsISupports>("anchors");
            }
        }
        
        public nsISupports Applets
        {
            get
            {
                return this.GetProperty<nsISupports>("applets");
            }
        }
        
        public nsISupports All
        {
            get
            {
                return this.GetProperty<nsISupports>("all");
            }
        }
        
        public nsISupports GetElementsByName(nsAString elementName)
        {
            return this.CallMethod<nsISupports>("getElementsByName", elementName);
        }
        
        public nsISupports GetItems()
        {
            return this.CallMethod<nsISupports>("getItems");
        }
        
        public nsISupports GetItems(nsAString typeNames)
        {
            return this.CallMethod<nsISupports>("getItems", typeNames);
        }
        
        public nsIDOMDocument Open()
        {
            return this.CallMethod<nsIDOMDocument>("open");
        }
        
        public nsIDOMDocument Open(nsAString type)
        {
            return this.CallMethod<nsIDOMDocument>("open", type);
        }
        
        public nsIDOMDocument Open(nsAString type, nsAString replace)
        {
            return this.CallMethod<nsIDOMDocument>("open", type, replace);
        }
        
        public nsIDOMWindow Open(nsAString url, nsAString name, nsAString features)
        {
            return this.CallMethod<nsIDOMWindow>("open", url, name, features);
        }
        
        public nsIDOMWindow Open(nsAString url, nsAString name, nsAString features, bool replace)
        {
            return this.CallMethod<nsIDOMWindow>("open", url, name, features, replace);
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public void Write(nsAString text)
        {
            this.CallVoidMethod("write", text);
        }
        
        public void Writeln(nsAString text)
        {
            this.CallVoidMethod("writeln", text);
        }
        
        public bool ExecCommand(nsAString commandId)
        {
            return this.CallMethod<bool>("execCommand", commandId);
        }
        
        public bool ExecCommand(nsAString commandId, bool showUI)
        {
            return this.CallMethod<bool>("execCommand", commandId, showUI);
        }
        
        public bool ExecCommand(nsAString commandId, bool showUI, nsAString value)
        {
            return this.CallMethod<bool>("execCommand", commandId, showUI, value);
        }
        
        public bool QueryCommandEnabled(nsAString commandId)
        {
            return this.CallMethod<bool>("queryCommandEnabled", commandId);
        }
        
        public bool QueryCommandIndeterm(nsAString commandId)
        {
            return this.CallMethod<bool>("queryCommandIndeterm", commandId);
        }
        
        public bool QueryCommandState(nsAString commandId)
        {
            return this.CallMethod<bool>("queryCommandState", commandId);
        }
        
        public bool QueryCommandSupported(nsAString commandId)
        {
            return this.CallMethod<bool>("queryCommandSupported", commandId);
        }
        
        public nsAString QueryCommandValue(nsAString commandId)
        {
            return this.CallMethod<nsAString>("queryCommandValue", commandId);
        }
        
        public void Clear()
        {
            this.CallVoidMethod("clear");
        }
        
        public nsISelection GetSelection()
        {
            return this.CallMethod<nsISelection>("getSelection");
        }
        
        public void CaptureEvents()
        {
            this.CallVoidMethod("captureEvents");
        }
        
        public void ReleaseEvents()
        {
            this.CallVoidMethod("releaseEvents");
        }
        
        public int BlockedTrackingNodeCount
        {
            get
            {
                return this.GetProperty<int>("blockedTrackingNodeCount");
            }
        }
        
        public nsISupports BlockedTrackingNodes
        {
            get
            {
                return this.GetProperty<nsISupports>("blockedTrackingNodes");
            }
        }
    }
}
