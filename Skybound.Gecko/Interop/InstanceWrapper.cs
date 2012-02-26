using System;
using System.Runtime.InteropServices;

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
			FreeServiceReference();
		}

		private void FreeServiceReference()
		{
			if (Instance == null) return;
			Marshal.ReleaseComObject(Instance);
			Instance = null;
		}

		public void Dispose()
		{
			FreeServiceReference();
			GC.SuppressFinalize( this );
		}
	}
}