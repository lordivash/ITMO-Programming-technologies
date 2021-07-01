using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    class GeometricProgression : Progression
    {
        public GeometricProgression(double b, double q) : base(b, q) { }

        public override double GetElement(int k)
        {
            double result = FirstElement;
            for(int i = 1; i<k; i++)
            {
                result *= Step;
            }
            return result;
        }
    }
}
