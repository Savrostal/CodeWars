using System.Text;

namespace CodeWars
{
    internal static class StringSum
    {
        public static string SumStrings(string a, string b)
        {
            if(a.Length > b.Length)
            {
                while (b.Length != a.Length)
                {
                    b = "0" + b;
                }

            }
            else if(b.Length > a.Length)
            {
                while (a.Length != b.Length)
                {
                    a = "0" + a;
                }
            }
            Console.WriteLine(a);
            Console.WriteLine(b);

            StringBuilder stringBuilder = new StringBuilder();
            int p = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                int x = Convert.ToInt32(a[i].ToString());
                int y = Convert.ToInt32(b[i].ToString());
                int sum = x + y + p;
                p = sum / 10;
                sum %= 10;
                stringBuilder.Append(sum);
            }
            if (p > 0)
                stringBuilder.Append(p);
            var tmp = stringBuilder.ToString().ToCharArray();
            Array.Reverse(tmp);
            return new string(tmp).TrimStart('0');
        }
    }
}
