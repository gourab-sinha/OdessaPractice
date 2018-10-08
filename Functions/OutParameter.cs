using System;
namespace Project11
{
    class OutParameterFunction
    {
        public int show(out int x, int y)
        {
            int square = 5;
            x = square;
            x *= x;
            return (y - 5);

        }
    }
    class Program
    {
        static void Main(string[] agrvs)
        {
            OutParameterFunction obj = new OutParameterFunction();
            int x = 50, y = 20;
            Console.WriteLine("Before show function called" +"Value of x:" + x + "\n" + "Value of y:" + y);
            y = obj.show(out x, y);
            Console.WriteLine("After show function called" + "Value of x:" + x + "\n" + "Value of y:" + y);
        }
    }
}