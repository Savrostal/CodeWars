using System.Text;

namespace CodeWars
{
    internal static class Diamond
    {
        public static string Print(int n)
        {
            if (n < 0 || n % 2 == 0)
                return null;

            string[] strings = new string[n];
            int k = 1;
            int m = n / 2;
            for (int i = 0; i <= n / 2; i++)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(' ', m);
                stringBuilder.Append('*', k);
                stringBuilder.Append('\n');
                strings[i] = stringBuilder.ToString();
                strings[n - 1 - i] = stringBuilder.ToString();
                k += 2;
                m--;
            }
            StringBuilder stringBuilder2 = new StringBuilder();
            foreach (var s in strings)
            {
                stringBuilder2.Append(s);
            }
            return stringBuilder2.ToString();
        }
    }
}
