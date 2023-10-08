using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.LiskovSubstitutionPrinciple.Problems.ChildChangeBehaviorParent
{
    public class Square : Rectangle
    {
        public override void setHeight(int height)
        {
            Height = height;
            Width = height;
        }

        public override void setWidth(int width)
        {
            Width = width;
            Height = width;
        }
    }
}
