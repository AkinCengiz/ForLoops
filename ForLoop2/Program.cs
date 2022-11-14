using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int satir, sutun;
            Console.Write("Satır sayısını giriniz : ");
            satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sütun sayısını giriniz : ");
            sutun = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write(" * ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
