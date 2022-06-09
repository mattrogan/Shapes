using System;
namespace Shapes
{
	public abstract class Shape
	{

		public string _colour;

		public bool _filled;

        public Shape() { }

        public Shape(string colour, bool filled)
        {
            _colour = colour;
            _filled = filled;
        }

		public abstract bool isFilled();

		public abstract void setFilled(bool filled);

		public abstract float getArea();

		public abstract float getPerimeter();

	}

    public class Rectangle : Shape
    {

        protected float _width, _length;

        public Rectangle() : base() { }

        public Rectangle(float width, float length)
        {
            _width = width;
            _length = length;
        }

        public Rectangle(float width, float length, string colour, bool filled) : base(colour, filled)
        {
            _width = width;
            _length = length;
        }

        public override float getArea()
        {
            throw new NotImplementedException();
        }

        public override float getPerimeter()
        {
            throw new NotImplementedException();
        }

        public override bool isFilled()
        {
            throw new NotImplementedException();
        }

        public override void setFilled(bool filled)
        {
            throw new NotImplementedException();
        }
    }
}
