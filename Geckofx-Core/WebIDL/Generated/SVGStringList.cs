namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGStringList : WebIDLBase
    {
        
        public SVGStringList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public uint NumberOfItems
        {
            get
            {
                return this.GetProperty<uint>("numberOfItems");
            }
        }
        
        public void Clear()
        {
            this.CallVoidMethod("clear");
        }
        
        public string Initialize(string newItem)
        {
            return this.CallMethod<string>("initialize", newItem);
        }
        
        public string GetItem(uint index)
        {
            return this.CallMethod<string>("getItem", index);
        }
        
        public string InsertItemBefore(string newItem, uint index)
        {
            return this.CallMethod<string>("insertItemBefore", newItem, index);
        }
        
        public string ReplaceItem(string newItem, uint index)
        {
            return this.CallMethod<string>("replaceItem", newItem, index);
        }
        
        public string RemoveItem(uint index)
        {
            return this.CallMethod<string>("removeItem", index);
        }
        
        public string AppendItem(string newItem)
        {
            return this.CallMethod<string>("appendItem", newItem);
        }
    }
}
