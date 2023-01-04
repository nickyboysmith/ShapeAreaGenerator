using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShapeAreaGenerator
{
	public class Sphere : Shape, ILogger
	{
		private float _radius;

		public Sphere(float radius)
		{
			_radius = radius;
		}

		public float Radius
		{
			get { return _radius; }
			set { _radius = value; }
		}

		public override void CalculateArea()
		{
			this.Area = (float)((_radius * _radius) * Math.PI * 4);

		}

		public void DisplayOutput()
		{
			Console.WriteLine(this.GetType().Name + " Area " + this.Area);
		}

		public void WriteToLog()
		{
			string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			string[] lines = { this.GetType().Name + " " + _radius + " : " + "Area " + this.Area };
			File.AppendAllLines(Path.Combine(docPath, "ShapeAreaGeneratorLog.txt"), lines);
		}

	}
}
