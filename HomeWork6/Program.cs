using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** 100'den geriye doğru 11 sayısına kadar sayıları 11 azaltarak ekranda gösteriniz ***

            for (int i = 100; i >= 11; i-=11)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("****");

            // *** 1'den 100'e kadar olan sayıları ekranda for ile yazdırınız ***/

            for (int j = 1; j <= 100; j++)
            {
                Console.WriteLine(j);
            }

            Console.Read();
        }
    }
}
