using System;
using System.Runtime.InteropServices;

namespace Gecko
{
	/// <summary>
	/// This is 'light' service wrapper
	/// use it internal in geckoFX with using() construction when wrapper is not needed (closed via Dispose)
	/// use it in a STATIC field in a service wrapper class (closed via destructor after app closes)
	/// </summary>
	/// <typeparam name="T"></typeparam>
	internal sealed class ServiceWrapper<T>
		:IDisposable
		where T : class
	{
		internal T Instance;

		internal ServiceWrapper(string contractID)
		{
			if (!Xpcom.IsInitialized)
			{
				throw new GeckoException("Xpcom.Initialize must be called before using of any xulrunner/gecko-fx services");
			}
			Instance = Xpcom.GetService<T>(contractID);
		}

		~ServiceWrapper()
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