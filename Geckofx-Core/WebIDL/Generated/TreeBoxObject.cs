namespace Gecko.WebIDL
{
    using System;
    
    
    public class TreeBoxObject : WebIDLBase
    {
        
        public TreeBoxObject(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Columns
        {
            get
            {
                return this.GetProperty<nsISupports>("columns");
            }
        }
        
        public nsISupports View
        {
            get
            {
                return this.GetProperty<nsISupports>("view");
            }
            set
            {
                this.SetProperty("view", value);
            }
        }
        
        public bool Focused
        {
            get
            {
                return this.GetProperty<bool>("focused");
            }
            set
            {
                this.SetProperty("focused", value);
            }
        }
        
        public nsIDOMElement TreeBody
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("treeBody");
            }
        }
        
        public int RowHeight
        {
            get
            {
                return this.GetProperty<int>("rowHeight");
            }
        }
        
        public int RowWidth
        {
            get
            {
                return this.GetProperty<int>("rowWidth");
            }
        }
        
        public int HorizontalPosition
        {
            get
            {
                return this.GetProperty<int>("horizontalPosition");
            }
        }
        
        public nsISupports SelectionRegion
        {
            get
            {
                return this.GetProperty<nsISupports>("selectionRegion");
            }
        }
        
        public int GetFirstVisibleRow()
        {
            return this.CallMethod<int>("getFirstVisibleRow");
        }
        
        public int GetLastVisibleRow()
        {
            return this.CallMethod<int>("getLastVisibleRow");
        }
        
        public int GetPageLength()
        {
            return this.CallMethod<int>("getPageLength");
        }
        
        public void EnsureRowIsVisible(int index)
        {
            this.CallVoidMethod("ensureRowIsVisible", index);
        }
        
        public void EnsureCellIsVisible(int row, nsISupports col)
        {
            this.CallVoidMethod("ensureCellIsVisible", row, col);
        }
        
        public void ScrollToRow(int index)
        {
            this.CallVoidMethod("scrollToRow", index);
        }
        
        public void ScrollByLines(int numLines)
        {
            this.CallVoidMethod("scrollByLines", numLines);
        }
        
        public void ScrollByPages(int numPages)
        {
            this.CallVoidMethod("scrollByPages", numPages);
        }
        
        public void ScrollToCell(int row, nsISupports col)
        {
            this.CallVoidMethod("scrollToCell", row, col);
        }
        
        public void ScrollToColumn(nsISupports col)
        {
            this.CallVoidMethod("scrollToColumn", col);
        }
        
        public void ScrollToHorizontalPosition(int horizontalPosition)
        {
            this.CallVoidMethod("scrollToHorizontalPosition", horizontalPosition);
        }
        
        public void Invalidate()
        {
            this.CallVoidMethod("invalidate");
        }
        
        public void InvalidateColumn(nsISupports col)
        {
            this.CallVoidMethod("invalidateColumn", col);
        }
        
        public void InvalidateRow(int index)
        {
            this.CallVoidMethod("invalidateRow", index);
        }
        
        public void InvalidateCell(int row, nsISupports col)
        {
            this.CallVoidMethod("invalidateCell", row, col);
        }
        
        public void InvalidateRange(int startIndex, int endIndex)
        {
            this.CallVoidMethod("invalidateRange", startIndex, endIndex);
        }
        
        public void InvalidateColumnRange(int startIndex, int endIndex, nsISupports col)
        {
            this.CallVoidMethod("invalidateColumnRange", startIndex, endIndex, col);
        }
        
        public int GetRowAt(int x, int y)
        {
            return this.CallMethod<int>("getRowAt", x, y);
        }
        
        public object GetCellAt(int x, int y)
        {
            return this.CallMethod<object>("getCellAt", x, y);
        }
        
        public void GetCellAt(int x, int y, object row, object column, object childElt)
        {
            this.CallVoidMethod("getCellAt", x, y, row, column, childElt);
        }
        
        public nsISupports GetCoordsForCellItem(int row, nsISupports col, string element)
        {
            return this.CallMethod<nsISupports>("getCoordsForCellItem", row, col, element);
        }
        
        public void GetCoordsForCellItem(int row, nsISupports col, string element, object x, object y, object width, object height)
        {
            this.CallVoidMethod("getCoordsForCellItem", row, col, element, x, y, width, height);
        }
        
        public bool IsCellCropped(int row, nsISupports col)
        {
            return this.CallMethod<bool>("isCellCropped", row, col);
        }
        
        public void RowCountChanged(int index, int count)
        {
            this.CallVoidMethod("rowCountChanged", index, count);
        }
        
        public void BeginUpdateBatch()
        {
            this.CallVoidMethod("beginUpdateBatch");
        }
        
        public void EndUpdateBatch()
        {
            this.CallVoidMethod("endUpdateBatch");
        }
        
        public void ClearStyleAndImageCaches()
        {
            this.CallVoidMethod("clearStyleAndImageCaches");
        }
    }
}
