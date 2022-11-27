namespace CodeWars
{
    internal static class Multiples3or5
    {
        public static int Solution(int value)
        {
            // Magic Happens
            List<int> numbers = new List<int>();
            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    numbers.Add(i);
            }
            int res = 0;
            foreach (int n in numbers)
            {
                res += n;
            }
            return res;
        }
    }
}
