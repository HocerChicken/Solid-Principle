using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.LiskovSubstitutionPrinciple.Problems.ChildChangeBehaviorParent
{
    public class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void setHeight(int height)
        {
            Height = height;
        }
        public virtual void setWidth(int width)
        {
            Width = width;
        }

        public virtual int CalculateArea()
        {
            return Height * Width;
        }
    }
}
