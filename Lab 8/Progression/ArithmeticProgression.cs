using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    class ArithmeticProgression : IProgression
    {
        double a, d;

        public ArithmeticProgression(double a, double d)
        {
            this.a = a;
            this.d = d;
        }

        public  double GetElement(int k)
        {
            double result = a + (k - 1) * d;
            return result;
        }
    }
}
