using System.Linq;

namespace FooBarQixKata
{
    internal abstract class NumberParser
    {
        protected readonly FooBarQixPairs _fooBarQixPairs;

        protected NumberParser()
        {
            _fooBarQixPairs = new FooBarQixPairs();
        }

        internal string Parse(int number)
        {
            var result = string.Empty;
            result = _fooBarQixPairs
                .Where(pair => IsNumberValid(number, pair.Number))
                .Aggregate(result, (currentResult, pair) => currentResult + pair.Value);
            return result;
        }

        protected abstract bool IsNumberValid(int number, int referenceNumber);
    }
}
