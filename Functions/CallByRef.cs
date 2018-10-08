using System;
namespace Project11
{
    class CallByRef
    {
        public void show(ref int x)
        {
            Console.WriteLine("Inside show function");
            x *= x;
            Console.WriteLine(x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CallByRef obj = new CallByRef();
            int x = 50;
            Console.WriteLine("Inside Main function");
            Console.WriteLine(x);
            obj.show(ref x);
            Console.WriteLine("Inside main function");
            Console.WriteLine(x);
        }
    }
}