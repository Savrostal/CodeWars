namespace CodeWars
{
    internal static class HighestAndLowest
    {
        public static string HighAndLow(string numbers)
        {
            string[] s = numbers.Split(' ');
            int[] a = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                a[i] = int.Parse(s[i]);
            }

            return $"{a.Max()} {a.Min()}";
        }
    }
}
