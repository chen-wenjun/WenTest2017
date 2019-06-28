using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int x = 15;
                double d1 = 14.75;
                double d2 = 14.75;
                int hash1 = d1.GetHashCode();
                int hash2 = d2.GetHashCode();
            }
            {
                object obj1 = new object();
                object obj2 = new object();
                int hash1 = obj1.GetHashCode();
                int hash2 = obj2.GetHashCode();
            }
            {
                string str1 = "asfasfasfasf2354235qerteqwrte";
                string str2 = "asfasfasfasf2354235qerteqwrte";
                int hash1 = str1.GetHashCode();
                int hash2 = str2.GetHashCode();
            }

        }
    }
}
