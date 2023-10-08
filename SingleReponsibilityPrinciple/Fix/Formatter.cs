using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.SingleReponsibilityPrinciple.Fix
{
    public class Formatter
    {
        public string FormatStudentText(Student std)
        {
            return "Name: " + std.Name + ". Age: " + std.Age;
        }

        public string FormatStudentHtml(Student std)
        {
            return "<span>" + std.Name + " " + std.Age + "</span>";
        }
    }
}
