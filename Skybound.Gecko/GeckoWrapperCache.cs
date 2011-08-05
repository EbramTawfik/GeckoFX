using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skybound.Gecko
{
	/// <summary>
	/// To disable all Caching of GeckoWrapper, 
	/// include the include the following statement in your application: GeckoWrapperCache.Enabled = false;
	/// </summary>
	public static class GeckoWrapperCache
	{
		static public bool Enabled = true;
	}

	/// <summary>
	/// Cache WeakReference cache that maps from InterfaceType to WrapperType
	/// User must supply a delegate to allow receation of any GC wrappers.
	/// </summary>
	/// <typeparam name="InterfaceType"></typeparam>
	/// <typeparam name="WrapperType"></typeparam>
	internal class GeckoWrapperCache<InterfaceType, WrapperType>
	{
		public delegate WrapperType CreateWrapper(InterfaceType instance);

		private readonly Dictionary<InterfaceType, WeakReference> m_cache = new Dictionary<InterfaceType, WeakReference>();
		private readonly CreateWrapper m_creator;	

		public GeckoWrapperCache(CreateWrapper creator)
		{
			m_creator = creator;
		}

		public WrapperType Get(InterfaceType instance)
		{
			if (instance == null)
				return default(WrapperType);

			if (!GeckoWrapperCache.Enabled)
				return m_creator(instance);

			WeakReference wrapper;
			if (m_cache.TryGetValue(instance, out wrapper))
			{
				object geckoElement = wrapper.Target;
				if (geckoElement != null)
					return (WrapperType)geckoElement;
			}

			WrapperType ret = m_creator(instance);
			m_cache[instance] = new WeakReference(ret);
			return ret;
		}
	}
}
