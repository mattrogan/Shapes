using System;

namespace Shapes
{

    public class Program
    {

        public static void Main()
        {
            Circle myCirc = new(3.0, "black", true);
            myCirc.Radius = 5.0;
            Console.WriteLine(myCirc);

            Console.WriteLine();

            Rectangle myRect = new(3.0, 4.0);
            Console.WriteLine(myRect);
        }
    }
}