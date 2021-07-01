using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeTriangle
{
    class Operate
    {
        public static float Square(float a, float b, float c)
        {
            float p = (a + b + c) / 2;
            float S;

            if (Exists(a, b, c))
                S = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            else
            {
                Console.WriteLine("Треугольника с такими сторонами не существует");
                S = 0;
            }

            return S;
        }

        private static bool Exists(float a, float b, float c)
        {
            return (a < b + c && b < a + c && c < a + b);
        }

        public static float Square (float a)
        {
            float S = (float)Math.Sqrt(3) * a * a / 4;
            return S;
        }
    }
}
