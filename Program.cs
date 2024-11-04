using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car gaadi = new car();
            Console.WriteLine("Task 1: Vehicles");
            gaadi.color();
            gaadi.bodytype();
            gaadi.engine();
            gaadi.start();
            Console.WriteLine("");

            jeep gaadi1 = new jeep();
            gaadi1.color();
            gaadi1.bodytype();
            gaadi1.engine();
            gaadi1.start();
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");



            square diagram = new square();
            Console.WriteLine("Task 2: Shapes");
            diagram.height();
            diagram.width();
            diagram.angle();
            diagram.area();
            Console.WriteLine("");

            rectangle diagram1 = new rectangle();
            diagram1.height();
            diagram1.width(); 
            diagram1.angle();
            diagram1.area();
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}
