using System;

namespace Shapes
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(3, 2);
            Point p2 = new Point(1, -1);
            Point p3 = p1.Add(p2);
            Console.WriteLine(p3);
            Console.WriteLine("");

            Point3D p4 = new Point3D(1, -1, 2);
            Console.WriteLine(p4);
        }
    }
}