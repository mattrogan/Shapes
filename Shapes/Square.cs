using System;
namespace Shapes
{
	public class Square : Rectangle
	{

		public Square() : base()
		{
			
		}

		public Square(double side) : base(side, side) { }


		public Square(double side, String colour, bool filled) : base(side, side, colour, filled) { }

		public double Side
		{
			get => _length;
			set
			{
				_width = value;
				_length = value;
			}
		}

        public override string ToString()
        {
            return "A Square with side length=" + Side
				+ " which is a subclass of " + base.ToString();
        }
    }
}

