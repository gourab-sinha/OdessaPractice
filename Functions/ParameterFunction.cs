using System;
namespace Project11
{
    class Functions
    {
        public string ReturnFunction(string message)
        {
            return (message + " World");
        }
    }
    class Program
    {
        public static void Main(string []agrs)
        {
            Functions obj = new Functions();
            Console.WriteLine(obj.ReturnFunction("Hello"));
            //Console.WriteLine("Hello");
            Console.ReadKey();
        }
    }
}