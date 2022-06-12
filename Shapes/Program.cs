using System;

namespace Shapes
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Shape myShape = new("black", true);
            Console.WriteLine(myShape);
        }
    }
}