using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.Interop
{
#if DEBUG
	/// <summary>
	/// Class for gebug help
	/// </summary>
	public static class ComDebug
	{
		/// <summary>
		/// Gets reference count of gecko object
		/// </summary>
		/// <param name="xulrunnerObject"></param>
		/// <returns></returns>
		public static int GetRcwRefCount(object xulrunnerObject)
		{
			nsISupports supports = null;
			try
			{
				// All Gecko objects are implicitly implements nsISupports
				supports = Xpcom.QueryInterface<nsISupports>(xulrunnerObject);
			}
			catch ( Exception )
			{
			} 
			// If this is not xulrunner COM object - simply return 0
			if (supports == null) return 0;
			int count = Marshal.ReleaseComObject(supports);
			return count;
		}

		public static int GetComRefCount(object xulrunnerObject)
		{
			IntPtr pUnk = Marshal.GetIUnknownForObject(xulrunnerObject);
			if (pUnk == IntPtr.Zero) return -1;
			int count=Marshal.Release( pUnk );
			return count;
		}
	}
#endif
}
