namespace FooBarQixKata
{
    internal class DigitParser : NumberParser
    {
        protected override bool IsNumberValid(int originalNumber, int referenceNumber)
        {
            return originalNumber.ToString().Contains(referenceNumber.ToString());
        }
    }
}
