using System;
namespace Project11
{
    class returnFunction
    {
        public string ReturnFunction(string str)
        {
            return str + " I am back";
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            returnFunction obj = new returnFunction();
            string recieve = obj.ReturnFunction("Gourab");
            Console.WriteLine(recieve);
            Console.ReadKey();
        }
    }
}