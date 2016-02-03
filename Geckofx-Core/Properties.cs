using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Gecko
{
    public class Properties
    {
        private nsIProperties _properties;

        internal Properties(nsIProperties properties)
        {
            _properties = properties;
        }

        public bool Has(string property)
        {
            return _properties.Has(property);
        }

        public bool Undefine(string property)
        {
            // If property is not exist it will throw exception
            bool flag = _properties.Has(property);
            if (flag)
            {
                _properties.Undefine(property);
            }
            return flag;
        }

        public string[] GetKeys()
        {
            uint count = 0;
            string[] ret = null;
#warning test it
            _properties.GetKeys(ref count, ref ret);
            return ret;
        }
    }

    public class PersistentProperties
        : Properties
    {
        private nsIPersistentProperties _persistentProperties;

        internal PersistentProperties(nsIPersistentProperties persistentProperties)
            : base(persistentProperties)
        {
            _persistentProperties = persistentProperties;
        }
    }
}