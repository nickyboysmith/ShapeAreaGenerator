
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShapeAreaGenerator
{

	public class Rectangle : Shape, ILogger	{

		private float _length;
		private float _width;

		public Rectangle(float length, float width){
			_length = length;
			_width = width;
		}

		public float Length
		{
			get { return _length; }
			set { _length = value; }
		}

		public float Width{
			get{ return _width; }
			set{ _width = value; }
		}
		
		public override void CalculateArea(){
			this.Area = _length * _width;	
		}

		public void DisplayOutput()
		{
			Console.WriteLine(this.GetType().Name + " Area " + this.Area);
		}

		public void WriteToLog()
		{
			string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			string[] lines = { this.GetType().Name + " " + _length + " " + _width + " : " + "Area " + this.Area };
			File.AppendAllLines(Path.Combine(docPath, "ShapeAreaGeneratorLog.txt"), lines);
		}

	}
}
