using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.OpenClosePrinciple.Fix
{
    public class AreaDisplay
    {
        public void ShowArea(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area());
            }
        }
    }
}
