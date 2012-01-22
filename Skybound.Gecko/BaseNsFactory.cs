using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko
{
	public class BaseNsFactory<TFactory>
		where TFactory:nsIFactory, new()
	{
		// If you are using resharper it will generate warning because
		// BaseNsFactory<T1>._isRegistered and BaseNsFactory<T2>._isRegistered are different fields
		// but for us this is good :)
// ReSharper disable StaticFieldInGenericType
		private static bool _isRegistered;
		private static string _contractID;
// ReSharper restore StaticFieldInGenericType

		public static void Register()
		{
			if (_isRegistered) return;

			var factoryType = typeof (TFactory);
			var attributes = factoryType.GetCustomAttributes( typeof (ContractIDAttribute), true );
			if (attributes.Length > 0)
			{
				ContractIDAttribute attribute = (ContractIDAttribute)attributes[ 0 ];
				_contractID = attribute.ContractID;
				Xpcom.RegisterFactory(
					factoryType.GUID,
					factoryType.FullName,
					_contractID,
					new TFactory() );
				_isRegistered = true;
			}
		}

		/// <summary>
		/// Returns ContractID if registered or null if not registered.
		/// </summary>
		/// <returns></returns>
		public string GetContractID()
		{
			return _contractID;
		}
	}

	public sealed class ContractIDAttribute
		:Attribute
	{
		public readonly string ContractID;

		public ContractIDAttribute(string contractID)
		{
			ContractID = contractID;
		}
	}

	public class GenericOneClassNsFactory<TFactory,TType>
		: BaseNsFactory<TFactory>,nsIFactory
		where TFactory:nsIFactory, new()
		where TType:new()
	{

		protected virtual IntPtr Create( nsISupports aOuter, ref Guid iid )
		{
			IntPtr result = IntPtr.Zero;
			IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(new TType());
			Marshal.QueryInterface(iUnknownForObject, ref iid, out result);
			Marshal.Release(iUnknownForObject);
			return result;
		}

		public IntPtr CreateInstance( nsISupports aOuter, ref Guid iid )
		{
			return Create( aOuter, ref iid );
		}

		public void LockFactory( bool @lock )
		{

		}
	}

}
