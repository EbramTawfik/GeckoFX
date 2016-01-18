namespace Gecko.WebIDL
{
    using System;
    
    
    public class DataTransfer : WebIDLBase
    {
        
        public DataTransfer(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string DropEffect
        {
            get
            {
                return this.GetProperty<string>("dropEffect");
            }
            set
            {
                this.SetProperty("dropEffect", value);
            }
        }
        
        public string EffectAllowed
        {
            get
            {
                return this.GetProperty<string>("effectAllowed");
            }
            set
            {
                this.SetProperty("effectAllowed", value);
            }
        }
        
        public nsISupports Types
        {
            get
            {
                return this.GetProperty<nsISupports>("types");
            }
        }
        
        public nsISupports Files
        {
            get
            {
                return this.GetProperty<nsISupports>("files");
            }
        }
        
        public void SetDragImage(nsIDOMElement image, int x, int y)
        {
            this.CallVoidMethod("setDragImage", image, x, y);
        }
        
        public string GetData(string format)
        {
            return this.CallMethod<string>("getData", format);
        }
        
        public void SetData(string format, string data)
        {
            this.CallVoidMethod("setData", format, data);
        }
        
        public void ClearData()
        {
            this.CallVoidMethod("clearData");
        }
        
        public void ClearData(string format)
        {
            this.CallVoidMethod("clearData", format);
        }
        
        public Promise < WebIDLUnion<nsISupports,nsISupports>> GetFilesAndDirectories()
        {
            return this.CallMethod<Promise < WebIDLUnion<nsISupports,nsISupports>>>("getFilesAndDirectories");
        }
        
        public uint MozItemCount
        {
            get
            {
                return this.GetProperty<uint>("mozItemCount");
            }
        }
        
        public string MozCursor
        {
            get
            {
                return this.GetProperty<string>("mozCursor");
            }
            set
            {
                this.SetProperty("mozCursor", value);
            }
        }
        
        public bool MozUserCancelled
        {
            get
            {
                return this.GetProperty<bool>("mozUserCancelled");
            }
        }
        
        public nsIDOMNode MozSourceNode
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("mozSourceNode");
            }
        }
        
        public void AddElement(nsIDOMElement element)
        {
            this.CallVoidMethod("addElement", element);
        }
        
        public nsISupports MozTypesAt(uint index)
        {
            return this.CallMethod<nsISupports>("mozTypesAt", index);
        }
        
        public void MozClearDataAt(string format, uint index)
        {
            this.CallVoidMethod("mozClearDataAt", format, index);
        }
        
        public void MozSetDataAt(string format, object data, uint index)
        {
            this.CallVoidMethod("mozSetDataAt", format, data, index);
        }
        
        public object MozGetDataAt(string format, uint index)
        {
            return this.CallMethod<object>("mozGetDataAt", format, index);
        }
    }
}
