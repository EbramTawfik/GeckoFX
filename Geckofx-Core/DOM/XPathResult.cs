using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.DOM {
    public class XPathResult {

        public enum ResultType {
            ANY_TYPE = 0,
            STRING_TYPE = 2,
            BOOLEAN_TYPE = 3,
            UNORDERED_NODE_ITERATOR_TYPE = 4,
            ORDERED_NODE_ITERATOR_TYPE = 5,
            UNORDERED_NODE_SNAPSHOT_TYPE = 6,
            ORDERED_NODE_SNAPSHOT_TYPE = 7,
            ANY_UNORDERED_NODE_TYPE = 8,
            FIRST_ORDERED_NODE_TYPE = 9,
        }

        private nsIDOMXPathResult xpathResult = null;

        internal XPathResult(nsIDOMXPathResult xpathResult) {
            this.xpathResult = xpathResult;
        }

        public ResultType GetResultType() {
            return (ResultType)xpathResult.GetResultTypeAttribute();
        }

        public double GetNumberValue() {
            return xpathResult.GetNumberValueAttribute();
        }

        public string GetStringValue() {
            using (var str = new nsAString()) {
                xpathResult.GetStringValueAttribute(str);
                return str.ToString();
            }
        }

        public bool GetBooleanValue() {
            return xpathResult.GetBooleanValueAttribute();
        }

        public GeckoNode GetSingleNodeValue() {
            var r = xpathResult.GetSingleNodeValueAttribute();
            return new GeckoNode(r);
        }

        public IEnumerable<GeckoNode> GetNodes() {
            return new GeckoNodeEnumerable(xpathResult);
        }

    }
}
