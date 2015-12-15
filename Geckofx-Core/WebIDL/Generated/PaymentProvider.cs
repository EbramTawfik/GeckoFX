namespace Gecko.WebIDL
{
    using System;
    
    
    public class PaymentProvider : WebIDLBase
    {
        
        public PaymentProvider(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString PaymentServiceId
        {
            get
            {
                return this.GetProperty<nsAString>("paymentServiceId");
            }
        }
        
        public object[] IccInfo
        {
            get
            {
                return this.GetProperty<object[]>("iccInfo");
            }
        }
        
        public void PaymentSuccess(nsAString result)
        {
            this.CallVoidMethod("paymentSuccess", result);
        }
        
        public void PaymentFailed(nsAString error)
        {
            this.CallVoidMethod("paymentFailed", error);
        }
        
        public nsISupports SendSilentSms(nsAString number, nsAString message)
        {
            return this.CallMethod<nsISupports>("sendSilentSms", number, message);
        }
    }
}
