using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i+=5)
            {
                if(i%30==0)
                    Console.WriteLine();
                Console.Write("{0,3} ",i);
            }

            Console.ReadLine();
        }
    }
}
