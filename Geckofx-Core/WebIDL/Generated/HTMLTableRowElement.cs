namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTableRowElement : WebIDLBase
    {
        
        public HTMLTableRowElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int RowIndex
        {
            get
            {
                return this.GetProperty<int>("rowIndex");
            }
        }
        
        public int SectionRowIndex
        {
            get
            {
                return this.GetProperty<int>("sectionRowIndex");
            }
        }
        
        public nsISupports Cells
        {
            get
            {
                return this.GetProperty<nsISupports>("cells");
            }
        }
        
        public nsISupports InsertCell()
        {
            return this.CallMethod<nsISupports>("insertCell");
        }
        
        public nsISupports InsertCell(int index)
        {
            return this.CallMethod<nsISupports>("insertCell", index);
        }
        
        public void DeleteCell(int index)
        {
            this.CallVoidMethod("deleteCell", index);
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
    }
}
