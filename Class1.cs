namespace ClassLibrary1
{
    public static class StringExtensions
    {
        public static bool StartsWithUpperCase(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;
            return char.IsUpper(str[0]);
        }
    }
}
