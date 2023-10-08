using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.LiskovSubstitutionPrinciple.Problems.ChildThrowException
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Flyinggg.............");
        }
    }
}
