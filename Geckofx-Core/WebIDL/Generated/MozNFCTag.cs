namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNFCTag : WebIDLBase
    {
        
        public MozNFCTag(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public NFCTechType[] TechList
        {
            get
            {
                return this.GetProperty<NFCTechType[]>("techList");
            }
        }
        
        public IntPtr Id
        {
            get
            {
                return this.GetProperty<IntPtr>("id");
            }
        }
        
        public NFCTagType Type
        {
            get
            {
                return this.GetProperty<NFCTagType>("type");
            }
        }
        
        public System.Nullable<int> MaxNDEFSize
        {
            get
            {
                return this.GetProperty<System.Nullable<int>>("maxNDEFSize");
            }
        }
        
        public System.Nullable<bool> IsReadOnly
        {
            get
            {
                return this.GetProperty<System.Nullable<bool>>("isReadOnly");
            }
        }
        
        public System.Nullable<bool> IsFormatable
        {
            get
            {
                return this.GetProperty<System.Nullable<bool>>("isFormatable");
            }
        }
        
        public System.Nullable<bool> CanBeMadeReadOnly
        {
            get
            {
                return this.GetProperty<System.Nullable<bool>>("canBeMadeReadOnly");
            }
        }
        
        public bool IsLost
        {
            get
            {
                return this.GetProperty<bool>("isLost");
            }
        }
        
        public Promise < nsISupports[] > ReadNDEF()
        {
            return this.CallMethod<Promise < nsISupports[] >>("readNDEF");
        }
        
        public Promise WriteNDEF(nsISupports[] records)
        {
            return this.CallMethod<Promise>("writeNDEF", records);
        }
        
        public Promise MakeReadOnly()
        {
            return this.CallMethod<Promise>("makeReadOnly");
        }
        
        public Promise Format()
        {
            return this.CallMethod<Promise>("format");
        }
        
        public WebIDLUnion<nsISupports,nsISupports> SelectTech(NFCTechType tech)
        {
            return this.CallMethod<WebIDLUnion<nsISupports,nsISupports>>("selectTech", tech);
        }
        
        public string Session
        {
            get
            {
                return this.GetProperty<string>("session");
            }
            set
            {
                this.SetProperty("session", value);
            }
        }
        
        public void NotifyLost()
        {
            this.CallVoidMethod("notifyLost");
        }
        
        public Promise < IntPtr > Transceive(NFCTechType tech, IntPtr command)
        {
            return this.CallMethod<Promise < IntPtr >>("transceive", tech, command);
        }
    }
}
