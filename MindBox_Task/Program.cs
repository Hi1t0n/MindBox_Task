using CalculateAreaLib;
namespace MindBox_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle = new Circle(5);
            Console.WriteLine(circle.GetArea());
            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine(triangle.GetArea());
            Console.WriteLine(triangle.IsRightTriangle());
        }
    }
}