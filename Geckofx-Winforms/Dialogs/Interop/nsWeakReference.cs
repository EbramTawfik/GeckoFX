using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gecko.Interop
{
	/// <summary>
	/// nsIWeakReference implementation for .NET object
	/// </summary>
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
			// If object is alive we take it to QueryReferentImplementation
			// else return IntPtr.Zero
			return _weakReference.IsAlive
			       	? QueryReferentImplementation(_weakReference.Target, ref uuid )
			       	: IntPtr.Zero;
		}

		protected virtual IntPtr QueryReferentImplementation(object obj,ref Guid uuid)
		{
			// by default we make QueryReferent
			return Xpcom.QueryReferent(obj, ref uuid);
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


	/// <summary>
	/// Special implementation for Control objects
	/// </summary>
	sealed class ControlWeakReference
		: nsWeakReference
	{

		internal ControlWeakReference(Control control)
			:base(control)
		{
			
		}

		protected override IntPtr QueryReferentImplementation(object obj,ref Guid uuid)
		{
			// for Control we check it IsDisposed state
			// if control is disposed -> return IntPtr.Zero 
			return ((Control)obj).IsDisposed
				? IntPtr.Zero
				: base.QueryReferentImplementation(obj,ref uuid);
		}
	}

}
