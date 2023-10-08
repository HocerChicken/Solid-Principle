using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.InterfaceSegregationPrinciple.Problem
{
    public class FishOfProblem : IAnimalWrong
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
            throw new Exception("Fish can't fly");
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
