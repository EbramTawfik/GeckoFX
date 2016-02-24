using System;
using Gecko.Net;

namespace Gecko.Events
{
    /// <summary>Provides data for event.</summary>
    public class GeckoRetargetedEventArgs
        : EventArgs
    {
        public readonly Uri Uri;
        public readonly GeckoWindow DomWindow;
        public readonly Request Request;

        public bool DomWindowTopLevel
        {
            get { return DomWindow.IsTopWindow(); }
        }

        /// <summary>Creates a new instance of a <see cref="GeckoRetargetedEventArgs"/> object.</summary>
        /// <param name="uri"></param>
        public GeckoRetargetedEventArgs(Uri uri, GeckoWindow domWind, Request req)
        {
            Uri = uri;
            DomWindow = domWind;
            Request = req;
        }
    }
}