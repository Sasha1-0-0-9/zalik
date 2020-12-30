using System;
using System.Collections.Generic;
using System.Text;

namespace zalik
{
    public class Pramokytnuk : Figures
    {
        public double x1, x2, x3, y1, y2, y3;

        public Pramokytnuk(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
        }

        public double Dlinna(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public override string Perimeter()
        {
            double AB = Dlinna(x1, y1, x2, y2);
            double BC = Dlinna(x2, y2, x3, y3);
            return ((AB + BC) * 2).ToString();
        }

        public override string Ploshсha()
        {
            double AB = Dlinna(x1, y1, x2, y2);
            double BC = Dlinna(x2, y2, x3, y3);
            return (AB * BC).ToString();
        }

        public override string Name()
        {
            return "Прямокутник";
        }

    }
}
