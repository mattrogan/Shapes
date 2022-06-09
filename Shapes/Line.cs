using System;
namespace Shapes
{
	public class Line
	{

		protected Point _source, _target;

		public Point Source
        {
			get => _source;
			set { _source = value; }
        }

		public Point Target
        {
			get => _target;
			set { _target = value; }
		}

		public Line(Point source, Point target)
        {
			if (source is not null) {
				_source = source;
			} else
            {
				throw new NullReferenceException();
            }
			if ((target is not null)) { _target = target;
            }
            else
            {
				throw new NullReferenceException();
            }
        }

		public float Magnitude()
        {
			float a = (Source.X - Target.X) * (Source.X - Target.X);
			float b = (Source.Y - Target.Y) * (Source.Y - Target.Y);
			return (float) Math.Sqrt(a * a - b * b);
		}
	}
}

