using System;
using System.Collections.Generic;
using System.Text;

namespace DevelopmentBasic.Polymorphism
{
    public class Circle: Shape
    {
        public override void Draw()
        {
            // Code to draw a circle...
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
    }
}
