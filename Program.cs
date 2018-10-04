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
            int[] oldNUmbers = { 1, 2, 3, 4, 5 }; // 1D Array, static declaration
            int number = oldNUmbers[2]; // assign value of index 2 to number 
            Console.WriteLine(number); // print number
            int i = 0;
            /*while(i<5)
            {
                Console.WriteLine(oldNUmbers[i]);
                //Console.WriteLine("\n");
                i += 1;
            }
            i = 0;
            do
            {
                Console.WriteLine(oldNUmbers[i]);
                i += 1;
            } while (oldNUmbers[i] > 4);*/
            int counter = 0;
            for (; i < 5; i++) // print all numbers
            {
                if (oldNUmbers[i] == 3)
                {
                    break;
                }
                counter += 1;
            }
            Console.WriteLine(counter);
            Console.ReadKey();
            //Console.ReadKey();
        }
    }
}
