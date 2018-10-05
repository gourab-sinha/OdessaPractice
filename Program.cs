using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11
{
    class car
    {
        string _Brand;
        string _Model;
        int _speed;
        double _EnginePower;
        public void AcceptCarDetails(string Brand, string Model, int Speed, double EnginePower)
        {
            _Brand = Brand;
            _Model = Model;
            _speed = Speed;
            _EnginePower = EnginePower;
        }
        public void DisplayCarDetails()
        {
            Console.Write($"Brand: {_Brand} \n Model: {_Model} \n Speed: {_speed} \n EnginePower: {_EnginePower} \n");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            car newcar = new car();
            newcar.AcceptCarDetails("Honda", "RXTX", 50, 700.00);
            newcar.DisplayCarDetails();
        }
    }
}
