using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    class ArithmeticProgression : Progression
    {
        public ArithmeticProgression(double a, double d) : base(a, d) { }

        public override double GetElement(int k)
        {
            double result = FirstElement + (k - 1) * Step;
            return result;
        }
    }
}
