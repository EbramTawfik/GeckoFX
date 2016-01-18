namespace Gecko.WebIDL
{
    using System;
    
    
    public class mozContact : WebIDLBase
    {
        
        public mozContact(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
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
        
        public nsAString Sex
        {
            get
            {
                return this.GetProperty<nsAString>("sex");
            }
            set
            {
                this.SetProperty("sex", value);
            }
        }
        
        public nsAString GenderIdentity
        {
            get
            {
                return this.GetProperty<nsAString>("genderIdentity");
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
        
        public nsAString[] Name
        {
            get
            {
                return this.GetProperty<nsAString[]>("name");
            }
            set
            {
                this.SetProperty("name", value);
            }
        }
        
        public nsAString[] HonorificPrefix
        {
            get
            {
                return this.GetProperty<nsAString[]>("honorificPrefix");
            }
            set
            {
                this.SetProperty("honorificPrefix", value);
            }
        }
        
        public nsAString[] GivenName
        {
            get
            {
                return this.GetProperty<nsAString[]>("givenName");
            }
            set
            {
                this.SetProperty("givenName", value);
            }
        }
        
        public nsAString[] PhoneticGivenName
        {
            get
            {
                return this.GetProperty<nsAString[]>("phoneticGivenName");
            }
            set
            {
                this.SetProperty("phoneticGivenName", value);
            }
        }
        
        public nsAString[] AdditionalName
        {
            get
            {
                return this.GetProperty<nsAString[]>("additionalName");
            }
            set
            {
                this.SetProperty("additionalName", value);
            }
        }
        
        public nsAString[] FamilyName
        {
            get
            {
                return this.GetProperty<nsAString[]>("familyName");
            }
            set
            {
                this.SetProperty("familyName", value);
            }
        }
        
        public nsAString[] PhoneticFamilyName
        {
            get
            {
                return this.GetProperty<nsAString[]>("phoneticFamilyName");
            }
            set
            {
                this.SetProperty("phoneticFamilyName", value);
            }
        }
        
        public nsAString[] HonorificSuffix
        {
            get
            {
                return this.GetProperty<nsAString[]>("honorificSuffix");
            }
            set
            {
                this.SetProperty("honorificSuffix", value);
            }
        }
        
        public nsAString[] Nickname
        {
            get
            {
                return this.GetProperty<nsAString[]>("nickname");
            }
            set
            {
                this.SetProperty("nickname", value);
            }
        }
        
        public nsAString[] Category
        {
            get
            {
                return this.GetProperty<nsAString[]>("category");
            }
            set
            {
                this.SetProperty("category", value);
            }
        }
        
        public nsAString[] Org
        {
            get
            {
                return this.GetProperty<nsAString[]>("org");
            }
            set
            {
                this.SetProperty("org", value);
            }
        }
        
        public nsAString[] JobTitle
        {
            get
            {
                return this.GetProperty<nsAString[]>("jobTitle");
            }
            set
            {
                this.SetProperty("jobTitle", value);
            }
        }
        
        public nsAString[] Note
        {
            get
            {
                return this.GetProperty<nsAString[]>("note");
            }
            set
            {
                this.SetProperty("note", value);
            }
        }
        
        public nsAString[] Key
        {
            get
            {
                return this.GetProperty<nsAString[]>("key");
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
        
        public void SetMetadata(nsAString id, IntPtr published, IntPtr updated)
        {
            this.CallVoidMethod("setMetadata", id, published, updated);
        }
    }
}
