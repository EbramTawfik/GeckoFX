using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Gecko
{
	internal sealed class InstanceWrapper<T>
		:IDisposable
		where T : class
	{
		internal T Instance;

		internal InstanceWrapper(string contractID)
		{
			Instance = Xpcom.CreateInstance<T>(contractID);
		}

		~InstanceWrapper()
		{
			FreeInstanceReference();
		}

		private void FreeInstanceReference()
		{
			if (Instance == null) return;
			var obj = Interlocked.Exchange(ref Instance, null);
			// May be Marshal.FinalReleaseComObject(  ) - but we must ABSOLUTLY sure.
			Marshal.ReleaseComObject( obj );
		}

		public void Dispose()
		{
			FreeInstanceReference();
			GC.SuppressFinalize( this );
		}
	}
}