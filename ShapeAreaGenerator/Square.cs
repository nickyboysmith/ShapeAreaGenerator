using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaGenerator
{

	public class Square : Shape, ILogger
	{
		private float _length;

		public Square(float length)
		{
			_length = length;
		}

		public float Length
		{
			get { return _length; }
			set { _length = value; }
		}

		public override void CalculateArea()
		{
			this.Area = _length * _length;	
		}

        public void DisplayOutput()
        {
			Console.WriteLine(this.GetType().Name + " Area " + this.Area);
		}

        public void WriteToLog()
        {
			string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			string[] lines = { this.GetType().Name + " " + _length + " : " + "Area " + this.Area };
			File.AppendAllLines(Path.Combine(docPath, "ShapeAreaGeneratorLog.txt"), lines);
		}

    }
}
