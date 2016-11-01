namespace FooBarQixKata
{
    internal class MultiplicityParser : NumberParser
    {
        protected override bool IsNumberValid(int number, int referenceNumber)
        {
            return number % referenceNumber == 0;
        }
    }
}
