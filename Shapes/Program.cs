using System;

namespace Shapes
{

    public class Program
    {

        public static void Main()
        {
            Shape myShape = new("black", true);
            Console.WriteLine(myShape);
            Circle myCirc = new(5.0, "red", true);
            Console.WriteLine(myCirc);
        }
    }
}