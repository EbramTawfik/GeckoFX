using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko
{
	public static class GlobalJSContextHolder
	{
		static IntPtr _jsContext;

		public static IntPtr JSContext 
		{
			get
			{
				if (_jsContext == IntPtr.Zero && Initalize != null)
					_jsContext = Initalize();

				return _jsContext;
			}			
		}

		public static Func<IntPtr> Initalize;
	}
}
