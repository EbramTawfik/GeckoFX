using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.Interop
{
	sealed class nsWeakReference
		:nsIWeakReference
	{
		private WeakReference _weakReference;

		public nsWeakReference(object obj)
		{
			_weakReference = new WeakReference( obj );
		}

		public IntPtr QueryReferent(ref Guid uuid)
		{
			return _weakReference.IsAlive
			       	? Xpcom.QueryReferent( _weakReference.Target, ref uuid )
			       	: IntPtr.Zero;
		}
	}
}
