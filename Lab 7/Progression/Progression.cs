using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    abstract class Progression
    {
        protected double FirstElement { set; get; }
        protected double Step { set; get; }

        protected Progression(double firstElement, double step)
        {
            FirstElement = firstElement;
            Step = step;
        }

        public abstract double GetElement(int k);
    }
}
