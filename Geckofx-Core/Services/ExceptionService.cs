using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Interop;

namespace Gecko
{
#if DELME
	public static class ExceptionService
	{
		private static ServiceWrapper<nsIExceptionService> _exceptionService;

		static ExceptionService()
		{
			_exceptionService = new ServiceWrapper<nsIExceptionService>( Contracts.ExceptionService );
			
		}

		/// <summary>
		/// Gets ExceptionManager for current thread
		/// </summary>
		public static ExceptionManager ExceptionManager
		{
			get { return new ExceptionManager(_exceptionService.Instance.GetCurrentExceptionManagerAttribute()); }
		}

		public static GeckoNativeException GetCurrentException()
		{
			return GeckoNativeException.Create( _exceptionService.Instance.GetCurrentException() );
		}
	}
#endif

#if DELME
	public sealed class ExceptionManager
	{
		private nsIExceptionManager _exceptionManager;

		internal ExceptionManager(nsIExceptionManager exceptionManager)
		{
			_exceptionManager = exceptionManager;
		}

		public GeckoNativeException CurrentException
		{
			get { return GeckoNativeException.Create(_exceptionManager.GetCurrentException()); }
		}
	}
#endif

}
