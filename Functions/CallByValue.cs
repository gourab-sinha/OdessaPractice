using System;
namespace Project11
{
    class CallByValueFunction
    {
        public void show(int x)
        {
            Console.WriteLine("Inside show function");
            x *= x;
            Console.WriteLine(x); ;
        }
    }
    class Program
    {
        static void Main(string[] agrs)
        {
            CallByValueFunction obj = new CallByValueFunction();
            int x = 50;
            Console.WriteLine("Inside main function");
            Console.WriteLine(x);
            obj.show(x);
            Console.WriteLine("Inside main function");
            Console.WriteLine(x);
        }
    }
}