using System;
using System.Runtime.InteropServices;

namespace Gecko
{
	public sealed class ConsoleService
		:IDisposable
	{
		internal nsIConsoleService _nativeService;

		public ConsoleService()
		{
			_nativeService = Xpcom.GetService<nsIConsoleService>(Contracts.ConsoleService);
		}

		private void ReleaseComObject()
		{
			if ( _nativeService == null )
			{
				return;
			}
			Marshal.ReleaseComObject( _nativeService );
			_nativeService = null;
		}

		~ConsoleService()
		{
			ReleaseComObject();
		}

		public void Dispose()
		{
			ReleaseComObject();
			GC.SuppressFinalize( this );
		}
	}
}