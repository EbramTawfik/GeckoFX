using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Gecko
{
	/// <summary>
	/// Class for fixing memory leaks :)
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public sealed class InstanceWrapper<T>
		:IDisposable,IEquatable<InstanceWrapper<T>>
		where T : class
	{
		private T _instance;

		#region ctor & dror
		/// <summary>
		/// Creates InstanceWrapper for xulrunner object with contract <paramref name="contractID"/>
		/// refcount of created object is 1, it will automatically decrement when InstanceWrapper is disposed
		/// </summary>
		/// <param name="contractID"></param>
		public InstanceWrapper(string contractID)
		{
			_instance = Xpcom.CreateInstance<T>(contractID);
		}

		public T Instance
		{
			get { return _instance; }
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
			_instance = incrementReferenceCounter ? Xpcom.QueryInterface<T>(obj) : obj;
		}

		~InstanceWrapper()
		{
			Xpcom.FreeComObject(ref _instance);
		}

		public void Dispose()
		{
			Xpcom.FreeComObject(ref _instance);
			GC.SuppressFinalize(this);
		}
		#endregion

		/// <summary>
		/// Finaly releases Xulrunner COM object
		/// Decrepment COM reference counter into zero
		/// </summary>
		public void FinalRelease()
		{
			Xpcom.FinalFreeComObject(ref _instance);
		}

		public bool Equals(InstanceWrapper<T> other)
		{
			if (ReferenceEquals(this, other)) return true;
			if (ReferenceEquals(null, other)) return false;
			return _instance.GetHashCode() == other._instance.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj)) return true;
			if (ReferenceEquals(null, obj)) return false;
			if (!(obj is InstanceWrapper<T>)) return false;
			return _instance.GetHashCode() == ((InstanceWrapper<T>)obj)._instance.GetHashCode();
		}

		public override int GetHashCode()
		{
			return _instance != null ? _instance.GetHashCode() : 0;
		}
	}
}