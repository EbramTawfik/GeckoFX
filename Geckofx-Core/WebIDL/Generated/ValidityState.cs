namespace Gecko.WebIDL
{
    using System;
    
    
    public class ValidityState : WebIDLBase
    {
        
        public ValidityState(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool ValueMissing
        {
            get
            {
                return this.GetProperty<bool>("valueMissing");
            }
        }
        
        public bool TypeMismatch
        {
            get
            {
                return this.GetProperty<bool>("typeMismatch");
            }
        }
        
        public bool PatternMismatch
        {
            get
            {
                return this.GetProperty<bool>("patternMismatch");
            }
        }
        
        public bool TooLong
        {
            get
            {
                return this.GetProperty<bool>("tooLong");
            }
        }
        
        public bool RangeUnderflow
        {
            get
            {
                return this.GetProperty<bool>("rangeUnderflow");
            }
        }
        
        public bool RangeOverflow
        {
            get
            {
                return this.GetProperty<bool>("rangeOverflow");
            }
        }
        
        public bool StepMismatch
        {
            get
            {
                return this.GetProperty<bool>("stepMismatch");
            }
        }
        
        public bool BadInput
        {
            get
            {
                return this.GetProperty<bool>("badInput");
            }
        }
        
        public bool CustomError
        {
            get
            {
                return this.GetProperty<bool>("customError");
            }
        }
        
        public bool Valid
        {
            get
            {
                return this.GetProperty<bool>("valid");
            }
        }
    }
}
