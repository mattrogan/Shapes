using System;

namespace Shapes
{

    public class Program
    {

        public static void Main()
        {
            Circle myCirc = new Circle(3.0, "black", true);
            myCirc.Radius = 5.0;
            Console.WriteLine(myCirc);
        }
    }
}