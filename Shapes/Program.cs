﻿using System;

namespace Shapes
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(3, 2);
            Point p2 = new Point(1, -1);
            Point p3 = p1.add(p2);
            Console.WriteLine(p3);
        }
    }
}