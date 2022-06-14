using System;
namespace Shapes
{
	public class Point
	{
		protected double _x, _y;
		protected String _colour = "black";

		public Point()
		{
			_x = 0.0;
			_x = 0.0;

		}

		public Point(int x, int y)
        {
			_x = x;
			_y = y;
        }

		public String Colour
        {
			get => _colour;
            set
            {
				_colour = value;
            }
        }

		public override String ToString()
        {
			return "(" + _x + ", " + _y + ")";
        }
	}
}

