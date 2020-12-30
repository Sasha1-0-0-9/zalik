using System;
using System.Collections.Generic;
using System.Text;

namespace zalik
{
    public class Circle : Figures
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override string Perimeter()
        {
            return (2 * Math.PI * radius).ToString();
        }

        public override string Ploshсha()
        {
            return (Math.PI * radius * radius).ToString();
        }

        public override string Name()
        {
            return "Коло";
        }
    }
}
