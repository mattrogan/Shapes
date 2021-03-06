using System;
namespace Shapes
{
	public class Rectangle : Shape
	{

		protected double _width, _length;

		public Rectangle()
		{
			_width = 1.0;
			_length = 1.0;
		}

		public Rectangle(double width, double length)
        {
			_width = width;
			_length = length;
        }

		public Rectangle(double width, double length, String colour, bool filled)
		{
			_width = width;
			_length = length;
			Colour = colour;
			Filled = filled;
		}

		public double Width
        {
			get => _width;
			set
            {
				_width = value;
            }
        }

		public double Length
        {
			get => _length;
			set
			{
				_length = value;
			}
		}

		public double GetArea()
        {
			return _width * _length;
        }

		public double GetPerimeter()
        {
			return 2 * _width + 2 * _length;
        }

		public double Area
        {
			get => GetArea();
        }

		public double Perimeter
        {
			get => GetPerimeter();
        }

        public override string ToString()
        {
            return "A Rectangle with width=" + Width + " and length=" + Length +
				" which is a subclass of " + base.ToString();
        }
    }
}

