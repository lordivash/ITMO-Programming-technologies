using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression ap = new ArithmeticProgression(2, 4.1);
            Console.WriteLine("a [" + 1 + "] = {0:.###}", ap.GetElement(1));
            Console.WriteLine("a [" + 2 + "] = {0:.###}", ap.GetElement(2));
            Console.WriteLine("a [" + 3 + "] = {0:.###}\n", ap.GetElement(3));

            GeometricProgression gp = new GeometricProgression(2, 2.5);
            Console.WriteLine("b [" + 1 + "] = {0:.###}", gp.GetElement(1));
            Console.WriteLine("b [" + 2 + "] = {0:.###}", gp.GetElement(2));
            Console.WriteLine("b [" + 3 + "] = {0:.###}", gp.GetElement(3));

        }
    }
}
