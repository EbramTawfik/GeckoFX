namespace Gecko.WebIDL
{
    using System;
    
    
    public class History : WebIDLBase
    {
        
        public History(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public object State
        {
            get
            {
                return this.GetProperty<object>("state");
            }
        }
        
        public void Go()
        {
            this.CallVoidMethod("go");
        }
        
        public void Go(int delta)
        {
            this.CallVoidMethod("go", delta);
        }
        
        public void Back()
        {
            this.CallVoidMethod("back");
        }
        
        public void Forward()
        {
            this.CallVoidMethod("forward");
        }
        
        public void PushState(object data, nsAString title)
        {
            this.CallVoidMethod("pushState", data, title);
        }
        
        public void PushState(object data, nsAString title, nsAString url)
        {
            this.CallVoidMethod("pushState", data, title, url);
        }
        
        public void ReplaceState(object data, nsAString title)
        {
            this.CallVoidMethod("replaceState", data, title);
        }
        
        public void ReplaceState(object data, nsAString title, nsAString url)
        {
            this.CallVoidMethod("replaceState", data, title, url);
        }
    }
}
