using System;
using System.Runtime.InteropServices;

namespace Gecko
{
    class GeckoWebBrowserWeakRef : nsIWeakReference,  IDisposable
    {
        #region nsIWeakReference implementation

        IntPtr _iUnknown;
        public GeckoWebBrowserWeakRef(GeckoWebBrowser gwb)
        {
            // Don't hold a ref count for this.
            var iuknown = Marshal.GetIUnknownForObject(gwb);           
            Marshal.Release(iuknown);
            _iUnknown = iuknown;
        }

        public IntPtr QueryReferent(ref Guid uuid)
        {
            if (_iUnknown == IntPtr.Zero)
                return IntPtr.Zero;

            IntPtr ppv;
            Marshal.QueryInterface(_iUnknown, ref uuid, out ppv);
            return ppv;
        }

        #endregion

        #region IDisposable implementation

        public void Dispose()
        {
            _iUnknown = IntPtr.Zero;
        }

        #endregion
    }

}

