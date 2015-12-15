namespace Gecko.WebIDL
{
    using System;
    
    
    public class UndoManager : WebIDLBase
    {
        
        public UndoManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public uint Position
        {
            get
            {
                return this.GetProperty<uint>("position");
            }
        }
        
        public void Transact(nsISupports transaction, bool merge)
        {
            this.CallVoidMethod("transact", transaction, merge);
        }
        
        public void Undo()
        {
            this.CallVoidMethod("undo");
        }
        
        public void Redo()
        {
            this.CallVoidMethod("redo");
        }
        
        public nsISupports[] Item(uint index)
        {
            return this.CallMethod<nsISupports[]>("item", index);
        }
        
        public void ClearUndo()
        {
            this.CallVoidMethod("clearUndo");
        }
        
        public void ClearRedo()
        {
            this.CallVoidMethod("clearRedo");
        }
    }
}
