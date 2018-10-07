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
        public void Show()
        {
            Console.WriteLine("This is non parameterized function");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Show();
            Console.ReadKey();
        }
    }
}
