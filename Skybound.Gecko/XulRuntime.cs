using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko
{
	public static class XulRuntime
	{
		private static ServiceWrapper<nsIXULRuntime> _xulRuntime;

		static XulRuntime()
		{
			_xulRuntime=new ServiceWrapper<nsIXULRuntime>( Contracts.XulRuntime );
		}

		public static string OS
		{
			get { return nsString.Get( _xulRuntime.Instance.GetOSAttribute ); }
		}
	}
}
