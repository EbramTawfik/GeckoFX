namespace Gecko.WebIDL
{
    using System;
    
    
    public class Console : WebIDLBase
    {
        
        public Console(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void Log(object data)
        {
            this.CallVoidMethod("log", data);
        }
        
        public void Info(object data)
        {
            this.CallVoidMethod("info", data);
        }
        
        public void Warn(object data)
        {
            this.CallVoidMethod("warn", data);
        }
        
        public void Error(object data)
        {
            this.CallVoidMethod("error", data);
        }
        
        public void _exception(object data)
        {
            this.CallVoidMethod("_exception", data);
        }
        
        public void Debug(object data)
        {
            this.CallVoidMethod("debug", data);
        }
        
        public void Table(object data)
        {
            this.CallVoidMethod("table", data);
        }
        
        public void Trace()
        {
            this.CallVoidMethod("trace");
        }
        
        public void Dir(object data)
        {
            this.CallVoidMethod("dir", data);
        }
        
        public void Dirxml(object data)
        {
            this.CallVoidMethod("dirxml", data);
        }
        
        public void Group(object data)
        {
            this.CallVoidMethod("group", data);
        }
        
        public void GroupCollapsed(object data)
        {
            this.CallVoidMethod("groupCollapsed", data);
        }
        
        public void GroupEnd(object data)
        {
            this.CallVoidMethod("groupEnd", data);
        }
        
        public void Time(object time)
        {
            this.CallVoidMethod("time", time);
        }
        
        public void TimeEnd(object time)
        {
            this.CallVoidMethod("timeEnd", time);
        }
        
        public void TimeStamp(object data)
        {
            this.CallVoidMethod("timeStamp", data);
        }
        
        public void Profile(object data)
        {
            this.CallVoidMethod("profile", data);
        }
        
        public void ProfileEnd(object data)
        {
            this.CallVoidMethod("profileEnd", data);
        }
        
        public void Assert(bool condition, object data)
        {
            this.CallVoidMethod("assert", condition, data);
        }
        
        public void Count(object data)
        {
            this.CallVoidMethod("count", data);
        }
        
        public void Clear()
        {
            this.CallVoidMethod("clear");
        }
        
        public void MarkTimeline()
        {
            this.CallVoidMethod("markTimeline");
        }
        
        public void Timeline()
        {
            this.CallVoidMethod("timeline");
        }
        
        public void TimelineEnd()
        {
            this.CallVoidMethod("timelineEnd");
        }
    }
}
