using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterfaceDemo
{
    internal abstract class Shape
    {
        protected float area;
        public abstract void GetDimensions();
        public abstract void CalculateArea();
        public void DisplayArea()
        {
            Console.WriteLine($"Area is {area}");
        }
    }

  class Square : Shape
    {
        int side;
        public override void GetDimensions() {
            Console.WriteLine("Enter Value for side");
            side = byte.Parse( Console.ReadLine() );
        }
        public override void CalculateArea()
        {
            area = side * side;
        }
    }

    class Rectangle : Shape
    {
        int length, breadth;
        public override void CalculateArea()
        {
            area = length * breadth;
        }

        public override void GetDimensions()
        {
            Console.WriteLine("Enter value for length");
            length = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for breadth");
            breadth = byte.Parse(Console.ReadLine());
        }
    }

   
}
