using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.LiskovSubstitutionPrinciple.Problems.ChildThrowException
{
    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new Exception();
        }
    }
}
