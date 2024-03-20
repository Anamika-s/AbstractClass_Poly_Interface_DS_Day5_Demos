using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceDemo
{
    internal class Square
    {
        int side;
        float area;
        public void GetDimensions()
        {
            Console.WriteLine("Enter value for side");
            side =  byte.Parse(Console.ReadLine());    
        }

        public void CalculateArea()
        {
            area = side * side;  // implicit conversion
        }

        public void DisplayArea()
        {
            Console.WriteLine($"Area is {area}");
        }
    }

    internal class Rectangle
    {
        int length, breadth;
        float area;
        public void GetDimensions()
        {
            Console.WriteLine("Enter value for length");
            length = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for breadth");
            breadth = byte.Parse(Console.ReadLine());
        }

        public void CalculateArea()
        {
            area = length * breadth;  // implicit conversion
        }

        public void DisplayArea()
        {
            Console.WriteLine($"Area is {area}");
        }
    }

    internal class Triangle
    {
        int Base, height;
        float area;
        public void GetDimensions()
        {
            Console.WriteLine("Enter value for Base");
            Base = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for height");
            height = byte.Parse(Console.ReadLine());
        }

        public void CalculateArea()
        {
            area = (float).5* Base* height;  // implicit conversion
        }

        public void DisplayArea()
        {
            Console.WriteLine($"Area is {area}");
        }
    }
}
