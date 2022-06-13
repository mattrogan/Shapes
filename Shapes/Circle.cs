using System;
namespace Shapes
{
	public class Circle : Shape
	{

		public const double PI = 3.14159;

		protected double _radius;

		public Circle() : base()
        {
			_radius = 1.0;
        }

		public Circle(double radius) : base()
        {
			_radius = radius;
        }

		public Circle(double radius, String colour, bool filled) : base(colour, filled)
        {
			_radius = radius;
        }

        public double Radius
        {
			get => _radius;
            set
            {
				_radius = value;
            }
        }


		public double GetArea() { return PI * _radius * _radius; }

		public double GetPerimeter() { return 2 * PI * _radius; }

		public override String ToString()
        {
			return "A Circle with radius=" + _radius + ", which is a subclass of " + base.ToString();
		}


	}

}