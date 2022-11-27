namespace CodeWars
{
    internal static class MiddleCharacter
    {
        public static string GetMiddle(string s)
        {
            int l = s.Length;
            if (l % 2 != 0)
            {
                return s[l / 2].ToString();
            }
            else return s[l / 2 - 1].ToString() + s[l / 2].ToString();
        }
    }
}
