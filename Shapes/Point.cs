using System;

namespace Shapes
{
	/*
	 * Position
	 * 
	 * Abstract class that implements a position in
	 * a Cartesian plane
	*/
	public abstract class Position
    {
		public abstract Position Add(object obj);

		public abstract void Scalar(float s);

		public abstract void Move(float dx, float dy);
    }

	/*
	 * Point
	 * 
	 * A class for representing points in 2D space on a
	 * Cartesian plane.
	 * 
	*/
	public class Point : Position
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

		public override Point Add(object obj)
        {
			Point returnPoint = new Point();
			if ((obj.GetType() == GetType()) && !(obj is null))
            {
				Point other = (Point) obj;
				returnPoint.X = X + other.X;
				returnPoint.Y = X + other.Y;
				return returnPoint;
            }
            else
            {
                throw new Exception("can only add points to other points");
            }
        }

        public override bool Equals(object? obj)
        {
			if (obj is null)
            {
				return false;
            }
			if (GetType() == obj.GetType())
            {
				Point other = (Point)obj;
				return X == other.X && Y == other.Y;
            } else
            {
				return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

		public override void Move(float dx, float dy)
        {
			_x += dx;
			_y += dy;
        }

		public override void Scalar(float s)
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

        public Point3D(float x, float y, float z) : base(x, y) => _z = z;

        public Point3D() : base()
        {
			_z = 0;
        }

        public Point3D(float x, float y) : base(x, y) { }

        public float Z
        {
			get => _z;
			set { _z = value; }
        }

        public override string ToString()
        {
			return "(" + _x + ", " + _y + ", " + _z + ")";
        }

		public override bool Equals(object? obj)
		{
			if (obj is null)
            {
				return false;
            }
            else if (GetType() == obj.GetType())
			{
				Point3D other = (Point3D)obj;
				return X == other.X && Y == other.Y && Z == other.Z;
			}
			else
			{
				return false;
			}
        }

		public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public new Point3D Add(object? obj)
		{
			Point3D returnPoint = new Point3D();
			if (obj is null)
            {
				throw new NullReferenceException();
            }
            if (obj.GetType() == GetType())
			{
				Point3D other = (Point3D)obj;
				returnPoint.X = X + other.X;
				returnPoint.Y = Y + other.Y;
				returnPoint.Z = Z + other.Z;
				return returnPoint;
			}
			else
			{
				throw new Exception("can only add points to other points");
			}
        }
	}
}

