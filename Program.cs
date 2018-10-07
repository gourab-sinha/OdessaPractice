using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11
{

    class Program
    {
        public void Show(int x)
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Show(5);
            Console.ReadKey();
        }
    }
}
