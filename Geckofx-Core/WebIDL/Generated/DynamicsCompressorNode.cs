namespace Gecko.WebIDL
{
    using System;
    
    
    public class DynamicsCompressorNode : WebIDLBase
    {
        
        public DynamicsCompressorNode(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Threshold
        {
            get
            {
                return this.GetProperty<nsISupports>("threshold");
            }
        }
        
        public nsISupports Knee
        {
            get
            {
                return this.GetProperty<nsISupports>("knee");
            }
        }
        
        public nsISupports Ratio
        {
            get
            {
                return this.GetProperty<nsISupports>("ratio");
            }
        }
        
        public float Reduction
        {
            get
            {
                return this.GetProperty<float>("reduction");
            }
        }
        
        public nsISupports Attack
        {
            get
            {
                return this.GetProperty<nsISupports>("attack");
            }
        }
        
        public nsISupports Release
        {
            get
            {
                return this.GetProperty<nsISupports>("release");
            }
        }
    }
}
