using System;
namespace Shapes
{
	public class Circle : Shape
	{

		public const double PI = 3.14159;

		protected double _radius;

		public Circle()
        {
			_radius = 1.0;
        }

		public Circle(double radius)
        {
			_radius = radius;
        }

		public Circle(double radius, string colour, bool filled)
        {
			_filled = filled;
			_colour = colour;
			_radius = radius;
        }

        public double Radius
        {
			set; get;
        }


		public double getArea() { return PI * _radius * _radius; }

		public double getPerimeter() { return 2 * PI * _radius; }

		public override String ToString()
        {
			return "A Circle with radius=" + _radius + ", which is a subclass of " + base.ToString();
		}


	}

}