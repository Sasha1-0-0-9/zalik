using System;
using System.Collections.Generic;
using System.Text;

namespace zalik
{
    public abstract class Figures
    {
        public abstract string Ploshсha();
        public abstract string Perimeter();
        public abstract string Name();

        public void ShowInfo()
        {
            Console.WriteLine("Фiгура: " + Name() + "  Площа: " + Ploshсha() + "  Периметр: " + Perimeter());
            Console.WriteLine();
        }
    }
}
