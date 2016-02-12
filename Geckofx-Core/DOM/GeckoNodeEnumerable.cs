using System.Collections.Generic;
using Gecko.Interop;

namespace Gecko
{
    /// <summary>
    /// Represents a collection of GeckoNode's
    /// </summary>
    internal class GeckoNodeEnumerable : IEnumerable<GeckoNode>
    {
        private readonly WebIDL.XPathResult _xpathResult;

        internal GeckoNodeEnumerable(WebIDL.XPathResult xpathResult)
        {
            _xpathResult = xpathResult;
        }

        #region IEnumerable<GeckoNode> Members

        public IEnumerator<GeckoNode> GetEnumerator()
        {
            while (!_xpathResult.InvalidIteratorState)
            {
                var result = _xpathResult.IterateNext().Wrap(GeckoNode.Create);
                if (result == null)
                    yield break;
                yield return result;
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            var i = GetEnumerator();
            while (i.MoveNext())
            {
                yield return i.Current;
            }
        }

        #endregion
    }
}