using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int f;
            bool ok;

            Console.Write("Введите целое число для факториала: ");
            x = int.Parse(Console.ReadLine());

            ok = Utils.Factorial(x, out f);

            if (ok)
                Console.WriteLine("Factorial(" + x + ") = " + f);
            else
                Console.WriteLine("Невозможно вычислить этот факториал");
        }
    }
}
