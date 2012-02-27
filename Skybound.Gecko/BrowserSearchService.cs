using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko
{
	public sealed class BrowserSearchService
	{
		private nsIBrowserSearchService _browserSearchService;

		public BrowserSearchService()
		{
			var browserSearchService = Xpcom.GetService<nsIBrowserSearchService>(Contracts.BrowserSearchService);
			_browserSearchService = Xpcom.QueryInterface<nsIBrowserSearchService>(browserSearchService);
		}


		/// <summary>
		/// Adds a new search engine from the file at the supplied URI, optionally
		/// asking the user for confirmation first.  If a confirmation dialog is
		/// shown, it will offer the option to begin using the newly added engine
		/// right away; if no confirmation dialog is shown, the new engine will be
		/// used right away automatically.
		///
		/// @param engineURL
		/// The URL to the search engine's description file.
		///
		/// @param dataType
		/// An integer representing the plugin file format. Must be one
		/// of the supported search engine data types defined above.
		///
		/// @param iconURL
		/// A URL string to an icon file to be used as the search engine's
		/// icon. This value may be overridden by an icon specified in the
		/// engine description file.
		///
		/// @param confirm
		/// A boolean value indicating whether the user should be asked for
		/// confirmation before this engine is added to the list.  If this
		/// value is false, the engine will be added to the list upon successful
		/// load, but it will not be selected as the current engine.
		///
		/// @throws NS_ERROR_FAILURE if the type is invalid, or if the description
		/// file cannot be successfully loaded.
		/// </summary>
		public void AddEngine( string engineUrl, int dataType, string iconUrl,  bool confirm)
		{
			using (nsAString native1=new nsAString(engineUrl),native2=new nsAString(iconUrl))
			{
				_browserSearchService.AddEngine( native1, dataType, native2, confirm );
			}
		}

		/// <summary>
		/// Adds a new search engine, without asking the user for confirmation and
		/// without starting to use it right away.
		///
		/// @param name
		/// The search engine's name. Must be unique. Must not be null.
		///
		/// @param iconURL
		/// Optional: A URL string pointing to the icon to be used to represent
		/// the engine.
		///
		/// @param alias
		/// Optional: A unique shortcut that can be used to retrieve the
		/// search engine.
		///
		/// @param description
		/// Optional: a description of the search engine.
		///
		/// @param method
		/// The HTTP request method used when submitting a search query.
		/// Must be a case insensitive value of either "get" or "post".
		///
		/// @param url
		/// The URL to which search queries should be sent.
		/// Must not be null.
		/// </summary>
		public void AddEngineWithDetails(string name,  string iconURL, string alias, string description, string method, string url)
		{
			using (nsAString native1 = new nsAString(name),
				native2 = new nsAString(iconURL),
				native3 = new nsAString(alias),
				native4 = new nsAString(description),
				native5 = new nsAString(method),
				native6=new nsAString(url))
			{
				_browserSearchService.AddEngineWithDetails( native1, native2, native3, native4, native5, native6 );
			}
		}

		/// <summary>
		/// Un-hides all engines installed in the directory corresponding to
		/// the directory service's NS_APP_SEARCH_DIR key. (i.e. the set of
		/// engines returned by getDefaultEngines)
		/// </summary>
		public void RestoreDefaultEngines()
		{
			_browserSearchService.RestoreDefaultEngines();
		}

		/// <summary>
		/// Returns an engine with the specified alias.
		/// </summary>
		/// <param name="alias">The search engine's alias.</param>
		/// <returns>The corresponding SearchEngine object, or null if it doesn't exist.</returns>
		public SearchEngine GetEngineByAlias( string alias)
		{
			var ret = nsString.Pass( _browserSearchService.GetEngineByAlias, alias );
			return SearchEngine.Create(ret);
		}

		/// <summary>
		/// Returns an engine with the specified name.
		/// </summary>
		/// <param name="engineName">The name of the engine.</param>
		/// <returns>The corresponding SearchEngine object, or null if it doesn't exist.</returns>
		public SearchEngine GetEngineByName(string engineName)
		{
			var ret = nsString.Pass(_browserSearchService.GetEngineByName, engineName);
			return SearchEngine.Create( ret );
		}

		/// <summary>
		/// Returns an array of all installed search engines.
		///
		/// @returns an array of nsISearchEngine objects.
		/// </summary>
	
		//void GetEngines(ref uint engineCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref nsISearchEngine[] engines);

		/// <summary>
		/// Returns an array of all installed search engines whose hidden attribute is
		/// false.
		///
		/// @returns an array of nsISearchEngine objects.
		/// </summary>
		
		//void GetVisibleEngines(ref uint engineCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref nsISearchEngine[] engines);

		/// <summary>
		/// Returns an array of all default search engines. This includes all loaded
		/// engines that aren't in the user's profile directory
		/// (NS_APP_USER_SEARCH_DIR).
		///
		/// @returns an array of nsISearchEngine objects.
		/// </summary>
		
		//void GetDefaultEngines(ref uint engineCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref nsISearchEngine[] engines);

		/// <summary>
		/// Moves a visible search engine.
		///
		/// @param  engine
		/// The engine to move.
		/// @param  newIndex
		/// The engine's new index in the set of visible engines.
		///
		/// @throws NS_ERROR_FAILURE if newIndex is out of bounds, or if engine is
		/// hidden.
		/// </summary>
		public void MoveEngine(SearchEngine engine, int newIndex)
		{
			_browserSearchService.MoveEngine( engine._searchEngine, newIndex );
		}

		/// <summary>
		/// Removes the search engine. If the search engine is installed in a global
		/// location, this will just hide the engine. If the engine is in the user's
		/// profile directory, it will be removed from disk.
		///
		/// @param  engine
		/// The engine to remove.
		/// </summary>
		public void RemoveEngine(SearchEngine engine)
		{
			_browserSearchService.RemoveEngine( engine._searchEngine );
		}

		/// <summary>
		/// The default search engine. Returns the first visible engine if the default
		/// engine is hidden. May be null if there are no visible search engines.
		/// </summary>

		public SearchEngine DefaultEngine
		{
			get { return SearchEngine.Create( _browserSearchService.GetDefaultEngineAttribute() ); }
		}

		/// <summary>
		/// The currently active search engine. May be null if there are no visible
		/// search engines.
		/// </summary>
		public SearchEngine CurrentEngine
		{
			get { return SearchEngine.Create( _browserSearchService.GetCurrentEngineAttribute() ); }
			set { _browserSearchService.SetCurrentEngineAttribute( value._searchEngine ); }
		}

		/// <summary>
		/// The original default engine. This differs from the "defaultEngine"
		/// attribute in that it always returns a given build's default engine,
		/// regardless of whether it is hidden.
		/// </summary>
		public SearchEngine OriginalDefaultEngine
		{
			get { return SearchEngine.Create( _browserSearchService.GetOriginalDefaultEngineAttribute() ); }
		}
	}


	public sealed class SearchEngine
	{
		internal nsISearchEngine _searchEngine;

		private SearchEngine(nsISearchEngine searchEngine)
		{
			_searchEngine = searchEngine;
			
		}

		public void AddParam(string name,string value,string responceType)
		{
			nsString.Set( _searchEngine.AddParam, name, value, responceType );

		}

		public string Alias
		{
			get { return nsString.Get( _searchEngine.GetAliasAttribute ); }
			set { nsString.Set( _searchEngine.SetAliasAttribute, value ); }
		}

		public string Description
		{
			get { return nsString.Get( _searchEngine.GetDescriptionAttribute ); }
		}

		internal static SearchEngine Create(nsISearchEngine searchEngine)
		{
			return searchEngine == null ? null : new SearchEngine( searchEngine );
		}
	}
}
