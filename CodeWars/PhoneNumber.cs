using System.Text;

namespace CodeWars
{
    internal static class PhoneNumber
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            StringBuilder res = new StringBuilder();
            res.Append("(");
            for (int i = 0; i < 3; i++)
            {
                
            }
            res.Append(") ");
            for (int i = 3; i < 6; i++)
            {
                res.Append(numbers[i]);
            }
            res.Append("-");
            for (int i = 6; i < 10; i++)
            {
                res.Append(numbers[i]);
            }
            return res.ToString();
        }
    }
}
