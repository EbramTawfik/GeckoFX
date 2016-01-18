namespace Gecko.WebIDL
{
    using System;
    
    
    public class SubtleCrypto : WebIDLBase
    {
        
        public SubtleCrypto(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise <object> Encrypt(WebIDLUnion<Object,nsAString> algorithm, nsISupports key, WebIDLUnion<IntPtr,IntPtr> data)
        {
            return this.CallMethod<Promise <object>>("encrypt", algorithm, key, data);
        }
        
        public Promise <object> Decrypt(WebIDLUnion<Object,nsAString> algorithm, nsISupports key, WebIDLUnion<IntPtr,IntPtr> data)
        {
            return this.CallMethod<Promise <object>>("decrypt", algorithm, key, data);
        }
        
        public Promise <object> Sign(WebIDLUnion<Object,nsAString> algorithm, nsISupports key, WebIDLUnion<IntPtr,IntPtr> data)
        {
            return this.CallMethod<Promise <object>>("sign", algorithm, key, data);
        }
        
        public Promise <object> Verify(WebIDLUnion<Object,nsAString> algorithm, nsISupports key, WebIDLUnion<IntPtr,IntPtr> signature, WebIDLUnion<IntPtr,IntPtr> data)
        {
            return this.CallMethod<Promise <object>>("verify", algorithm, key, signature, data);
        }
        
        public Promise <object> Digest(WebIDLUnion<Object,nsAString> algorithm, WebIDLUnion<IntPtr,IntPtr> data)
        {
            return this.CallMethod<Promise <object>>("digest", algorithm, data);
        }
        
        public Promise <object> GenerateKey(WebIDLUnion<Object,nsAString> algorithm, bool extractable, nsAString[] keyUsages)
        {
            return this.CallMethod<Promise <object>>("generateKey", algorithm, extractable, keyUsages);
        }
        
        public Promise <object> DeriveKey(WebIDLUnion<Object,nsAString> algorithm, nsISupports baseKey, WebIDLUnion<Object,nsAString> derivedKeyType, bool extractable, nsAString[] keyUsages)
        {
            return this.CallMethod<Promise <object>>("deriveKey", algorithm, baseKey, derivedKeyType, extractable, keyUsages);
        }
        
        public Promise <object> DeriveBits(WebIDLUnion<Object,nsAString> algorithm, nsISupports baseKey, uint length)
        {
            return this.CallMethod<Promise <object>>("deriveBits", algorithm, baseKey, length);
        }
        
        public Promise <object> ImportKey(nsAString format, object keyData, WebIDLUnion<Object,nsAString> algorithm, bool extractable, nsAString[] keyUsages)
        {
            return this.CallMethod<Promise <object>>("importKey", format, keyData, algorithm, extractable, keyUsages);
        }
        
        public Promise <object> ExportKey(nsAString format, nsISupports key)
        {
            return this.CallMethod<Promise <object>>("exportKey", format, key);
        }
        
        public Promise <object> WrapKey(nsAString format, nsISupports key, nsISupports wrappingKey, WebIDLUnion<Object,nsAString> wrapAlgorithm)
        {
            return this.CallMethod<Promise <object>>("wrapKey", format, key, wrappingKey, wrapAlgorithm);
        }
        
        public Promise <object> UnwrapKey(nsAString format, WebIDLUnion<IntPtr,IntPtr> wrappedKey, nsISupports unwrappingKey, WebIDLUnion<Object,nsAString> unwrapAlgorithm, WebIDLUnion<Object,nsAString> unwrappedKeyAlgorithm, bool extractable, nsAString[] keyUsages)
        {
            return this.CallMethod<Promise <object>>("unwrapKey", format, wrappedKey, unwrappingKey, unwrapAlgorithm, unwrappedKeyAlgorithm, extractable, keyUsages);
        }
    }
}
