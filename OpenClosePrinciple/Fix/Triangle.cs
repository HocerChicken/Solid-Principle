using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.OpenClosePrinciple.Fix
{
    public class Triangle : Shape
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

        public override double Area()
        {
            var totalHalf = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(totalHalf * (totalHalf - FirstSide) * (totalHalf - SecondSide) * (totalHalf - ThirdSide));
        }
    }
}
