using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1214079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello!!");
            Console.Write(" Silakan berhitung");

            int gajipokok = int.Parse(Console.ReadLine());
            int satu = (gajipokok * 20) / 100;
            int dua = (gajipokok * 15) / 100;
            double tiga = (gajipokok * 3.5) / 100;
            double empat = (gajipokok + satu + dua);
            double lima = (gajipokok + satu + dua) - tiga;

            Console.WriteLine("Gaji Pokok = " + gajipokok);
            Console.WriteLine("Tunjangan  = " + satu);
            Console.WriteLine("Bonus  = " + dua);
            Console.WriteLine("PPH  = " + tiga);
            Console.WriteLine("Total Gaji  = " + empat);
            Console.WriteLine("Gaji Bersih  = " + lima);
        }
    }
}
