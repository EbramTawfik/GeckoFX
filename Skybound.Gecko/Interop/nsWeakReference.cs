using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gecko.Interop
{
	class nsWeakReference
		:nsIWeakReference
	{
		protected WeakReference _weakReference;

		protected nsWeakReference(object obj)
		{
			_weakReference = new WeakReference( obj, false );
		}

		IntPtr nsIWeakReference.QueryReferent(  ref Guid uuid)
		{
			return _weakReference.IsAlive
			       	? QueryReferentImplementation( ref uuid )
			       	: IntPtr.Zero;
		}

		protected virtual IntPtr QueryReferentImplementation(ref Guid uuid)
		{
			return Xpcom.QueryReferent( _weakReference.Target, ref uuid );
		}

		/// <summary>
		/// This fuction contains different logic for Controls
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static nsWeakReference Create(object obj)
		{
			if (obj is Control)
			{
				return new ControlWeakReference( ( Control ) obj );
			}
			return new nsWeakReference( obj );
		}
	}


	sealed class ControlWeakReference
		: nsWeakReference
	{

		internal ControlWeakReference(Control control)
			:base(control)
		{
			
		}

		protected override IntPtr QueryReferentImplementation(ref Guid uuid)
		{
			return ((Control)_weakReference.Target).IsDisposed
				? IntPtr.Zero
				: base.QueryReferentImplementation(ref uuid);
		}
	}

}
