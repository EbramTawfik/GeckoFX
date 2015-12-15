namespace Gecko.WebIDL
{
    using System;
    
    
    public class ChromeWindow : WebIDLBase
    {
        
        public ChromeWindow(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public ushort WindowState
        {
            get
            {
                return this.GetProperty<ushort>("windowState");
            }
        }
        
        public nsIBrowserDOMWindow BrowserDOMWindow
        {
            get
            {
                return this.GetProperty<nsIBrowserDOMWindow>("browserDOMWindow");
            }
            set
            {
                this.SetProperty("browserDOMWindow", value);
            }
        }
        
        public nsISupports MessageManager
        {
            get
            {
                return this.GetProperty<nsISupports>("messageManager");
            }
        }
        
        public void GetAttention()
        {
            this.CallVoidMethod("getAttention");
        }
        
        public void GetAttentionWithCycleCount(int aCycleCount)
        {
            this.CallVoidMethod("getAttentionWithCycleCount", aCycleCount);
        }
        
        public void SetCursor(nsAString cursor)
        {
            this.CallVoidMethod("setCursor", cursor);
        }
        
        public void Maximize()
        {
            this.CallVoidMethod("maximize");
        }
        
        public void Minimize()
        {
            this.CallVoidMethod("minimize");
        }
        
        public void Restore()
        {
            this.CallVoidMethod("restore");
        }
        
        public void NotifyDefaultButtonLoaded(nsIDOMElement defaultButton)
        {
            this.CallVoidMethod("notifyDefaultButtonLoaded", defaultButton);
        }
        
        public nsISupports GetGroupMessageManager(nsAString aGroup)
        {
            return this.CallMethod<nsISupports>("getGroupMessageManager", aGroup);
        }
        
        public void BeginWindowMove(nsIDOMEvent mouseDownEvent, nsIDOMElement panel)
        {
            this.CallVoidMethod("beginWindowMove", mouseDownEvent, panel);
        }
    }
}
