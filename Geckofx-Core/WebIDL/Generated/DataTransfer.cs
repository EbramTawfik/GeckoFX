namespace Gecko.WebIDL
{
    using System;
    
    
    public class DataTransfer : WebIDLBase
    {
        
        public DataTransfer(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString DropEffect
        {
            get
            {
                return this.GetProperty<nsAString>("dropEffect");
            }
            set
            {
                this.SetProperty("dropEffect", value);
            }
        }
        
        public nsAString EffectAllowed
        {
            get
            {
                return this.GetProperty<nsAString>("effectAllowed");
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
        
        public nsAString GetData(nsAString format)
        {
            return this.CallMethod<nsAString>("getData", format);
        }
        
        public void SetData(nsAString format, nsAString data)
        {
            this.CallVoidMethod("setData", format, data);
        }
        
        public void ClearData(nsAString format)
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
        
        public nsAString MozCursor
        {
            get
            {
                return this.GetProperty<nsAString>("mozCursor");
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
        
        public void MozClearDataAt(nsAString format, uint index)
        {
            this.CallVoidMethod("mozClearDataAt", format, index);
        }
        
        public void MozSetDataAt(nsAString format, object data, uint index)
        {
            this.CallVoidMethod("mozSetDataAt", format, data, index);
        }
        
        public object MozGetDataAt(nsAString format, uint index)
        {
            return this.CallMethod<object>("mozGetDataAt", format, index);
        }
    }
}
