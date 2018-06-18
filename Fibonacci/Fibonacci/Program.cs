using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void dondur(int x)
        {

            int a = 0;
            int b = 1;
            int toplam = 0;
            Console.Write(a + "-" + b + "-");
            for (int i = 0; i < x; i++)
            {
                toplam = a + b;
                Console.Write(toplam + "-");
                a = b;
                b = toplam;
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Adım Sayısı Girin");
            int adimsayisi = Convert.ToInt16(Console.ReadLine());
            dondur(adimsayisi);
        }
    }
}
