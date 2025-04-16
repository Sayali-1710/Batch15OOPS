using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPSAssign
{

    public abstract class shape()
    {

        //abstract method 
        public abstract double calculateArea(double x, double y);
        //non abstract method
        public virtual void DisplayShape()
        {
            Console.WriteLine("This is a Shape");
        }

    }
    //derived class
    public class Circle : shape
    {
        public override double calculateArea(double pi, double radius)
        {
            return pi * radius;
        }

        public override void DisplayShape()
        {
            Console.WriteLine("This is a circle");
        }


    }

    public class Rectangle : shape
    {
        public override double calculateArea(double length, double width)
        {
            return length * width;
        }

        public override void DisplayShape()
        {
            Console.WriteLine(" This is a Rectangle");
        }


    }


    class AbstractExample
    {
        static void Main()
        {
            Circle circleArea = new Circle();
            Rectangle rectangleArea = new Rectangle();

            circleArea.DisplayShape();
            Console.WriteLine("Area of Circle is :" + circleArea.calculateArea(9.38, 8));

            rectangleArea.DisplayShape();
            Console.WriteLine("Area of Rectangle is :" + rectangleArea.calculateArea(7.7, 60));

        }



    }
}
