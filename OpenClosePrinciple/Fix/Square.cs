using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.OpenClosePrinciple.Fix
{
    public class Square : Shape
    {
        public double Height { get; set; }

        public override double Area()
        {
            return Math.Pow(Height, 2);
        }
    }
}
