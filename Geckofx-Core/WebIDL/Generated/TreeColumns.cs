namespace Gecko.WebIDL
{
    using System;
    
    
    public class TreeColumns : WebIDLBase
    {
        
        public TreeColumns(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Tree
        {
            get
            {
                return this.GetProperty<nsISupports>("tree");
            }
        }
        
        public uint Count
        {
            get
            {
                return this.GetProperty<uint>("count");
            }
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public nsISupports GetFirstColumn()
        {
            return this.CallMethod<nsISupports>("getFirstColumn");
        }
        
        public nsISupports GetLastColumn()
        {
            return this.CallMethod<nsISupports>("getLastColumn");
        }
        
        public nsISupports GetPrimaryColumn()
        {
            return this.CallMethod<nsISupports>("getPrimaryColumn");
        }
        
        public nsISupports GetSortedColumn()
        {
            return this.CallMethod<nsISupports>("getSortedColumn");
        }
        
        public nsISupports GetKeyColumn()
        {
            return this.CallMethod<nsISupports>("getKeyColumn");
        }
        
        public nsISupports GetColumnFor(nsIDOMElement element)
        {
            return this.CallMethod<nsISupports>("getColumnFor", element);
        }
        
        public void InvalidateColumns()
        {
            this.CallVoidMethod("invalidateColumns");
        }
        
        public void RestoreNaturalOrder()
        {
            this.CallVoidMethod("restoreNaturalOrder");
        }
    }
}
