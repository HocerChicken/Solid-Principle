using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.InterfaceSegregationPrinciple.Fix
{
    public class Fish : IAnimal, IFish
    {
        public void Drink()
        {
            //drink
        }

        public void Eat()
        {
            //eat
        }

        public void Sleep()
        {
            //sleep
        }

        public void Swim()
        {
            //swim
        }
    }
}
