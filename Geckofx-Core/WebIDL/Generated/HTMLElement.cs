namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLElement : WebIDLBase
    {
        
        public HTMLElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public nsAString Lang
        {
            get
            {
                return this.GetProperty<nsAString>("lang");
            }
            set
            {
                this.SetProperty("lang", value);
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
        
        public nsISupports Dataset
        {
            get
            {
                return this.GetProperty<nsISupports>("dataset");
            }
        }
        
        public nsAString InnerText
        {
            get
            {
                return this.GetProperty<nsAString>("innerText");
            }
            set
            {
                this.SetProperty("innerText", value);
            }
        }
        
        public bool ItemScope
        {
            get
            {
                return this.GetProperty<bool>("itemScope");
            }
            set
            {
                this.SetProperty("itemScope", value);
            }
        }
        
        public nsISupports ItemType
        {
            get
            {
                return this.GetProperty<nsISupports>("itemType");
            }
        }
        
        public nsAString ItemId
        {
            get
            {
                return this.GetProperty<nsAString>("itemId");
            }
            set
            {
                this.SetProperty("itemId", value);
            }
        }
        
        public nsISupports ItemRef
        {
            get
            {
                return this.GetProperty<nsISupports>("itemRef");
            }
        }
        
        public nsISupports ItemProp
        {
            get
            {
                return this.GetProperty<nsISupports>("itemProp");
            }
        }
        
        public nsISupports Properties
        {
            get
            {
                return this.GetProperty<nsISupports>("properties");
            }
        }
        
        public object ItemValue
        {
            get
            {
                return this.GetProperty<object>("itemValue");
            }
            set
            {
                this.SetProperty("itemValue", value);
            }
        }
        
        public bool Hidden
        {
            get
            {
                return this.GetProperty<bool>("hidden");
            }
            set
            {
                this.SetProperty("hidden", value);
            }
        }
        
        public int TabIndex
        {
            get
            {
                return this.GetProperty<int>("tabIndex");
            }
            set
            {
                this.SetProperty("tabIndex", value);
            }
        }
        
        public nsAString AccessKey
        {
            get
            {
                return this.GetProperty<nsAString>("accessKey");
            }
            set
            {
                this.SetProperty("accessKey", value);
            }
        }
        
        public nsAString AccessKeyLabel
        {
            get
            {
                return this.GetProperty<nsAString>("accessKeyLabel");
            }
        }
        
        public bool Draggable
        {
            get
            {
                return this.GetProperty<bool>("draggable");
            }
            set
            {
                this.SetProperty("draggable", value);
            }
        }
        
        public nsAString ContentEditable
        {
            get
            {
                return this.GetProperty<nsAString>("contentEditable");
            }
            set
            {
                this.SetProperty("contentEditable", value);
            }
        }
        
        public bool IsContentEditable
        {
            get
            {
                return this.GetProperty<bool>("isContentEditable");
            }
        }
        
        public nsISupports ContextMenu
        {
            get
            {
                return this.GetProperty<nsISupports>("contextMenu");
            }
        }
        
        public bool Spellcheck
        {
            get
            {
                return this.GetProperty<bool>("spellcheck");
            }
            set
            {
                this.SetProperty("spellcheck", value);
            }
        }
        
        public nsIDOMCSSStyleDeclaration Style
        {
            get
            {
                return this.GetProperty<nsIDOMCSSStyleDeclaration>("style");
            }
        }
        
        public void Click()
        {
            this.CallVoidMethod("click");
        }
        
        public void Focus()
        {
            this.CallVoidMethod("focus");
        }
        
        public void Blur()
        {
            this.CallVoidMethod("blur");
        }
        
        public nsIDOMElement OffsetParent
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("offsetParent");
            }
        }
        
        public int OffsetTop
        {
            get
            {
                return this.GetProperty<int>("offsetTop");
            }
        }
        
        public int OffsetLeft
        {
            get
            {
                return this.GetProperty<int>("offsetLeft");
            }
        }
        
        public int OffsetWidth
        {
            get
            {
                return this.GetProperty<int>("offsetWidth");
            }
        }
        
        public int OffsetHeight
        {
            get
            {
                return this.GetProperty<int>("offsetHeight");
            }
        }
        
        public bool Scrollgrab
        {
            get
            {
                return this.GetProperty<bool>("scrollgrab");
            }
            set
            {
                this.SetProperty("scrollgrab", value);
            }
        }
    }
}
