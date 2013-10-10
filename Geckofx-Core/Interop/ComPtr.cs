using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace Gecko.Interop
{
	/// <summary>
	/// COM pointer wrapper
	/// SHOULD be used for temporal variables
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class ComPtr<T>
		: IDisposable, IEquatable<ComPtr<T>>,IEquatable<T>
		where T:class
	{
		protected T _instance;

		#region ctor & dtor

		public ComPtr( T instance )
		{
			_instance = instance;
		}

		~ComPtr()
		{
			Free();
		}

		public void Dispose()
		{
			Free();
			GC.SuppressFinalize(this);
		}

		private void Free()
		{
			Xpcom.FreeComObject( ref _instance );
		}
		#endregion

		/// <summary>
		/// Finally releases COM object
		/// Decrement COM reference counter into zero
		/// </summary>
		public void FinalRelease()
		{
			Xpcom.FinalFreeComObject(ref _instance);
		}

		public T Instance
		{
			get { return _instance; }
		}

		#region Equality
		public bool Equals(ComPtr<T> other)
		{
			if (ReferenceEquals(this, other)) return true;
			if (ReferenceEquals(null, other)) return false;
			return _instance.GetHashCode() == other._instance.GetHashCode();
		}

		public bool Equals( T other )
		{
			if (ReferenceEquals(null, other)) return false;
			return _instance.GetHashCode() == other.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj)) return true;
			if (ReferenceEquals(null, obj)) return false;
			if (!(obj is ComPtr<T>)) return false;
			return _instance.GetHashCode() == ((ComPtr<T>)obj)._instance.GetHashCode();
		}

		public override int GetHashCode()
		{
			return _instance.GetHashCode();
		}



		#endregion

		/// <summary>
		/// Method for getting specific function in com object
		/// </summary>
		/// <typeparam name="U"></typeparam>
		/// <param name="slot"></param>
		/// <param name="method"></param>
		/// <returns></returns>
		public bool GetComMethod<U>(int slot, out Delegate method)
			where U : class
		{
			
			IntPtr comInterfaceForObject = Marshal.GetComInterfaceForObject(_instance, typeof(T));
			if (comInterfaceForObject == IntPtr.Zero)
			{
				method = null;
				return false;
			}
			bool flag = false;
			try
			{
				IntPtr ptr = Marshal.ReadIntPtr(Marshal.ReadIntPtr(comInterfaceForObject, 0), slot * IntPtr.Size);
				method = Marshal.GetDelegateForFunctionPointer(ptr, typeof(U));
				flag = true;
			}
			finally
			{
				Marshal.Release(comInterfaceForObject);
			}
			return flag;
		}

	}
}
