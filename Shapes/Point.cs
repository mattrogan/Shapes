﻿using System;

namespace Shapes
{
	public class Point
	{
		private float _x, _y; // Backing store

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

        public Point()
		{
			_x = 0;
			_y = 0;
		}

		public Point(float x, float y)
        {
			this._x = x;
			this._y = y;
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
}

