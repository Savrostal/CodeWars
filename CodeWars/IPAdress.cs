using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal static class IPAdress
    {
        public static string UInt32ToIP(uint ip)
        {
            byte first = (byte)((ip & 0b11111111000000000000000000000000) >> 24);
            byte second = (byte)((ip & 0b00000000111111110000000000000000) >> 16);
            byte third = (byte)((ip & 0b00000000000000001111111100000000) >> 8);
            byte fourth = (byte)(ip & 0b00000000000000000000000011111111);
            return $"{first}.{second}.{third}.{fourth}";
        }
    }
}
