using System;
namespace Shapes
{
	public class Line
	{
		protected Point _start, _end;
		protected String _colour = "black";

		public Line(Point start, Point end)
		{
			_start = start;
			_end = end;

		}

		public String Colour
        {
			get => _colour;
			set
			{ _colour = value; }
        }

		public Point Start
        {
			get => _start;
			set { _start = value; }
        }

		public Point End
		{
			get => _end;
			set { _end = value; }
		}

		public override String ToString()
        {
			return "A Line starting at " + Start.ToString()
				+ " and ending at " + End.ToString();
        }
	}
}

