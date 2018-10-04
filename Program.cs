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
            for (; i < 5; i++) // print all numbers
            {
                switch (oldNUmbers[i])
                {
                    case 1:
                        Console.WriteLine("1st\n");
                        break;
                    case 2:
                        Console.WriteLine("2nd\n");
                        break;
                    case 3:
                        Console.WriteLine("3rd\n");
                        break;
                    case 4:
                        Console.WriteLine("4th\n");
                        break;
                    default:
                        Console.WriteLine("5th\n");
                        break;
                }
            }
            Console.ReadKey();
            //Console.ReadKey();
        }
    }
}
