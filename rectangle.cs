using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class rectangle : Parent2Shape
    {
        public void height()
        {
            Console.WriteLine("100px");
        }
        public void width()
        {
            Console.WriteLine("200px");
        }
        public void angle()
        {
            Console.WriteLine("All angles are 90");
        }
    }
}
