using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class car : Parent1Vehicles
    {
        public void color()
        {
            Console.WriteLine("black");
        }
        public void bodytype() 
        {
            Console.WriteLine("sedan");
        }
        public void engine() 
        {
            Console.WriteLine("2000CC");
        }
    }
}
