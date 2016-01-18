namespace Gecko.WebIDL
{
    using System;
    
    
    public class SelectionStateChangedEvent : WebIDLBase
    {
        
        public SelectionStateChangedEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Visible
        {
            get
            {
                return this.GetProperty<bool>("visible");
            }
        }
        
        public string SelectedText
        {
            get
            {
                return this.GetProperty<string>("selectedText");
            }
        }
        
        public nsISupports BoundingClientRect
        {
            get
            {
                return this.GetProperty<nsISupports>("boundingClientRect");
            }
        }
        
        public SelectionState[] States
        {
            get
            {
                return this.GetProperty<SelectionState[]>("states");
            }
        }
    }
}
