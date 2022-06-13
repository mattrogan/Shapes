using System;
namespace Shapes
{
	public class Shape
	{
		protected String _colour;
		protected bool _filled;

		public Shape()
        {
			_colour = "red";
			_filled = true;
        }

		public Shape(String colour, bool filled)
        {
			_colour = colour;
			_filled = filled;
        }

		public String Colour
        {
			get => _colour;
            set
            {
                _colour = value;
            }
        }

		public bool Filled
        {
			set; get;
        }

		public String IsFilled()
        {
			if (Filled)
            {
				return "filled";
            }
            else
            {
                return "not filled";
            }
        }

        public override string ToString()
        {
            return "A shape with colour of " + Colour + " that is "
				+ IsFilled();
        }


    }
}
