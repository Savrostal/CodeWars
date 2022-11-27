using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal  static class Anagram
    {
        public static List<string> GetAnagrams(string word, List<string> words)
        {
            List<string> res = new List<string>();
            foreach (string w in words)
            {
                if (isEqual(word, w))
                    res.Add(w);
            }
            return res;
        }
        public static bool isEqual(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            char[] cha = a.ToCharArray();
            char[] chb = b.ToCharArray();
            Array.Sort(cha);
            Array.Sort(chb);
            for (int i = 0; i < cha.Length; i++)
            {
                if (cha[i] != chb[i])
                    return false;
            }
            return true;
        }
    }
}
