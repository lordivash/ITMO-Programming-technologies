using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinPost
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x, y;

            Console.Write("Введите правую границу интервала x1 = ");
            x1 = float.Parse(Console.ReadLine());

            Console.Write("Введите левую границу интервала x2 = ");
            x2 = float.Parse(Console.ReadLine());

            x = x1;

            Console.WriteLine("{0,-7}{1}", "X", "Y");
            do
            {
                Console.Write("{0,-7}", x);
                y = Math.Sin(x);
                Console.WriteLine("{0:0.####}",y);
                x = x + 0.01;
            }
            while (x <= x2);
        }
    }
}
