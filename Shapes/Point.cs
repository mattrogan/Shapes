using System;

namespace Shapes
{
	/*
	 * Point
	 * 
	 * A class for representing points in 2D space on a
	 * Cartesian plane.
	 * 
	*/
	public class Point
	{
		protected float _x, _y; // Backing store

		public Point()
		{
			_x = 0;
			_y = 0;
		}

		public Point(float x, float y)
		{
			_x = x;
			_y = y;
		}

		public float X {
			get => _x;
			set { _x = value; }
		}

		public float Y {
			get => _y;
			set { _y = value; }
		}

        public override string ToString()
        {
			return "(" + _x + ", " + _y + ")";
        }

		public Point Add(Object o)
        {
			Point returnPoint = new Point();
			if (o.GetType() == this.GetType())
            {
				Point other = (Point) o;
				returnPoint.X = this.X + other.X;
				returnPoint.Y = this.Y + other.Y;
				return returnPoint;
            }
            else
            {
                throw new Exception("can only add points to other points");
            }
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

		public void Move(float dx, float dy)
        {
			_x += dx;
			_y += dy;
        }

		public void Scalar(float s)
        {
			_x *= s;
			_y *= s;
        }
	}


	/*
	 * Point3D
	 * 
	 * A class for representing points in 3D space.
	 * 
	 * This is a subclass that extends the Point class,
	 * implementing the third dimension `z`.
	 * 
	*/

	public class Point3D : Point
    {
		protected float _z;

		public Point3D(float x, float y, float z)
        {
			_x = x;
			_y = y;
			_z = z;
        }

		public Point3D()
        {
			_x = 0; _y = 0; _z = 0;
        }

		public float Z
		{
			get => _z;
			set { _z = value; }
		}

		public override string ToString()
        {
			return "(" + _x + ", " + _y + ", " + _z + ")";
        }

		public Point3D Add(Object o)
		{
			Point3D returnPoint = new Point3D();
			if (o.GetType() == this.GetType())
			{
				Point3D other = (Point3D) o;
				returnPoint.X = this.X + other.X;
				returnPoint.Y = this.Y + other.Y;
				returnPoint.Z = this.Z + other.Z;
				return returnPoint;
			}
			else
			{
				throw new Exception("can only add points to other points");
			}
		}
	}
}

