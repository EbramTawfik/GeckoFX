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
			if (String.IsNullOrEmpty(dataAttributeName) || dataAttributeName.Trim().Length == 0)
				throw new ArgumentException("dataAttributeName");
			
			if (node.Attributes["data-" + dataAttributeName] == null)
				return string.Empty;
			
			return node.Attributes["data-" + dataAttributeName].TextContent;			
		} 
	}
}
