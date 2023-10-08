using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.OpenClosePrinciple.Fix
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return this.Radius * this.Radius * 3.14;
        }
    }
}
