using System;

namespace zalik
{
    class Program
    {
        static void Main(string[] args)
        {
            Figures pramokytnuk = new Pramokytnuk(1, 1, 1, 3, 5, 3);
            pramokytnuk.ShowInfo();

            Figures kolo = new Circle(20);
            kolo.ShowInfo();
            Console.ReadLine();
        }
    }
}
