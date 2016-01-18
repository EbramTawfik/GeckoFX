namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTableElement : WebIDLBase
    {
        
        public HTMLTableElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Caption
        {
            get
            {
                return this.GetProperty<nsISupports>("caption");
            }
            set
            {
                this.SetProperty("caption", value);
            }
        }
        
        public nsISupports THead
        {
            get
            {
                return this.GetProperty<nsISupports>("tHead");
            }
            set
            {
                this.SetProperty("tHead", value);
            }
        }
        
        public nsISupports TFoot
        {
            get
            {
                return this.GetProperty<nsISupports>("tFoot");
            }
            set
            {
                this.SetProperty("tFoot", value);
            }
        }
        
        public nsISupports TBodies
        {
            get
            {
                return this.GetProperty<nsISupports>("tBodies");
            }
        }
        
        public nsISupports Rows
        {
            get
            {
                return this.GetProperty<nsISupports>("rows");
            }
        }
        
        public nsISupports CreateCaption()
        {
            return this.CallMethod<nsISupports>("createCaption");
        }
        
        public void DeleteCaption()
        {
            this.CallVoidMethod("deleteCaption");
        }
        
        public nsISupports CreateTHead()
        {
            return this.CallMethod<nsISupports>("createTHead");
        }
        
        public void DeleteTHead()
        {
            this.CallVoidMethod("deleteTHead");
        }
        
        public nsISupports CreateTFoot()
        {
            return this.CallMethod<nsISupports>("createTFoot");
        }
        
        public void DeleteTFoot()
        {
            this.CallVoidMethod("deleteTFoot");
        }
        
        public nsISupports CreateTBody()
        {
            return this.CallMethod<nsISupports>("createTBody");
        }
        
        public nsISupports InsertRow()
        {
            return this.CallMethod<nsISupports>("insertRow");
        }
        
        public nsISupports InsertRow(int index)
        {
            return this.CallMethod<nsISupports>("insertRow", index);
        }
        
        public void DeleteRow(int index)
        {
            this.CallVoidMethod("deleteRow", index);
        }
        
        public nsAString Align
        {
            get
            {
                return this.GetProperty<nsAString>("align");
            }
            set
            {
                this.SetProperty("align", value);
            }
        }
        
        public nsAString Border
        {
            get
            {
                return this.GetProperty<nsAString>("border");
            }
            set
            {
                this.SetProperty("border", value);
            }
        }
        
        public nsAString Frame
        {
            get
            {
                return this.GetProperty<nsAString>("frame");
            }
            set
            {
                this.SetProperty("frame", value);
            }
        }
        
        public nsAString Rules
        {
            get
            {
                return this.GetProperty<nsAString>("rules");
            }
            set
            {
                this.SetProperty("rules", value);
            }
        }
        
        public nsAString Summary
        {
            get
            {
                return this.GetProperty<nsAString>("summary");
            }
            set
            {
                this.SetProperty("summary", value);
            }
        }
        
        public nsAString Width
        {
            get
            {
                return this.GetProperty<nsAString>("width");
            }
            set
            {
                this.SetProperty("width", value);
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
        
        public nsAString CellPadding
        {
            get
            {
                return this.GetProperty<nsAString>("cellPadding");
            }
            set
            {
                this.SetProperty("cellPadding", value);
            }
        }
        
        public nsAString CellSpacing
        {
            get
            {
                return this.GetProperty<nsAString>("cellSpacing");
            }
            set
            {
                this.SetProperty("cellSpacing", value);
            }
        }
    }
}
