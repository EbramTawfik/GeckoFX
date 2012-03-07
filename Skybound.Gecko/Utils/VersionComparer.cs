using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.Utils
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class VersionComparer
		:IComparer<string>
	{
		/// <summary>
		/// Internal service reference MUST BE sigleton
		/// </summary>
		private static ServiceWrapper<nsIVersionComparator> _versionComparator;

		static VersionComparer()
		{
			_versionComparator = new ServiceWrapper<nsIVersionComparator>(Contracts.VersionComparator);
		}

		public VersionComparer() {}

		public int Compare(string x, string y)
		{
			return nsString.Pass<int>( _versionComparator.Instance.Compare, x, y );
		}
	}
}
