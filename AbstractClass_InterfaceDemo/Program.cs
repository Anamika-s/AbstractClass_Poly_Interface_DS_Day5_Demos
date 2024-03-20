using AbstractClassInterfaceDemo;
namespace AbstractClass_InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractClassInterfaceDemo.Square square = new AbstractClassInterfaceDemo.Square();
            square.GetDimensions();
            square.CalculateArea();
            square.DisplayArea();

            AbstractClassInterfaceDemo.Rectangle rectangle = new AbstractClassInterfaceDemo.Rectangle();    
            rectangle.GetDimensions();
            rectangle.CalculateArea();
            rectangle.DisplayArea();

        }
    }
}