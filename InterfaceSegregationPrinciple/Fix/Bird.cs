using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.InterfaceSegregationPrinciple.Fix
{
    public class Bird : IAnimal, IBird
    {
        public void Drink()
        {
            //drink
        }

        public void Eat()
        {
            //eat
        }

        public void Fly()
        {
            //fly
        }

        public void Sleep()
        {
            //sleep
        }
    }
}
