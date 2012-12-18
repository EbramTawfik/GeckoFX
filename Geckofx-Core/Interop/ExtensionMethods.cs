using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.Interop
{
	public static class ExtensionMethods
	{
		/// <summary>
		/// Function that check if object is null -> then call wrapper creator
		/// </summary>
		/// <typeparam name="TGeckoObject"></typeparam>
		/// <typeparam name="TWrapper"></typeparam>
		/// <param name="obj"></param>
		/// <param name="wrapper"></param>
		/// <returns></returns>
		public static TWrapper Wrap<TGeckoObject, TWrapper>( this TGeckoObject obj, Func<TGeckoObject, TWrapper> wrapper )
			where TGeckoObject : class
			where TWrapper : class
		{
			return obj == null ? null : wrapper( obj );
		}
	}
}
