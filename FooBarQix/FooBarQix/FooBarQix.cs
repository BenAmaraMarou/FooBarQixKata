namespace FooBarQixKata
{
    internal class FooBarQix
    {
        private readonly MultiplicityParser _multiplicityParser;
        private readonly DigitParser _digitParser;

        public FooBarQix()
        {
            _multiplicityParser = new MultiplicityParser();
            _digitParser = new DigitParser();
        }

        internal string Process(int number)
        {
            var multiplePart = _multiplicityParser.Parse(number);
            var containsPart= _digitParser.Parse(number);
            var result = $"{multiplePart}{containsPart}";
            if (!string.IsNullOrEmpty(result))
            {
                return result;
            }
            return number.ToString();
        }
    }
}