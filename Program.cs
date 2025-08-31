using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");

        }

        static void Toplama ( int sayi1, int sayi2 )
            {
        int toplam = sayi1 + sayi2;
        Console.Writeline (toplam);
            }
        static void Toplama ( int sayi1, int sayi2, int sayi3 )
            {
        int toplam = sayi1 + sayi2 + sayi3;
        Console.WriteLine (toplam);
            }
    }
}
