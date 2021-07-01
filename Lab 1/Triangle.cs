using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float P, S;

                Console.Write("Введите периметр равностороннего треугольника P = ");
                P = float.Parse(Console.ReadLine());
                P = P / 2;

                S = (float)Math.Sqrt(P*(P-P/3)*(P-P/3)*(P-P/3));

                Console.WriteLine("P   S");
                Console.WriteLine("{0:0.##} {1:0.##,10}", 2*P, S);
            }
            catch(FormatException e)
            {
                Console.WriteLine("The FormatException was thrown");
            }
        }
    }
}
