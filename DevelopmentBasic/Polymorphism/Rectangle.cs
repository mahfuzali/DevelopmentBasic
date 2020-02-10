using System;
using System.Collections.Generic;
using System.Text;

namespace DevelopmentBasic.Polymorphism
{
    public class Rectangle: Shape
    {
        public override void Draw()
        {
            // Code to draw a rectangle...
            Console.WriteLine("Drawing a rectangle");
            base.Draw();
        }
    }
}
