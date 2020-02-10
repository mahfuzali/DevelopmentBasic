using DevelopmentBasic.Abstract;
using DevelopmentBasic.Polymorphism;
using System;
using System.Collections.Generic;

namespace DevelopmentBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
            Vehicle v = new Car();
            v.Type = "Car";
            v.Engine = 2.0;
            v.Speed = 120;
            Console.WriteLine(v.ToString());
            */

            ShapeImplementaion();
        }

        public static void ShapeImplementaion() {
            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Triangle(),
                new Circle()
            };

            // Polymorphism at work #2: the virtual method Draw is
            // invoked on each of the derived classes, not the base class.
            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }
}
