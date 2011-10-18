using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skybound.Gecko
{
	static class GeckoElementExtensions
	{
		/// <summary>
		/// Gets the value of the data-xxx attributes
		/// </summary>
		/// <param name="dataAttributeName">Microdata label in data-label attribute</param>
		/// <returns></returns>
		public static string GetData(this GeckoElement node, string dataAttributeName)
		{
			if (string.IsNullOrEmpty(dataAttributeName))
				throw new ArgumentException("attributeName");

			return node.GetAttribute("data-" + dataAttributeName);			
		} 
	}
}
