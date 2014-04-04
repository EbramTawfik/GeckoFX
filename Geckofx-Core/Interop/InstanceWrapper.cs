using System;
using System.Runtime.InteropServices;
using System.Threading;
using Gecko.Interop;

namespace Gecko
{
	/// <summary>
	/// Class for fixing memory leaks :)
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public sealed class InstanceWrapper<T>
		: ComPtr<T>
		where T : class
	{

		#region ctor & dror
		/// <summary>
		/// Creates InstanceWrapper for xulrunner object with contract <paramref name="contractID"/>
		/// refcount of created object is 1, it will automatically decrement when InstanceWrapper is disposed
		/// </summary>
		/// <param name="contractID"></param>
		public InstanceWrapper(string contractID)
			:base(Xpcom.CreateInstance<T>(contractID))
		{
		}

		/// <summary>
		/// Creates InstanceWrapper for xulrunner object instance		
		/// refcount is not incremented
		/// After disposing of InstanceWrapper refcount of <paramref name="obj"/> is decremented by 1
		/// </summary>
		/// <param name="obj">Xulrunner object(interface)</param>		
		internal InstanceWrapper(T obj)
			: this(obj, false)
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
			:base(incrementReferenceCounter ? Xpcom.QueryInterface<T>(obj) : obj)
		{
		}
		#endregion
	}
}