using System;

namespace Gecko
{
	public class GeckoException
		:ApplicationException
	{
		internal GeckoException()
			:base()
		{
			
		}

		internal GeckoException(string message)
			:base(message)
		{
			
		}

		internal GeckoException(string message,Exception innerException)
			:base(message,innerException)
		{
			
		}
	}

	public sealed class GeckoNativeException
		:GeckoException
	{
		private nsIException _exception;

		private GeckoNativeException(nsIException exception)
			:base(exception.GetMessageAttribute())
		{
			_exception = exception;

			
		}

		public string Name
		{
			get { return _exception.GetNameAttribute(); }
		}


		public GeckoNativeException Inner
		{
			get { return Create(_exception.GetInnerAttribute()); }
		}

		internal static GeckoNativeException Create(nsIException exception)
		{
			return exception == null ? null : new GeckoNativeException( exception );
		}
	}
}