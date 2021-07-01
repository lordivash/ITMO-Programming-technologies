using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvclidPred
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, temp;

            Console.Write("Введите целое число а = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите целое число b = ");
            b = int.Parse(Console.ReadLine());

            temp = a;
            do
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                else if (a == b)
                {
                    a = 2 * a;
                }
                temp = a - b;
                a = b;
            }
            while (temp != b);

            Console.WriteLine("НОД = {0}", a);
        }
    }
}
