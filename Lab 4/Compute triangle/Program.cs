using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            char answer;

            Console.Write("Треугольник равносторонний? (y/n)");
            answer = char.Parse(Console.ReadLine());

            if (answer == 'y')
            {
                float a;

                Console.Write("Введите сторону треугольника a = ");
                a = float.Parse(Console.ReadLine());

                Console.WriteLine("S = " + Operate.Square(a));
            }
            else if (answer == 'n')
            {
                float a, b, c;

                Console.WriteLine("Введите стороны треугольника");
                Console.Write("a = ");
                a = float.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = float.Parse(Console.ReadLine());
                Console.Write("c = ");
                c = float.Parse(Console.ReadLine());

                Console.WriteLine("S = " + Operate.Square(a,b,c));
            }
        }
    }
}
