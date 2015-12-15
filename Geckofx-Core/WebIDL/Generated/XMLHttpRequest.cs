namespace Gecko.WebIDL
{
    using System;
    
    
    public class XMLHttpRequest : WebIDLBase
    {
        
        public XMLHttpRequest(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public ushort ReadyState
        {
            get
            {
                return this.GetProperty<ushort>("readyState");
            }
        }
        
        public uint Timeout
        {
            get
            {
                return this.GetProperty<uint>("timeout");
            }
            set
            {
                this.SetProperty("timeout", value);
            }
        }
        
        public bool WithCredentials
        {
            get
            {
                return this.GetProperty<bool>("withCredentials");
            }
            set
            {
                this.SetProperty("withCredentials", value);
            }
        }
        
        public nsISupports Upload
        {
            get
            {
                return this.GetProperty<nsISupports>("upload");
            }
        }
        
        public nsAString ResponseURL
        {
            get
            {
                return this.GetProperty<nsAString>("responseURL");
            }
        }
        
        public ushort Status
        {
            get
            {
                return this.GetProperty<ushort>("status");
            }
        }
        
        public ByteString StatusText
        {
            get
            {
                return this.GetProperty<ByteString>("statusText");
            }
        }
        
        public XMLHttpRequestResponseType ResponseType
        {
            get
            {
                return this.GetProperty<XMLHttpRequestResponseType>("responseType");
            }
            set
            {
                this.SetProperty("responseType", value);
            }
        }
        
        public object Response
        {
            get
            {
                return this.GetProperty<object>("response");
            }
        }
        
        public nsAString ResponseText
        {
            get
            {
                return this.GetProperty<nsAString>("responseText");
            }
        }
        
        public nsIDOMDocument ResponseXML
        {
            get
            {
                return this.GetProperty<nsIDOMDocument>("responseXML");
            }
        }
        
        public bool MozBackgroundRequest
        {
            get
            {
                return this.GetProperty<bool>("mozBackgroundRequest");
            }
            set
            {
                this.SetProperty("mozBackgroundRequest", value);
            }
        }
        
        public nsISupports Channel
        {
            get
            {
                return this.GetProperty<nsISupports>("channel");
            }
        }
        
        public ByteString NetworkInterfaceId
        {
            get
            {
                return this.GetProperty<ByteString>("networkInterfaceId");
            }
            set
            {
                this.SetProperty("networkInterfaceId", value);
            }
        }
        
        public bool MozAnon
        {
            get
            {
                return this.GetProperty<bool>("mozAnon");
            }
        }
        
        public bool MozSystem
        {
            get
            {
                return this.GetProperty<bool>("mozSystem");
            }
        }
        
        public void Open(ByteString method, nsAString url)
        {
            this.CallVoidMethod("open", method, url);
        }
        
        public void Open(ByteString method, nsAString url, bool async, nsAString user, nsAString password)
        {
            this.CallVoidMethod("open", method, url, async, user, password);
        }
        
        public void SetRequestHeader(ByteString header, ByteString value)
        {
            this.CallVoidMethod("setRequestHeader", header, value);
        }
        
        public void Send()
        {
            this.CallVoidMethod("send");
        }
        
        public void Send(IntPtr data)
        {
            this.CallVoidMethod("send", data);
        }
        
        public void Send(nsIDOMBlob data)
        {
            this.CallVoidMethod("send", data);
        }
        
        public void Send(nsIDOMDocument data)
        {
            this.CallVoidMethod("send", data);
        }
        
        public void Send(nsAString data)
        {
            this.CallVoidMethod("send", data);
        }
        
        public void Send(nsIDOMFormData data)
        {
            this.CallVoidMethod("send", data);
        }
        
        public void Send(nsISupports data)
        {
            this.CallVoidMethod("send", data);
        }
        
        public void Abort()
        {
            this.CallVoidMethod("abort");
        }
        
        public ByteString GetResponseHeader(ByteString header)
        {
            return this.CallMethod<ByteString>("getResponseHeader", header);
        }
        
        public ByteString GetAllResponseHeaders()
        {
            return this.CallMethod<ByteString>("getAllResponseHeaders");
        }
        
        public void OverrideMimeType(nsAString mime)
        {
            this.CallVoidMethod("overrideMimeType", mime);
        }
        
        public object GetInterface(nsISupports iid)
        {
            return this.CallMethod<object>("getInterface", iid);
        }
    }
}
