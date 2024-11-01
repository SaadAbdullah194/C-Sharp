using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class age
    {
        private int birthyear;
        private static int currentyear = 2024;


        public double  calculateage(int birthyear) 
        {
           
            return currentyear - birthyear;
        }
    }
}
