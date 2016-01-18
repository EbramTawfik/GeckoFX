namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTableSectionElement : WebIDLBase
    {
        
        public HTMLTableSectionElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Rows
        {
            get
            {
                return this.GetProperty<nsISupports>("rows");
            }
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
        
        public nsAString Ch
        {
            get
            {
                return this.GetProperty<nsAString>("ch");
            }
            set
            {
                this.SetProperty("ch", value);
            }
        }
        
        public nsAString ChOff
        {
            get
            {
                return this.GetProperty<nsAString>("chOff");
            }
            set
            {
                this.SetProperty("chOff", value);
            }
        }
        
        public nsAString VAlign
        {
            get
            {
                return this.GetProperty<nsAString>("vAlign");
            }
            set
            {
                this.SetProperty("vAlign", value);
            }
        }
    }
}
