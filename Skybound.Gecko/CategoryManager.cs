using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Collections;

namespace Gecko
{
	public sealed class CategoryManager
	{
		private nsICategoryManager _categoryManager;

		public CategoryManager()
		{
			var categoryManager = Xpcom.GetService<nsICategoryManager>("@mozilla.org/categorymanager;1");
			_categoryManager = Xpcom.QueryInterface<nsICategoryManager>(categoryManager);

			
		}

		public string AddCategoryEntry(string aCategory, string aEntry, string aValue, bool aPersist, bool aReplace)
		{
			// check if it exists to prevent crash
			string value = null;
			try
			{
				value = _categoryManager.GetCategoryEntry(aCategory, aEntry);
			}
			catch ( Exception )
			{
			}
			
			if (value != null)
			{
				_categoryManager.DeleteCategoryEntry(aCategory, aEntry, aPersist);
			}

			return _categoryManager.AddCategoryEntry(aCategory, aEntry, aValue, aPersist, aReplace);
		}

		public void DeleteCategory(string aCategory)
		{
			_categoryManager.DeleteCategory(aCategory);
			
			
		}

		public void DeleteCategoryEntry(string aCategory, string aEntry,bool aPersist) 
		{
			_categoryManager.DeleteCategoryEntry(aCategory, aEntry, aPersist);
		}

		public string GetCategoryEntry(string aCategory, string aEntry)
		{
			return _categoryManager.GetCategoryEntry( aCategory, aEntry );
		}

		public IEnumerable<nsCString> Categories
		{
			get
			{
				return new GeckoEnumerableCollection<nsCString, nsISupportsCString>(() => _categoryManager.EnumerateCategories(),
																				   x => new nsCString(x));
			}
		}

		public IEnumerable<nsCString> this[string category]
		{
			get
			{
				return new GeckoEnumerableCollection<nsCString, nsISupportsCString>(() => _categoryManager.EnumerateCategory(category),
																				   x => new nsCString(x));
			}
		}

		#region Categories List - TODO
		public static string ContentPolicy = "content-policy";
		#endregion
		
	}
}
