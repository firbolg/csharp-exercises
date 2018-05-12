using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {

            int r;
            double A;
            Console.WriteLine("Enter a radius:");
            r = Convert.ToInt32(Console.ReadLine());
            A = (3.14) * r * r;
            Console.WriteLine("The area of the circle is " + A);
            Console.ReadLine();
                      
        }
    }
}
