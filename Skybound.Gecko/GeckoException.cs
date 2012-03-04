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
}