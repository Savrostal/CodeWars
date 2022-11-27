namespace CodeWars
{
    internal static class HighestScoringWord
    {
        public static string High(string s)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            string[] words = s.Split(' ');
            int[] points = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    points[i] += letters.IndexOf(words[i][j]) + 1;
                }
            }
            int max = 0, max_i = 0;
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i] > max)
                {
                    max = points[i];
                    max_i = i;
                }
            }
            return words[max_i];
        }
    }
}
