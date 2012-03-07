using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Gecko.Listeners
{
    abstract class GeckoBaseListener : nsISupportsWeakReference, nsIWeakReference
    {
        protected System.WeakReference _weakBrowser;

        protected GeckoWebBrowser _browser {
            get {
                if (!_weakBrowser.IsAlive) return null;
                GeckoWebBrowser b = (GeckoWebBrowser)_weakBrowser.Target;
                if (b.IsDisposed) return null;

                return (GeckoWebBrowser)b;
            }
        }

        public nsIWeakReference GetWeakReference()
        {
            return this;
        }

        public IntPtr QueryReferent(ref Guid uuid)
        {
        	return Xpcom.QueryReferent( this, ref uuid );
        }
    }
}
