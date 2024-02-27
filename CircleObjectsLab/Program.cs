
namespace CircleObjectsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester!");
            Console.WriteLine("");
            Console.Write("Please enter the radius of a circle: ");
            double radius = GetValidRadius();
            Circle circle = new Circle(radius);
            DisplayCircleInfo(circle);
            bool grow = AskUserToGrow();
            while (grow)
            {
                circle.Grow();
                DisplayCircleInfo(circle);
                grow = AskUserToGrow();
            }
            Console.WriteLine($"Goodbye The circle's final radius is {circle.GetRadius():0.00}.");
        }
        static void DisplayCircleInfo(Circle circle)
        {
            Console.WriteLine($"Diameter: {circle.CalculateDiameter():0.00}.");
            Console.WriteLine($"Circumference: {circle.CalculateCircumference():0.00}.");
            Console.WriteLine($"Area: {circle.CalculateArea():0.00}.");
        }
        static double GetValidRadius()
        {
            double radius;
            bool valid = double.TryParse(Console.ReadLine(), out radius);
            while (!valid || radius <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer:");
                valid = double.TryParse(Console.ReadLine(), out radius);
            }
            return radius;
        }
        static bool AskUserToGrow()
        {
            Console.WriteLine("");
            Console.WriteLine("Should the circle grow? (y/n)");
            string answer = Console.ReadLine().ToLower();
            Console.WriteLine("");
            while (answer != "y" && answer != "n")
            {
                Console.WriteLine("Invalid input. Please enter y or n:");
                answer = Console.ReadLine().ToLower();
            }
            return answer == "y";
        }
    }
}




