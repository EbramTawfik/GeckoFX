namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLDocument : WebIDLBase
    {
        
        public HTMLDocument(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Domain
        {
            get
            {
                return this.GetProperty<string>("domain");
            }
            set
            {
                this.SetProperty("domain", value);
            }
        }
        
        public string Cookie
        {
            get
            {
                return this.GetProperty<string>("cookie");
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
        
        public string DesignMode
        {
            get
            {
                return this.GetProperty<string>("designMode");
            }
            set
            {
                this.SetProperty("designMode", value);
            }
        }
        
        public string FgColor
        {
            get
            {
                return this.GetProperty<string>("fgColor");
            }
            set
            {
                this.SetProperty("fgColor", value);
            }
        }
        
        public string LinkColor
        {
            get
            {
                return this.GetProperty<string>("linkColor");
            }
            set
            {
                this.SetProperty("linkColor", value);
            }
        }
        
        public string VlinkColor
        {
            get
            {
                return this.GetProperty<string>("vlinkColor");
            }
            set
            {
                this.SetProperty("vlinkColor", value);
            }
        }
        
        public string AlinkColor
        {
            get
            {
                return this.GetProperty<string>("alinkColor");
            }
            set
            {
                this.SetProperty("alinkColor", value);
            }
        }
        
        public string BgColor
        {
            get
            {
                return this.GetProperty<string>("bgColor");
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
        
        public nsISupports GetElementsByName(string elementName)
        {
            return this.CallMethod<nsISupports>("getElementsByName", elementName);
        }
        
        public nsISupports GetItems()
        {
            return this.CallMethod<nsISupports>("getItems");
        }
        
        public nsISupports GetItems(string typeNames)
        {
            return this.CallMethod<nsISupports>("getItems", typeNames);
        }
        
        public nsIDOMDocument Open()
        {
            return this.CallMethod<nsIDOMDocument>("open");
        }
        
        public nsIDOMDocument Open(string type)
        {
            return this.CallMethod<nsIDOMDocument>("open", type);
        }
        
        public nsIDOMDocument Open(string type, string replace)
        {
            return this.CallMethod<nsIDOMDocument>("open", type, replace);
        }
        
        public nsIDOMWindow Open(string url, string name, string features)
        {
            return this.CallMethod<nsIDOMWindow>("open", url, name, features);
        }
        
        public nsIDOMWindow Open(string url, string name, string features, bool replace)
        {
            return this.CallMethod<nsIDOMWindow>("open", url, name, features, replace);
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public void Write(string text)
        {
            this.CallVoidMethod("write", text);
        }
        
        public void Writeln(string text)
        {
            this.CallVoidMethod("writeln", text);
        }
        
        public bool ExecCommand(string commandId)
        {
            return this.CallMethod<bool>("execCommand", commandId);
        }
        
        public bool ExecCommand(string commandId, bool showUI)
        {
            return this.CallMethod<bool>("execCommand", commandId, showUI);
        }
        
        public bool ExecCommand(string commandId, bool showUI, string value)
        {
            return this.CallMethod<bool>("execCommand", commandId, showUI, value);
        }
        
        public bool QueryCommandEnabled(string commandId)
        {
            return this.CallMethod<bool>("queryCommandEnabled", commandId);
        }
        
        public bool QueryCommandIndeterm(string commandId)
        {
            return this.CallMethod<bool>("queryCommandIndeterm", commandId);
        }
        
        public bool QueryCommandState(string commandId)
        {
            return this.CallMethod<bool>("queryCommandState", commandId);
        }
        
        public bool QueryCommandSupported(string commandId)
        {
            return this.CallMethod<bool>("queryCommandSupported", commandId);
        }
        
        public string QueryCommandValue(string commandId)
        {
            return this.CallMethod<string>("queryCommandValue", commandId);
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
