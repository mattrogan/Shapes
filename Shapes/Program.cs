using System;

namespace Shapes
{

    public class Program
    {

        public static void Main()
        {
            Shape myShape = new("black", true);
            Console.WriteLine(myShape);
            Circle myCirc = new(3.0, "red", true);
            myCirc.Radius = 5.0;
            Console.WriteLine(myCirc);
        }
    }
}