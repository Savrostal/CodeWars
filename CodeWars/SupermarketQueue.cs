namespace CodeWars
{
    internal static class SupermarketQueue
    {
        public static long QueueTime(int[] customers, int n)
        {
            Queue<int> queue = new Queue<int>(customers);
            int[] tills = new int[n];

            while (queue.Count > 0)
            {
                int min = int.MaxValue;
                int min_i = 0;
                for (int i = 0; i < n; i++)
                {
                    if (tills[i] < min)
                    {
                        min_i = i;
                        min = tills[i];
                    }
                }
                tills[min_i] += queue.Dequeue();
            }
            return tills.Max();
        }
    }
}
