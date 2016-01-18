namespace Gecko.WebIDL
{
    using System;
    
    
    public class PaymentProvider : WebIDLBase
    {
        
        public PaymentProvider(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string PaymentServiceId
        {
            get
            {
                return this.GetProperty<string>("paymentServiceId");
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
        
        public void PaymentSuccess(string result)
        {
            this.CallVoidMethod("paymentSuccess", result);
        }
        
        public void PaymentFailed()
        {
            this.CallVoidMethod("paymentFailed");
        }
        
        public void PaymentFailed(string error)
        {
            this.CallVoidMethod("paymentFailed", error);
        }
        
        public nsISupports SendSilentSms(string number, string message)
        {
            return this.CallMethod<nsISupports>("sendSilentSms", number, message);
        }
    }
}
