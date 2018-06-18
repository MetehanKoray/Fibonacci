using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int toplam = 0;
            Console.Write(a + "-" + b + "-");
            for (int i = 0; i < 10; i++)
            {
                toplam = a + b;
                Console.Write(toplam + "-");
                a = b;
                b = toplam;
            }
            Console.ReadLine();
        }
    }
}
