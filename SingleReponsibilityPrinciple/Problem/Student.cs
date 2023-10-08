using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.SingleReponsibilityPrinciple.Problem
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //Format this class as text, html
        public string FormatStudentText(Student std)
        {
            return "Name: " + std.Name + ". Age: " + std.Age;
        }

        public string FormatStudentHtml(Student std)
        {
            return "<span>" + std.Name + " " + std.Age + "</span>";
        }

        //Store to File
        public void SaveToFileFromString(string s)
        {
            File.WriteAllText("Student.txt", s);

            string readText = File.ReadAllText("Student.txt");
            Console.WriteLine(readText);
        }
    }
}
