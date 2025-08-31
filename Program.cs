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
            
            static void carpma()
            {
                double carpma;
                double sayı1;
                double sayı2;

                Console.Writeline("birinci sayıyı ekleyin");

                Console.Readline(sayı1);

                Console.Writeline("ikinci sayıyı ekleyin");

                Console.Readline(sayı2);

                carpma = sayı1 * sayı2;

                Console.Writeline(carpma);

            }
            

        }
        

    }
}
