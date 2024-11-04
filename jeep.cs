using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class jeep : Parent1Vehicles
    {
        public void color()
        {
            Console.WriteLine("white");
        }
        public void bodytype()
        {
            Console.WriteLine("4X4");
        }
        public void engine()
        {
            Console.WriteLine("4500CC");
        }
    }
}
