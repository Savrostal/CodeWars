namespace CodeWars
{
    internal static class FirstNonRepeatingLetter
    {
        public static string GetLetter(string s)
        {

            Dictionary<char, int> d = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (d.Keys.Contains(char.ToLower(s[i])))
                    d[char.ToLower(s[i])]++;
                else
                    d[char.ToLower(s[i])] = 1;
            }
            var n = d.Keys.Where(x => d[x] == 1);
            for (int i = 0; i < s.Length; i++)
            {
                if (n.Contains(char.ToLower(s[i])))
                    return s[i].ToString();
            }
            return "";
        }
    }
}
