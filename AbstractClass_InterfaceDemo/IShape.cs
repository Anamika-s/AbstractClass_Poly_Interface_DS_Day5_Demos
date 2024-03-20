using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterface
{ 
    internal interface IShape
    {
        //public float Area {  get; set; }
        public void GetDimensions();
        public void CalculateArea();
        public void DisplayArea();

    }

    // interfaces are implemented in the classes
    class Square : IShape
    {

        int side;
        float area;
        public void CalculateArea()
        {
            area = side * side;
          
        }

        public void DisplayArea()
        {

            Console.WriteLine($"Area is {area}");
        }

        public void GetDimensions()
        {
            Console.WriteLine("Enter Value for side");
            side = byte.Parse(Console.ReadLine());
        }
    }

    class Rectangle : IShape
    {
        int length, breadth;
        float area;
        public void CalculateArea()
        {
            area = length * breadth;
        }

        public void DisplayArea()
        {

            Console.WriteLine($"Area is {area}");
        }

        public void GetDimensions()
        {
            Console.WriteLine("Enter value for length");
            length = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for breadth");
            breadth = byte.Parse(Console.ReadLine());
        }
    }

    class Triangle : IShape
    {
        void IShape.CalculateArea()
        {
            throw new NotImplementedException();
        }

        void IShape.DisplayArea()
        {
            throw new NotImplementedException();
        }

        void IShape.GetDimensions()
        {
            throw new NotImplementedException();
        }
    }

    interface I1
    {
        public void Get1();
    }

    interface I2
    {
        public void Get1();
        public void Get2();
    }

    class Class1 : I1, I2
    {
        public void Get1()
        {
            throw new NotImplementedException();
        }

        public void Get2()
        {
            throw new NotImplementedException();
        }
    }


    class Class2 : I1, I2
    {
        void I1.Get1()
        {
            throw new NotImplementedException();
        }

        void I2.Get1()
        {
            throw new NotImplementedException();
        }

        void I2.Get2()
        {
            throw new NotImplementedException();
        }
    }






}
