namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTableRowElement : WebIDLBase
    {
        
        public HTMLTableRowElement(nsISupports thisObject) : 
                base(thisObject)
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
        
        public nsISupports InsertCell(int index)
        {
            return this.CallMethod<nsISupports>("insertCell", index);
        }
        
        public void DeleteCell(int index)
        {
            this.CallVoidMethod("deleteCell", index);
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
    }
}
