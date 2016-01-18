namespace Gecko.WebIDL
{
    using System;
    
    
    public class mozContact : WebIDLBase
    {
        
        public mozContact(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
            set
            {
                this.SetProperty("id", value);
            }
        }
        
        public IntPtr Published
        {
            get
            {
                return this.GetProperty<IntPtr>("published");
            }
        }
        
        public IntPtr Updated
        {
            get
            {
                return this.GetProperty<IntPtr>("updated");
            }
        }
        
        public IntPtr Bday
        {
            get
            {
                return this.GetProperty<IntPtr>("bday");
            }
            set
            {
                this.SetProperty("bday", value);
            }
        }
        
        public IntPtr Anniversary
        {
            get
            {
                return this.GetProperty<IntPtr>("anniversary");
            }
            set
            {
                this.SetProperty("anniversary", value);
            }
        }
        
        public string Sex
        {
            get
            {
                return this.GetProperty<string>("sex");
            }
            set
            {
                this.SetProperty("sex", value);
            }
        }
        
        public string GenderIdentity
        {
            get
            {
                return this.GetProperty<string>("genderIdentity");
            }
            set
            {
                this.SetProperty("genderIdentity", value);
            }
        }
        
        public nsIDOMBlob[] Photo
        {
            get
            {
                return this.GetProperty<nsIDOMBlob[]>("photo");
            }
            set
            {
                this.SetProperty("photo", value);
            }
        }
        
        public object[] Adr
        {
            get
            {
                return this.GetProperty<object[]>("adr");
            }
            set
            {
                this.SetProperty("adr", value);
            }
        }
        
        public object[] Email
        {
            get
            {
                return this.GetProperty<object[]>("email");
            }
            set
            {
                this.SetProperty("email", value);
            }
        }
        
        public object[] Url
        {
            get
            {
                return this.GetProperty<object[]>("url");
            }
            set
            {
                this.SetProperty("url", value);
            }
        }
        
        public object[] Impp
        {
            get
            {
                return this.GetProperty<object[]>("impp");
            }
            set
            {
                this.SetProperty("impp", value);
            }
        }
        
        public object[] Tel
        {
            get
            {
                return this.GetProperty<object[]>("tel");
            }
            set
            {
                this.SetProperty("tel", value);
            }
        }
        
        public string[] Name
        {
            get
            {
                return this.GetProperty<string[]>("name");
            }
            set
            {
                this.SetProperty("name", value);
            }
        }
        
        public string[] HonorificPrefix
        {
            get
            {
                return this.GetProperty<string[]>("honorificPrefix");
            }
            set
            {
                this.SetProperty("honorificPrefix", value);
            }
        }
        
        public string[] GivenName
        {
            get
            {
                return this.GetProperty<string[]>("givenName");
            }
            set
            {
                this.SetProperty("givenName", value);
            }
        }
        
        public string[] PhoneticGivenName
        {
            get
            {
                return this.GetProperty<string[]>("phoneticGivenName");
            }
            set
            {
                this.SetProperty("phoneticGivenName", value);
            }
        }
        
        public string[] AdditionalName
        {
            get
            {
                return this.GetProperty<string[]>("additionalName");
            }
            set
            {
                this.SetProperty("additionalName", value);
            }
        }
        
        public string[] FamilyName
        {
            get
            {
                return this.GetProperty<string[]>("familyName");
            }
            set
            {
                this.SetProperty("familyName", value);
            }
        }
        
        public string[] PhoneticFamilyName
        {
            get
            {
                return this.GetProperty<string[]>("phoneticFamilyName");
            }
            set
            {
                this.SetProperty("phoneticFamilyName", value);
            }
        }
        
        public string[] HonorificSuffix
        {
            get
            {
                return this.GetProperty<string[]>("honorificSuffix");
            }
            set
            {
                this.SetProperty("honorificSuffix", value);
            }
        }
        
        public string[] Nickname
        {
            get
            {
                return this.GetProperty<string[]>("nickname");
            }
            set
            {
                this.SetProperty("nickname", value);
            }
        }
        
        public string[] Category
        {
            get
            {
                return this.GetProperty<string[]>("category");
            }
            set
            {
                this.SetProperty("category", value);
            }
        }
        
        public string[] Org
        {
            get
            {
                return this.GetProperty<string[]>("org");
            }
            set
            {
                this.SetProperty("org", value);
            }
        }
        
        public string[] JobTitle
        {
            get
            {
                return this.GetProperty<string[]>("jobTitle");
            }
            set
            {
                this.SetProperty("jobTitle", value);
            }
        }
        
        public string[] Note
        {
            get
            {
                return this.GetProperty<string[]>("note");
            }
            set
            {
                this.SetProperty("note", value);
            }
        }
        
        public string[] Key
        {
            get
            {
                return this.GetProperty<string[]>("key");
            }
            set
            {
                this.SetProperty("key", value);
            }
        }
        
        public void Init()
        {
            this.CallVoidMethod("init");
        }
        
        public void Init(object properties)
        {
            this.CallVoidMethod("init", properties);
        }
        
        public void SetMetadata(string id, IntPtr published, IntPtr updated)
        {
            this.CallVoidMethod("setMetadata", id, published, updated);
        }
    }
}
