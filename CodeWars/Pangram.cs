namespace CodeWars
{
    internal static class Pangram
    {
        public static bool IsPangram(string str)
        {
            string letters = "qwertyuiopasdfghjklzxcvbnm";
            str = str.ToLower();
            foreach (char letter in letters)
            {
                if (!str.Contains(letter))
                    return false;
            }
            return true;
        }
    }
}
