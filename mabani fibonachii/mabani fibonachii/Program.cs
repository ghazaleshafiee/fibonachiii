using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mabani_fibonachii
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Fibonachi(i));
            }
            Console.ReadLine();
            }
        static int Fibonachi(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

    }
}
