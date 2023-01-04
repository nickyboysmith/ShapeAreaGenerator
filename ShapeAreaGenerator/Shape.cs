using System;

namespace ShapeAreaGenerator
{

	public abstract class Shape {

		private float _area;

		public float Area
		{
			get{ return _area; }
			set{ _area = value; }
		}

		public abstract void CalculateArea();
    
    }
}
