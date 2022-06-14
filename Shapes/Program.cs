using System;

namespace Shapes
{

    public class Program
    {

        public static void Shapes()
        {
            Circle myCirc = new(3.0, "black", true);
            myCirc.Radius = 5.0;
            Console.WriteLine(myCirc);

            Console.WriteLine();

            Rectangle myRect = new(3.0, 4.0);
            Console.WriteLine(myRect);

            Console.WriteLine();

            Square mySquare = new(4.5);
            Console.WriteLine(mySquare);
        }

        public static void Lines()
        {
            Point p1 = new(2, 3);
            Point p2 = new(6, 9);
            Line l = new(p1, p2);
            Console.WriteLine(l);
        }

        public static void Main()
        {
            Shapes();
            Console.WriteLine();
            Lines();
        }
    }
}

