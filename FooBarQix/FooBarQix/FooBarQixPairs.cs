using System.Collections;
using System.Collections.Generic;

namespace FooBarQixKata
{
    internal class FooBarQixPairs : IEnumerable<NumberValuePair>
    {
        private readonly IEnumerable<NumberValuePair> _numberValuePairs;

        public FooBarQixPairs()
        {
            _numberValuePairs = new[]
            {
                new NumberValuePair(3, "Foo"),
                new NumberValuePair(5, "Bar"),
                new NumberValuePair(7, "Qix")
            };
        }

        public IEnumerator<NumberValuePair> GetEnumerator()
        {
            return _numberValuePairs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
