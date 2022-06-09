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
            Point3D p5 = new Point3D(2, 4, 1);
            Point3D p6 = p4.Add(p5);
            Console.WriteLine(p6);
            Console.WriteLine(p5 == p5);
        }
    }
}