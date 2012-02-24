using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.Utils
{
	public sealed class VersionComparer
		:IComparer<string>
	{
		private nsIVersionComparator _versionComparator;

		public VersionComparer()
		{
			var versionComparator = Xpcom.GetService<nsIVersionComparator>(Contracts.VersionComparator);
			_versionComparator = Xpcom.QueryInterface<nsIVersionComparator>(versionComparator);
		}

		public int Compare( string x, string y )
		{
			return nsString.Pass( _versionComparator.Compare, x, y );
		}
	}
}
