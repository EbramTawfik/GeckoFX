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
// Generated by IDLImporter from file nsIFileStreams.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// An input stream that allows you to read from a file.
    /// </summary>
	[ComImport()]
	[Guid("e3d56a20-c7ec-11d3-8cda-0060b0fc14a3")]
	public interface nsIFileInputStream : nsIInputStream
	{
		
		/// <summary>
        /// @param file          file to read from (must QI to nsILocalFile)
        /// @param ioFlags       file open flags listed in prio.h (see
        /// PR_Open documentation) or -1 to open the
        /// file in default mode (PR_RDONLY).
        /// @param perm          file mode bits listed in prio.h or -1 to
        /// use the default value (0)
        /// @param behaviorFlags flags specifying various behaviors of the class
        /// (see enumerations in the class)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIFile file, int ioFlags, int perm, int behaviorFlags);
	}
	
	/// <summary>
    /// An output stream that lets you stream to a file.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e6f68040-c7ec-11d3-8cda-0060b0fc14a3")]
	public interface nsIFileOutputStream : nsIOutputStream
	{
		
		/// <summary>
        /// Close the stream. Forces the output stream to flush any buffered data.
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if unable to flush without blocking
        /// the calling thread (non-blocking mode only)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Close();
		
		/// <summary>
        /// Flush the stream.
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if unable to flush without blocking
        /// the calling thread (non-blocking mode only)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Flush();
		
		/// <summary>
        /// Write data into the stream.
        ///
        /// @param aBuf the buffer containing the data to be written
        /// @param aCount the maximum number of bytes to be written
        ///
        /// @return number of bytes written (may be less than aCount)
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if writing to the output stream would
        /// block the calling thread (non-blocking mode only)
        /// @throws <other-error> on failure
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint Write([MarshalAs(UnmanagedType.LPStr)] string aBuf, uint aCount);
		
		/// <summary>
        /// Writes data into the stream from an input stream.
        ///
        /// @param aFromStream the stream containing the data to be written
        /// @param aCount the maximum number of bytes to be written
        ///
        /// @return number of bytes written (may be less than aCount)
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if writing to the output stream would
        /// block the calling thread (non-blocking mode only)
        /// @throws <other-error> on failure
        ///
        /// NOTE: This method is defined by this interface in order to allow the
        /// output stream to efficiently copy the data from the input stream into
        /// its internal buffer (if any). If this method was provided as an external
        /// facility, a separate char* buffer would need to be used in order to call
        /// the output stream's other Write method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint WriteFrom([MarshalAs(UnmanagedType.Interface)] nsIInputStream aFromStream, uint aCount);
		
		/// <summary>
        /// Low-level write method that has access to the stream's underlying buffer.
        /// The reader function may be called multiple times for segmented buffers.
        /// WriteSegments is expected to keep calling the reader until either there
        /// is nothing left to write or the reader returns an error.  WriteSegments
        /// should not call the reader with zero bytes to provide.
        ///
        /// @param aReader the "provider" of the data to be written
        /// @param aClosure opaque parameter passed to reader
        /// @param aCount the maximum number of bytes to be written
        ///
        /// @return number of bytes written (may be less than aCount)
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if writing to the output stream would
        /// block the calling thread (non-blocking mode only)
        /// @throws NS_ERROR_NOT_IMPLEMENTED if the stream has no underlying buffer
        /// @throws <other-error> on failure
        ///
        /// NOTE: this function may be unimplemented if a stream has no underlying
        /// buffer (e.g., socket output stream).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint WriteSegments(System.IntPtr aReader, System.IntPtr aClosure, uint aCount);
		
		/// <summary>
        /// @return true if stream is non-blocking
        ///
        /// NOTE: writing to a blocking output stream will block the calling thread
        /// until all given data can be consumed by the stream.
        ///
        /// NOTE: a non-blocking output stream may implement nsIAsyncOutputStream to
        /// provide consumers with a way to wait for the stream to accept more data
        /// once its write method is unable to accept any data without blocking.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsNonBlocking();
		
		/// <summary>
        /// @param file          file to write to (must QI to nsILocalFile)
        /// @param ioFlags       file open flags listed in prio.h (see
        /// PR_Open documentation) or -1 to open the
        /// file in default mode (PR_WRONLY |
        /// PR_CREATE_FILE | PR_TRUNCATE)
        /// @param perm          file mode bits listed in prio.h or -1 to
        /// use the default permissions (0664)
        /// @param behaviorFlags flags specifying various behaviors of the class
        /// (currently none supported)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIFile file, int ioFlags, int perm, int behaviorFlags);
	}
	
	/// <summary>
    /// An input stream that allows you to read from a slice of a file.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3ce03a2f-97f7-4375-b6bb-1788a60cad3b")]
	public interface nsIPartialFileInputStream
	{
		
		/// <summary>
        /// Initialize with a file and new start/end positions. Both start and
        /// start+length must be smaller than the size of the file. Not doing so
        /// will lead to undefined behavior.
        /// You must initialize the stream, and only initialize it once, before it
        /// can be used.
        ///
        /// @param file          file to read from (must QI to nsILocalFile)
        /// @param start         start offset of slice to read. Must be smaller
        /// than the size of the file.
        /// @param length        length of slice to read. Must be small enough that
        /// start+length is smaller than the size of the file.
        /// @param ioFlags       file open flags listed in prio.h (see
        /// PR_Open documentation) or -1 to open the
        /// file in default mode (PR_RDONLY).
        /// @param perm          file mode bits listed in prio.h or -1 to
        /// use the default value (0)
        /// @param behaviorFlags flags specifying various behaviors of the class
        /// (see enumerations in nsIFileInputStream)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIFile file, ulong start, ulong length, int ioFlags, int perm, int behaviorFlags);
	}
}
