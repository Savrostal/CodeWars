namespace CodeWars
{
    internal static class SqureFinder
    {
        public static long FindNextSquare(long n)
        {
            double sqrt = Math.Sqrt(n);
            if (sqrt - Math.Truncate(sqrt) == 0) return ((long)sqrt + 1) * ((long)sqrt + 1);
            else return -1;
        }
    }
}
