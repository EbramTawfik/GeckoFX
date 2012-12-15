using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace Gecko.Interop
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
		private T _instance;

		#region ctor & dtor
		internal ServiceWrapper(string contractID)
		{
			CreateServiceReference( contractID );
		}

		internal ServiceWrapper(T addRefedServiceInstance)
		{
			_instance = addRefedServiceInstance;
		}

		~ServiceWrapper()
		{
			Xpcom.FreeComObject( ref _instance );
		}

		public void Dispose()
		{
			Xpcom.FreeComObject(ref _instance);
			GC.SuppressFinalize(this);
		}
		#endregion

		internal T Instance
		{
			get
			{
				// check for uninialized state (errors, or release)
				if (_instance == null)
				{
					
				}
				return _instance;
			}
		}

		#region creation and release
		private void CreateServiceReference(string contractID)
		{
			if (!Xpcom.IsInitialized)
			{
				throw new GeckoException("Xpcom.Initialize must be called before using of any xulrunner/gecko-fx services");
			}
			_instance = Xpcom.GetService<T>(contractID);
		}
		#endregion

	}

}