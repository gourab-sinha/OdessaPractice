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
            int[] array = new int[10];
            for(int i=0;i<10;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(var item in  array)
            {
                Console.Write(item);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
