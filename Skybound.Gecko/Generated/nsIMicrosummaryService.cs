// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIMicrosummaryService.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIMicrosummaryObserver </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("560b0980-be95-47e9-81cc-4428c073127c")]
	public interface nsIMicrosummaryObserver
	{
		
		/// <summary>
        /// Called when an observed microsummary updates its content.
        /// Since an observer might watch multiple microsummaries at the same time,
        /// the microsummary whose content has been updated gets passed
        /// to this handler.
        /// XXX Should this be onContentUpdated?
        ///
        /// @param microsummary
        /// the microsummary whose content has just been updated
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnContentLoaded([MarshalAs(UnmanagedType.Interface)] nsIMicrosummary  microsummary);
		
		/// <summary>
        /// Called when an observed microsummary encounters an error during an update.
        ///
        /// @param microsummary
        /// the microsummary which could not be updated
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnError([MarshalAs(UnmanagedType.Interface)] nsIMicrosummary  microsummary);
		
		/// <summary>
        /// Called when an element is appended to a microsummary set.
        /// XXX Should this be in a separate nsICollectionObserver interface?
        ///
        /// @param microsummary
        /// the microsummary that has just been appended to the set
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnElementAppended([MarshalAs(UnmanagedType.Interface)] nsIMicrosummary  microsummary);
	}
	
	/// <summary>nsIMicrosummaryGenerator </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("05b48344-d0a7-427e-934e-9a6e0d5ecced")]
	public interface nsIMicrosummaryGenerator
	{
		
		/// <summary>
        /// Has the generator itself, which may be a remote resource, been loaded.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetLoadedAttribute();
		
		/// <summary>
        /// An arbitrary descriptive name for this microsummary generator.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aName);
		
		/// <summary>
        /// of the generators they create.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI  GetUriAttribute();
		
		/// <summary>
        /// microsummary-generator equivalence test
        /// generators equal if their canonical locations equal, see uri attribute.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals([MarshalAs(UnmanagedType.Interface)] nsIMicrosummaryGenerator  aOther);
		
		/// <summary>
        /// generator's XML.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI  GetLocalURIAttribute();
		
		/// <summary>
        /// do not.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetNeedsPageContentAttribute();
		
		/// <summary>
        /// Generate a microsummary by processing the generator template
        /// against the page content.  If a generator doesn't need content,
        /// pass null as the parameter to this method.
        ///
        /// XXX In the future, this should support returning rich text content,
        /// so perhaps we should make it return a DOM node now and have the caller
        /// convert that to text if it doesn't support rich content.
        ///
        /// @param   pageContent
        /// the content of the page being summarized
        /// @returns the text result of processing the template
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GenerateMicrosummary([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  aPageContent);
		
		/// <summary>
        /// Calculate the interval until the microsummary should be updated for
        /// the next time, depending on the page content. If the generator doesn't
        /// specify an interval, null is returned.
        ///
        /// @param   pageContent
        /// the content of the page being summarized
        /// @returns the interval in milliseconds until the next update request
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int CalculateUpdateInterval([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  aPageContent);
	}
	
	/// <summary>nsIMicrosummary </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6867dc21-077f-4462-937d-cd8b7c680e0c")]
	public interface nsIMicrosummary
	{
		
		/// <summary>
        /// the URI of the page being summarized
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI  GetPageURIAttribute();
		
		/// <summary>
        /// The generator that generates this microsummary. May need to be loaded.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIMicrosummaryGenerator  GetGeneratorAttribute();
		
		/// <summary>
        /// The generator that generates this microsummary. May need to be loaded.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetGeneratorAttribute([MarshalAs(UnmanagedType.Interface)] nsIMicrosummaryGenerator  aGenerator);
		
		/// <summary>
        /// to generate the content, this may not always be available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aContent);
		
		/// <summary>
        /// (or null if it doesn't care).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetUpdateIntervalAttribute();
		
		/// <summary>
        /// associated generator) will no longer be available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetNeedsRemovalAttribute();
		
		/// <summary>
        /// Add a microsummary observer to this microsummary.
        ///
        /// @param observer
        /// the microsummary observer to add
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIMicrosummaryObserver  observer);
		
		/// <summary>
        /// Remove a microsummary observer from this microsummary.
        ///
        /// @param observer
        /// the microsummary observer to remove
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIMicrosummaryObserver  observer);
		
		/// <summary>
        /// Microsummary equivalence test
        /// Microsummaries equal if they summarize the same page with the same
        /// microsummary-generator (see also nsIMicrosummaryGenerator::equals).
        ///
        /// Note: this method returns false if either objects don't have a generator
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals([MarshalAs(UnmanagedType.Interface)] nsIMicrosummary  aOther);
		
		/// <summary>
        /// Update the microsummary, first loading its generator and page content
        /// as necessary.  If you want know when a microsummary finishes updating,
        /// add an observer before calling this method.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Update();
	}
	
	/// <summary>nsIMicrosummarySet </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7111e88d-fecd-4b17-b7a9-1fa74e23153f")]
	public interface nsIMicrosummarySet
	{
		
		/// <summary>
        /// Add a microsummary observer to this microsummary set.  Adding an observer
        /// to a set is the equivalent of adding it to each constituent microsummary.
        ///
        /// @param observer
        /// the microsummary observer to add
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIMicrosummaryObserver  observer);
		
		/// <summary>
        /// Remove a microsummary observer from this microsummary.
        ///
        /// @param observer
        /// the microsummary observer to remove
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIMicrosummaryObserver  observer);
		
		/// <summary>
        /// Retrieve a enumerator of microsummaries in the set.
        ///
        /// @returns an enumerator of nsIMicrosummary objects
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator Enumerate();
	}
	
	/// <summary>nsIMicrosummaryService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("D58143A2-74FA-4B13-94ED-113AF8936D80")]
	public interface nsIMicrosummaryService
	{
		
		/// <summary>
        /// Return a microsummary generator for the given URI.
        ///
        /// @param   generatorURI
        /// the URI of the generator
        ///
        /// @returns an nsIMicrosummaryGenerator for the given URI.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIMicrosummaryGenerator GetGenerator([MarshalAs(UnmanagedType.Interface)] nsIURI  generatorURI);
		
		/// <summary>
        /// Install the microsummary generator from the resource at the supplied URI.
        /// Callable by content via the addMicrosummaryGenerator() sidebar method.
        ///
        /// @param   generatorURI
        /// the URI of the resource providing the generator
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddGenerator([MarshalAs(UnmanagedType.Interface)] nsIURI  generatorURI);
		
		/// <summary>
        /// Install the microsummary generator in the given XML definition.
        ///
        /// @param   xmlDefinition
        /// an nsIDOMDocument XML document defining the generator
        ///
        /// @returns the newly-installed nsIMicrosummaryGenerator object
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIMicrosummaryGenerator InstallGenerator([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument  xmlDefinition);
		
		/// <summary>
        /// Get the set of bookmarks with microsummaries.
        ///
        /// In the old RDF-based bookmarks datastore, bookmark IDs are nsIRDFResource
        /// objects.  In the new Places-based datastore, they are nsIURI objects.
        ///
        /// @returns an nsISimpleEnumerator enumeration of bookmark IDs
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetBookmarks();
		
		/// <summary>
        /// Get the set of microsummaries available for a given page.  The set
        /// might change after this method returns, since this method will trigger
        /// an asynchronous load of the page in question (if it isn't already loaded)
        /// to see if it references any page-specific microsummaries.
        ///
        /// If the caller passes a bookmark ID, and one of the microsummaries
        /// is the current one for the bookmark, this method will retrieve content
        /// from the datastore for that microsummary, which is useful when callers
        /// want to display a list of microsummaries for a page that isn't loaded,
        /// and they want to display the actual content of the selected microsummary
        /// immediately (rather than after the content is asynchronously loaded).
        ///
        /// @param   pageURI
        /// the URI of the page for which to retrieve available microsummaries
        ///
        /// @param   bookmarkID (optional)
        /// the ID of the bookmark for which this method is being called
        ///
        /// @returns an nsIMicrosummarySet of nsIMicrosummaries for the given page
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIMicrosummarySet GetMicrosummaries([MarshalAs(UnmanagedType.Interface)] nsIURI  pageURI, System.Int32  bookmarkID);
		
		/// <summary>
        /// Get the current microsummary for the given bookmark.
        ///
        /// @param   bookmarkID
        /// the bookmark for which to get the current microsummary
        ///
        /// @returns the current microsummary for the bookmark, or null
        /// if the bookmark does not have a current microsummary
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIMicrosummary GetMicrosummary(System.Int32  bookmarkID);
		
		/// <summary>
        /// Create a microsummary for a given page URI and generator URI.
        ///
        /// @param   pageURI
        /// the URI of the page to be summarized
        ///
        /// @param   generatorURI
        /// the URI of the microsummary generator
        ///
        /// @returns an nsIMicrosummary for the given page and generator URIs.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIMicrosummary CreateMicrosummary([MarshalAs(UnmanagedType.Interface)] nsIURI  pageURI, [MarshalAs(UnmanagedType.Interface)] nsIURI  generatorURI);
		
		/// <summary>
        /// Set the current microsummary for the given bookmark.
        ///
        /// @param   bookmarkID
        /// the bookmark for which to set the current microsummary
        ///
        /// @param   microsummary
        /// the microsummary to set as the current one
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMicrosummary(System.Int32  bookmarkID, [MarshalAs(UnmanagedType.Interface)] nsIMicrosummary  microsummary);
		
		/// <summary>
        /// Remove the current microsummary for the given bookmark.
        ///
        /// @param   bookmarkID
        /// the bookmark for which to remove the current microsummary
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveMicrosummary(System.Int32  bookmarkID);
		
		/// <summary>
        /// Whether or not the given bookmark has a current microsummary.
        ///
        /// @param   bookmarkID
        /// the bookmark for which to set the current microsummary
        ///
        /// @returns a boolean representing whether or not the given bookmark
        /// has a current microsummary
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasMicrosummary(System.Int32  bookmarkID);
		
		/// <summary>
        /// Whether or not the given microsummary is the current microsummary
        /// for the given bookmark.
        ///
        /// @param   bookmarkID
        /// the bookmark to check
        ///
        /// @param   microsummary
        /// the microsummary to check
        ///
        /// @returns whether or not the microsummary is the current one
        /// for the bookmark
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsMicrosummary(System.Int32  bookmarkID, [MarshalAs(UnmanagedType.Interface)] nsIMicrosummary  microsummary);
		
		/// <summary>
        /// Refresh a microsummary, updating its value in the datastore and UI.
        /// If this method can refresh the microsummary instantly, it will.
        /// Otherwise, it'll asynchronously download the necessary information
        /// (the generator and/or page) before refreshing the microsummary.
        ///
        /// Callers should check the "content" property of the returned microsummary
        /// object to distinguish between sync and async refreshes.  If its value
        /// is "null", then it's an async refresh, and the caller should register
        /// itself as an nsIMicrosummaryObserver via nsIMicrosummary.addObserver()
        /// to find out when the refresh completes.
        ///
        /// @param   bookmarkID
        /// the bookmark whose microsummary is being refreshed
        ///
        /// @returns the microsummary being refreshed
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIMicrosummary RefreshMicrosummary(System.Int32  bookmarkID);
	}
	
	/// <summary>nsILiveTitleNotificationSubject </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f9e577a8-19d9-4ca0-a140-b9e43f014470")]
	public interface nsILiveTitleNotificationSubject
	{
		
		/// <summary>
        /// become an integer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetBookmarkIDAttribute();
		
		/// <summary>
        /// to the user) is stored in the content property of this object.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIMicrosummary  GetMicrosummaryAttribute();
	}
}
