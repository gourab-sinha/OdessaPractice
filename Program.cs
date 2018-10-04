using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");
            int[] oldNUmbers = { 1, 2, 3, 4, 5 };
            int number = oldNUmbers[2];
            Console.WriteLine(number);
            int i = 0;
            for(;i < 5; i++)
            {
                if (oldNUmbers[i] % 2 == 0)
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");
            }
            Console.ReadKey();
            //Console.ReadKey();
        }
    }
}
