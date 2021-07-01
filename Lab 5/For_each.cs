using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;
            int n = int.Parse(Console.ReadLine());
            myArray = new int[n];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            foreach (int x in myArray) Console.Write("{0} ", x);
        }
    }
}
