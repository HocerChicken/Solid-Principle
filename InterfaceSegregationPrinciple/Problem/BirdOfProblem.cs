using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.InterfaceSegregationPrinciple.Problem
{
    public class BirdOfProblem : IAnimalWrong
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

        public void Swim()
        {
            throw new Exception("Bird can't swim");
        }
    }
}
