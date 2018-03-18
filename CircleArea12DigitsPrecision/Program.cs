using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea12DigitsPrecision
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double result = Math.PI * radius * radius;
            //Console.WriteLine("{0} is area on circle with radius {1}",result,radius);
            Console.WriteLine("{0:f12}", result);
            Console.WriteLine($"{result:f12}");
        }
    }
}
