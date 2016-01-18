namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozSelfSupport : WebIDLBase
    {
        
        public MozSelfSupport(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool HealthReportDataSubmissionEnabled
        {
            get
            {
                return this.GetProperty<bool>("healthReportDataSubmissionEnabled");
            }
            set
            {
                this.SetProperty("healthReportDataSubmissionEnabled", value);
            }
        }
        
        public Promise <object> GetHealthReportPayload()
        {
            return this.CallMethod<Promise <object>>("getHealthReportPayload");
        }
        
        public Promise < System.Object[] > GetTelemetryPingList()
        {
            return this.CallMethod<Promise < System.Object[] >>("getTelemetryPingList");
        }
        
        public Promise <object> GetTelemetryPing(string pingID)
        {
            return this.CallMethod<Promise <object>>("getTelemetryPing", pingID);
        }
        
        public Promise <object> GetCurrentTelemetryEnvironment()
        {
            return this.CallMethod<Promise <object>>("getCurrentTelemetryEnvironment");
        }
        
        public Promise <object> GetCurrentTelemetrySubsessionPing()
        {
            return this.CallMethod<Promise <object>>("getCurrentTelemetrySubsessionPing");
        }
        
        public void ResetPref(string name)
        {
            this.CallVoidMethod("resetPref", name);
        }
        
        public void ResetSearchEngines()
        {
            this.CallVoidMethod("resetSearchEngines");
        }
    }
}
