namespace Gecko.WebIDL
{
    using System;
    
    
    public class SubtleCrypto : WebIDLBase
    {
        
        public SubtleCrypto(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise <object> Encrypt(WebIDLUnion<Object,String> algorithm, nsISupports key, WebIDLUnion<IntPtr,IntPtr> data)
        {
            return this.CallMethod<Promise <object>>("encrypt", algorithm, key, data);
        }
        
        public Promise <object> Decrypt(WebIDLUnion<Object,String> algorithm, nsISupports key, WebIDLUnion<IntPtr,IntPtr> data)
        {
            return this.CallMethod<Promise <object>>("decrypt", algorithm, key, data);
        }
        
        public Promise <object> Sign(WebIDLUnion<Object,String> algorithm, nsISupports key, WebIDLUnion<IntPtr,IntPtr> data)
        {
            return this.CallMethod<Promise <object>>("sign", algorithm, key, data);
        }
        
        public Promise <object> Verify(WebIDLUnion<Object,String> algorithm, nsISupports key, WebIDLUnion<IntPtr,IntPtr> signature, WebIDLUnion<IntPtr,IntPtr> data)
        {
            return this.CallMethod<Promise <object>>("verify", algorithm, key, signature, data);
        }
        
        public Promise <object> Digest(WebIDLUnion<Object,String> algorithm, WebIDLUnion<IntPtr,IntPtr> data)
        {
            return this.CallMethod<Promise <object>>("digest", algorithm, data);
        }
        
        public Promise <object> GenerateKey(WebIDLUnion<Object,String> algorithm, bool extractable, String[] keyUsages)
        {
            return this.CallMethod<Promise <object>>("generateKey", algorithm, extractable, keyUsages);
        }
        
        public Promise <object> DeriveKey(WebIDLUnion<Object,String> algorithm, nsISupports baseKey, WebIDLUnion<Object,String> derivedKeyType, bool extractable, String[] keyUsages)
        {
            return this.CallMethod<Promise <object>>("deriveKey", algorithm, baseKey, derivedKeyType, extractable, keyUsages);
        }
        
        public Promise <object> DeriveBits(WebIDLUnion<Object,String> algorithm, nsISupports baseKey, uint length)
        {
            return this.CallMethod<Promise <object>>("deriveBits", algorithm, baseKey, length);
        }
        
        public Promise <object> ImportKey(String format, object keyData, WebIDLUnion<Object,String> algorithm, bool extractable, String[] keyUsages)
        {
            return this.CallMethod<Promise <object>>("importKey", format, keyData, algorithm, extractable, keyUsages);
        }
        
        public Promise <object> ExportKey(String format, nsISupports key)
        {
            return this.CallMethod<Promise <object>>("exportKey", format, key);
        }
        
        public Promise <object> WrapKey(String format, nsISupports key, nsISupports wrappingKey, WebIDLUnion<Object,String> wrapAlgorithm)
        {
            return this.CallMethod<Promise <object>>("wrapKey", format, key, wrappingKey, wrapAlgorithm);
        }
        
        public Promise <object> UnwrapKey(String format, WebIDLUnion<IntPtr,IntPtr> wrappedKey, nsISupports unwrappingKey, WebIDLUnion<Object,String> unwrapAlgorithm, WebIDLUnion<Object,String> unwrappedKeyAlgorithm, bool extractable, String[] keyUsages)
        {
            return this.CallMethod<Promise <object>>("unwrapKey", format, wrappedKey, unwrappingKey, unwrapAlgorithm, unwrappedKeyAlgorithm, extractable, keyUsages);
        }
    }
}
