namespace Gecko.WebIDL
{
    using System;
    
    
    public class PaymentProvider : WebIDLBase
    {
        
        public PaymentProvider(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public void PaymentSuccess()
        {
            this.CallVoidMethod("paymentSuccess");
        }
        
        public void PaymentSuccess(nsAString result)
        {
            this.CallVoidMethod("paymentSuccess", result);
        }
        
        public void PaymentFailed()
        {
            this.CallVoidMethod("paymentFailed");
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
