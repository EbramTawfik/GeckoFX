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
        
        public string Ch
        {
            get
            {
                return this.GetProperty<string>("ch");
            }
            set
            {
                this.SetProperty("ch", value);
            }
        }
        
        public string ChOff
        {
            get
            {
                return this.GetProperty<string>("chOff");
            }
            set
            {
                this.SetProperty("chOff", value);
            }
        }
        
        public string VAlign
        {
            get
            {
                return this.GetProperty<string>("vAlign");
            }
            set
            {
                this.SetProperty("vAlign", value);
            }
        }
    }
}
