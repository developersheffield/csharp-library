namespace CsharpLibrary.ExtensionMethods
{
    public static class IntExtensions
    {
        public static bool IsOdd(this int integer)
        {
            return integer % 2 == 1;
        }

        public static bool IsEven(this int integer)
        {
            return integer % 2 == 0;
        }
    }
}
