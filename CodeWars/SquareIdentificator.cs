using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal static class SquareIdentificator
    {
        public static bool IsSquare(int n)
        {
            return n >= 0 && Math.Sqrt(n) - Math.Truncate(Math.Sqrt(n)) == 0;
        }
    }
}
