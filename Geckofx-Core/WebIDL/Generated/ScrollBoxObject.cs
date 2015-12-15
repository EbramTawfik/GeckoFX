namespace Gecko.WebIDL
{
    using System;
    
    
    public class ScrollBoxObject : WebIDLBase
    {
        
        public ScrollBoxObject(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public int PositionX
        {
            get
            {
                return this.GetProperty<int>("positionX");
            }
        }
        
        public int PositionY
        {
            get
            {
                return this.GetProperty<int>("positionY");
            }
        }
        
        public int ScrolledWidth
        {
            get
            {
                return this.GetProperty<int>("scrolledWidth");
            }
        }
        
        public int ScrolledHeight
        {
            get
            {
                return this.GetProperty<int>("scrolledHeight");
            }
        }
        
        public void ScrollTo(int x, int y)
        {
            this.CallVoidMethod("scrollTo", x, y);
        }
        
        public void ScrollBy(int dx, int dy)
        {
            this.CallVoidMethod("scrollBy", dx, dy);
        }
        
        public void ScrollByLine(int dlines)
        {
            this.CallVoidMethod("scrollByLine", dlines);
        }
        
        public void ScrollByIndex(int dindexes)
        {
            this.CallVoidMethod("scrollByIndex", dindexes);
        }
        
        public void ScrollToLine(int line)
        {
            this.CallVoidMethod("scrollToLine", line);
        }
        
        public void ScrollToElement(nsIDOMElement child)
        {
            this.CallVoidMethod("scrollToElement", child);
        }
        
        public void ScrollToIndex(int index)
        {
            this.CallVoidMethod("scrollToIndex", index);
        }
        
        public void GetPosition(object x, object y)
        {
            this.CallVoidMethod("getPosition", x, y);
        }
        
        public void GetScrolledSize(object width, object height)
        {
            this.CallVoidMethod("getScrolledSize", width, height);
        }
        
        public void EnsureElementIsVisible(nsIDOMElement child)
        {
            this.CallVoidMethod("ensureElementIsVisible", child);
        }
        
        public void EnsureIndexIsVisible(int index)
        {
            this.CallVoidMethod("ensureIndexIsVisible", index);
        }
        
        public void EnsureLineIsVisible(int line)
        {
            this.CallVoidMethod("ensureLineIsVisible", line);
        }
    }
}
