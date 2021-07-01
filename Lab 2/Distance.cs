using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    public struct Distance
    {
        public int foots;
        public float inches;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Distance A,B,C;

            Console.WriteLine("Enter foots for Distance A");
            A.foots = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter inches for Distance A");
            A.inches = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter foots for Distance B");
            B.foots = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter inches for Distance B");
            B.inches = float.Parse(Console.ReadLine());

            C = Sumdist(A, B);

            Console.WriteLine("Distance A {0}' - {1}''", A.foots, A.inches);
            Console.WriteLine("Distance B {0}' - {1}''", B.foots, B.inches);
            Console.WriteLine("Distance C {0}' - {1}''", C.foots, C.inches);
        }

        static Distance Sumdist(Distance d1, Distance d2)
        {
            Distance d3;

            d3.foots = d1.foots + d2.foots + (int)(d1.inches + d2.inches)/12;
            d3.inches = (d1.inches + d2.inches)%12;

            return d3;
        }
    }
}
