using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShapeAreaGenerator
{
    public class Triangle : Shape, ILogger
    {
		private float _width;
		private float _height;

		public Triangle(float width, float height)
		{
			_width = width;
			_height = height;
		}

		public float Width
		{
			get { return _width; }
			set { _width = value; }
		}

		public float Height
		{
			get { return _height; }
			set { _height = value; }
		}

		public override void CalculateArea()
		{
			this.Area = (_width * _height) / 2;
		}

		public void DisplayOutput()
		{
			Console.WriteLine(this.GetType().Name + " Area " + this.Area);
		}

		public void WriteToLog()
		{
			string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			string[] lines = { this.GetType().Name + " " + _width + " " + _height + " : " + "Area " + this.Area };
			File.AppendAllLines(Path.Combine(docPath, "ShapeAreaGeneratorLog.txt"), lines);
		}
	}
}
