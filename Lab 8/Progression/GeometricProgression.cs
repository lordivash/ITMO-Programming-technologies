using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    class GeometricProgression : IProgression
    {
        double b, q;

        public GeometricProgression(double b, double q)
        {
            this.b = b;
            this.q = q;
        }

        public double GetElement(int k)
        {
            double result = b;
            for(int i = 1; i<k; i++)
            {
                result *= q;
            }
            return result;
        }
    }
}
