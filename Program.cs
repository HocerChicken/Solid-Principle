
using Solid_Principle.OpenClosePrinciple.Fix;
using Solid_Principle.SingleReponsibilityPrinciple.Fix;

namespace Solid_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SingleReposiblityPrinciple(); 
            //      "Every software component (class, method, module)
            //      should have one and only one responsibility"
            //OpenClose();
            //      “Software component should be closed for modification, but open for extension.
            //      This means that new software getting added to the software component,
            //      should not have to modify existing code.”
            //LiskovSubstitution();
            //     “Objects should be replaceable with their subtypes
            //      without affecting the correctness of the program.”
            //Iterface Segregation Principle
            //     “No client should be forced to depend on methods it does not use.”
            //Dependency Inversion
            //     "High-level modules should not depend on low level modules. Both should depend on abstractions.”
            //      “Abstractions should not depend on details, details should depend on abstractions.”
            Console.ReadLine();
        }

        private static void SingleReposiblityPrinciple()
        {
            Student student1 = new() { Name = "Pham Thai Hoc", Age = 21 };
            Formatter formatter = new Formatter();  
            
            
            Store store = new Store();
            store.SaveToFileFromString(formatter.FormatStudentText(student1));
        }

        public static void OpenClose()
        {
            Square square = new Square() { Height = 2 };
            Circle circle = new Circle() { Radius = 2 };
            Triangle triangle = new Triangle() { FirstSide = 3, SecondSide = 4, ThirdSide = 5 };
            List<Shape> shapes = new List<Shape>() { square, circle, triangle};

            //Calculate the Area to Display 
            AreaDisplay area = new AreaDisplay();
            area.ShowArea(shapes);
        }

        public static void LiskovSubstitution()
        {
            //var birds = new List<Bird>() { new Bird(), new Eagle(), new Penguin() };
            ////#1: Child Throw Exception (Penguin is not Bird)
            //foreach (var bird in birds)
            //{
            //    bird.Fly();
            //}
            //#2: Child change the behaviours of the children
            LiskovSubstitutionPrinciple.Problems.ChildChangeBehaviorParent.Rectangle rect = new LiskovSubstitutionPrinciple.Problems.ChildChangeBehaviorParent.Rectangle();
            rect.setHeight(10);
            rect.setWidth(5);

            Console.WriteLine(rect.CalculateArea()); //answer will be 10 x 5

            LiskovSubstitutionPrinciple.Problems.ChildChangeBehaviorParent.Rectangle square = new LiskovSubstitutionPrinciple.Problems.ChildChangeBehaviorParent.Square();
            square.setHeight(10);
            square.setWidth(5);
            Console.WriteLine(square.CalculateArea()); //answer will be 5 x 5
            //False because the Area of Rectangle should be Height x Width
        }
    }
}