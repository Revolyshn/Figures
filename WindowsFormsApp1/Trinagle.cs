using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	class Trinagle : Shape
	{

		public Trinagle
			(
			string name,
			string color,
			double widthOfLine,
			string colorOfLine

			) : base(name, color, widthOfLine, colorOfLine)
		{

		}

		public Trinagle(Point Dote1, Point Dote2, Point Dote3)
		{
			dotes.Add(new Point(Dote1.X, Dote1.Y));
			dotes.Add(new Point(Dote2.X, Dote2.Y));
			dotes.Add(new Point(Dote3.X, Dote3.Y));
		}


		public override void addDote(int x, int y, int amountOfDotes)
		{
			if (dotes.Count < amountOfDotes)
			{
				dotes.Add(new Point(x, y));
			}

		}
		public override Point[] GetPoints(List<Point> dotes)
		{
			return dotes.ToArray();
		}

		public override void Draw(List<Point> dotes, double widthOfLine, string colorOfLine)
		{


		}

	}
}
