using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Certificates;
using Gecko.Net;

namespace Gecko.Interop
{
	/// <summary>
	/// Expiremental class
	/// </summary>
	internal static class WrapperManager
	{
		/// <summary>
		/// Gecko type to Function, that creates wrapper to GeckoObject
		/// </summary>
		private static Dictionary<Type, Delegate> _wrappers = new Dictionary<Type, Delegate>();

		/// <summary>
		/// Not strongly-typed version of wrappers
		/// </summary>
		private static Dictionary<Type, Func<object, object>> _notGenericWrappers =
			new Dictionary<Type, Func<object, object>>();

		/// <summary>
		/// Wrapper type to GeckoObject type dictionary
		/// </summary>
		private static Dictionary<Type, Type> _wrappersTypes2geckoObjectTypes = new Dictionary<Type, Type>();

		static WrapperManager()
		{
			RegisterWrapper( new Func<nsIX509Cert, Certificate>( Certificate.Create ) );
			RegisterWrapper( new Func<nsIX509Cert2, Certificate>( Certificate.Create ) );
			RegisterWrapper( new Func<nsIX509Cert3, Certificate>( Certificate.Create ) );
			RegisterWrapper( new Func<nsIRequest, Net.Request>( x => new Request( x ) ) );
			RegisterWrapper(new Func<nsIChannel, Net.Channel>(x => new Channel(x)));
			RegisterWrapper(new Func<nsIHttpChannel, Net.HttpChannel>(x => new HttpChannel(x)));
			RegisterWrapper(new Func<nsILoadGroup, Net.LoadGroup>(x => new LoadGroup(x)));
		}

		private static void RegisterWrapper<TWrapper, TGeckoObject>( Func<TGeckoObject, TWrapper> translator )
		{
			var geckoType = typeof (TGeckoObject);
			var wrapperType = typeof (TWrapper);
			_wrappers.Add( geckoType, translator );
			_wrappersTypes2geckoObjectTypes.Add( wrapperType, geckoType );
			_notGenericWrappers.Add( geckoType, x => ( translator( ( TGeckoObject ) x ) ) );
		}



		internal static TWrapper GetManagedWrapper<TWrapper>( this nsISupports proxy )
		{
			var geckoType = _wrappersTypes2geckoObjectTypes[ typeof (TWrapper) ];
			var iFace = proxy.QueryInterface( geckoType.GUID );
			var translator = _notGenericWrappers[ geckoType ];
			return ( TWrapper ) translator( iFace );
		}


		internal static TWrapper Wrap<TWrapper, TGeckoObject>( TGeckoObject obj )
		{
			var type = typeof (TGeckoObject);
			var translator = ( Func<TGeckoObject, TWrapper> ) _wrappers[ type ];
			return translator( obj );
		}
	}
}
