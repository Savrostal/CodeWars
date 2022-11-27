namespace CodeWars
{
    internal static class WeirdStringCase
    {
        public static string ToWeirdCase(string s)
        {
            string result = "";
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    result += s[i];
                    index = 0;
                    continue;
                }
                result += index++ % 2 == 0 ? s[i].ToString().ToUpper() : s[i].ToString().ToLower();
            }
            return result;
        }
    }
}
