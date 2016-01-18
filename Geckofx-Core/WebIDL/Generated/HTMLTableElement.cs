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
        
        public string Align
        {
            get
            {
                return this.GetProperty<string>("align");
            }
            set
            {
                this.SetProperty("align", value);
            }
        }
        
        public string Border
        {
            get
            {
                return this.GetProperty<string>("border");
            }
            set
            {
                this.SetProperty("border", value);
            }
        }
        
        public string Frame
        {
            get
            {
                return this.GetProperty<string>("frame");
            }
            set
            {
                this.SetProperty("frame", value);
            }
        }
        
        public string Rules
        {
            get
            {
                return this.GetProperty<string>("rules");
            }
            set
            {
                this.SetProperty("rules", value);
            }
        }
        
        public string Summary
        {
            get
            {
                return this.GetProperty<string>("summary");
            }
            set
            {
                this.SetProperty("summary", value);
            }
        }
        
        public string Width
        {
            get
            {
                return this.GetProperty<string>("width");
            }
            set
            {
                this.SetProperty("width", value);
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
        
        public string CellPadding
        {
            get
            {
                return this.GetProperty<string>("cellPadding");
            }
            set
            {
                this.SetProperty("cellPadding", value);
            }
        }
        
        public string CellSpacing
        {
            get
            {
                return this.GetProperty<string>("cellSpacing");
            }
            set
            {
                this.SetProperty("cellSpacing", value);
            }
        }
    }
}
