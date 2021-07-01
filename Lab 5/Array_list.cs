using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLastTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int [n];
            Input(a);

            ShowStatistics(a);
        }

        static void Input(int[] a)
        {
            for (int i = 0; i<a.Length; i++)
            {
                Console.Write("Enter value for [{0}] : ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        static void Sum(int[] a)
        {
            int S = 0;
            for(int i = 0; i<a.Length; i++)
            {
                S += a[i];
            }
            Console.WriteLine("Sum = " + S);
        }

        static void Average(int[] a)
        {
            float Avg = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Avg += a[i];
            }
            Avg /= a.Length;
            Console.WriteLine("Average = " + Avg);
        }

        static void SumPositive(int[] a)
        {
            int SumPos = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0) SumPos += a[i];
            }
            Console.WriteLine("SumPositive = " + SumPos);
        }

        static void SumNegative(int[] a)
        {
            int SumNeg = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0) SumNeg += a[i];
            }
            Console.WriteLine("SumNegative = " + SumNeg);
        }

        static void SumEven(int[] a)
        {
            int SumEven = 0;
            for (int i = 1; i < a.Length; i+=2)
            {
                SumEven += a[i];
            }
            Console.WriteLine("SumEven = " + SumEven);
        }

        static void SumOdd(int[] a)
        {
            int SumOdd = 0;
            for (int i = 0; i < a.Length; i+=2)
            {
                SumOdd += a[i];
            }
            Console.WriteLine("SumOdd = " + SumOdd);
        }

        static int MaxElementNumber(int[] a)
        {
            int MaxElem = a[0];
            int MaxNumber = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if(MaxElem < a[i])
                {
                    MaxElem = a[i];
                    MaxNumber = i;
                }
            }
            return MaxNumber;
        }

        static int MinElementNumber(int[] a)
        {
            int MinElem = a[0];
            int MinNumber = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < MinElem)
                {
                    MinElem = a[i];
                    MinNumber = i;
                }
            }
            return MinNumber;
        }

        static void ProductBetweenMinAndMaxElements(int[] a)
        {
            int min = MinElementNumber(a);
            int max = MaxElementNumber(a);
            
            if(min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }

            int Prod = 1;
            for(int i = min; i<=max; i++)
            {
                Prod *= a[i];
            }

            Console.WriteLine("ProductBetweenMinAndMaxElements = " + Prod);
        }

        static void ShowStatistics(int[] a)
        {
            Sum(a);
            Average(a);
            SumPositive(a);
            SumNegative(a);
            SumEven(a);
            SumOdd(a);
            Console.WriteLine("MaxElementNumber = " + MaxElementNumber(a));
            Console.WriteLine("MinElementNumber = " + MinElementNumber(a));
            ProductBetweenMinAndMaxElements(a);
        }
    }
}
