using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Gecko
{
	internal sealed class InstanceWrapper<T>
		:IDisposable,IEquatable<InstanceWrapper<T>>
		where T : class
	{
		internal T Instance;

		#region ctor & dror
		internal InstanceWrapper(string contractID)
		{
			Instance = Xpcom.CreateInstance<T>(contractID);
		}

		~InstanceWrapper()
		{
			FreeInstanceReference();
		}

		public void Dispose()
		{
			FreeInstanceReference();
			GC.SuppressFinalize(this);
		}
		#endregion

		private void FreeInstanceReference()
		{
			if (Instance == null) return;
			var obj = Interlocked.Exchange(ref Instance, null);
			Marshal.ReleaseComObject( obj );
		}

		/// <summary>
		/// Finaly releases Xulrunner COM object
		/// Decrepment COM reference counter into zero
		/// </summary>
		public void FinalRelease()
		{
			if (Instance == null) return;
			var obj = Interlocked.Exchange(ref Instance, null);
			Marshal.FinalReleaseComObject(obj);
		}

		public bool Equals(InstanceWrapper<T> other)
		{
			if (ReferenceEquals(this, other)) return true;
			if (ReferenceEquals(null, other)) return false;
			return Instance.GetHashCode() == other.Instance.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj)) return true;
			if (ReferenceEquals(null, obj)) return false;
			if (!(obj is InstanceWrapper<T>)) return false;
			return Instance.GetHashCode() == ( ( InstanceWrapper<T> ) obj ).Instance.GetHashCode();
		}

		public override int GetHashCode()
		{
			return Instance != null ? Instance.GetHashCode() : 0;
		}
	}
}