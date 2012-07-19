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
		/// <summary>
		/// Creates InstanceWrapper for xulrunner object with contract <paramref name="contractID"/>
		/// refcount of created object is 1, it will automatically decrement when InstanceWrapper is disposed
		/// </summary>
		/// <param name="contractID"></param>
		internal InstanceWrapper(string contractID)
		{
			Instance = Xpcom.CreateInstance<T>(contractID);
		}

		/// <summary>
		/// Creates InstanceWrapper for xulrunner object instance		
		/// refcount is not incremented
		/// After disposing of InstanceWrapper refcount of <paramref name="obj"/> is decremented by 1
		/// </summary>
		/// <param name="obj">Xulrunner object(interface)</param>		
		internal InstanceWrapper(T obj) : this(obj, false)
		{
			
		}

		/// <summary>
		/// Creates InstanceWrapper for xulrunner object instance
		/// If <paramref name="incrementReferenceCounter"/> is true refcount of <paramref name="obj"/> is incremented by 1
		/// If <paramref name="incrementReferenceCounter"/> is false refcount is not incremented
		/// After disposing of InstanceWrapper refcount of <paramref name="obj"/> is decremented by 1
		/// </summary>
		/// <param name="obj">Xulrunner object(interface)</param>
		/// <param name="incrementReferenceCounter">true to perform QueryInterface on object</param>
		internal InstanceWrapper(T obj,bool incrementReferenceCounter)
		{
			Instance = incrementReferenceCounter ? Xpcom.QueryInterface<T>(obj) : obj;
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