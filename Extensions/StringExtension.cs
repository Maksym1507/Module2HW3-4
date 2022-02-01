namespace Module2HW3_4.Extensions
{
    public static class StringExtension
    {
        public static string Reverse(this string str)
        {
            string reverseStr = null;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseStr += str[i];
            }

            return reverseStr;
        }
    }
}
