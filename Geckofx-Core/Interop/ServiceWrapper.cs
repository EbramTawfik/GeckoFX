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
		:ComPtr<T>
		where T : class
	{

		#region ctor & dtor
		internal ServiceWrapper(string contractID)
			: base(CreateServiceReference(contractID))
		{
			CreateServiceReference( contractID );
		}

		internal ServiceWrapper(T addRefedServiceInstance)
			:base(addRefedServiceInstance)
		{
			
		}
		#endregion

		private static T CreateServiceReference(string contractID)
		{
			if (!Xpcom.IsInitialized)
			{
				throw new GeckoException("Xpcom.Initialize must be called before using of any xulrunner/gecko-fx services");
			}
			return Xpcom.GetService<T>(contractID);
		}
	}

}