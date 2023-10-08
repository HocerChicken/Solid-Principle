using Solid_Principle.OpenClosePrinciple.Fix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.OpenClosePrinciple.Problem
{
    public class AreaDisplay
    {
        public void ShowArea(List<ShapeWrong> shapes)
        {
            foreach (ShapeWrong shape in shapes)
            {
                if(shape is SquareWrong)
                {
                    SquareWrong square = (SquareWrong) shape;
                    //Calc Area
                }
                if(shape is TriangleWrong)
                {
                    TriangleWrong triangle = (TriangleWrong)shape;
                    //Calc Area
                }
                if (shape is CircleWrong)
                {
                    CircleWrong circle = (CircleWrong)shape;
                    //Calc Area
                }
            }
        }
    }
}
