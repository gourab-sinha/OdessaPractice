using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11
{
    class Employee
    {
        public string _name
        {
            get;
            set;
        }
        public int _id
        {
            get;
            set;
        }
        public string _address
        {
            get;
            set;
        }

        public void AcceptDetails()
        {
            _name = Console.ReadLine();
            _id = Convert.ToInt32(Console.ReadLine());
            _address = Console.ReadLine();
        }
        public void ShowDetails()
        {
            Console.WriteLine(_name);
            Console.WriteLine(_id);
            Console.WriteLine(_address);
        }
    }
}
