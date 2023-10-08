using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.SingleReponsibilityPrinciple.Fix
{
    public class Store
    {
        public void SaveToFileFromString(string s)
        {
            File.WriteAllText("Student.txt", s);

            string readText = File.ReadAllText("Student.txt");
            Console.WriteLine(readText);
        }
    }
}
