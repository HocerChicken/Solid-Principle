using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.LiskovSubstitutionPrinciple.Problems.ChildThrowException
{
    public class Eagle : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Eagle Fly");
        }
    }
}
