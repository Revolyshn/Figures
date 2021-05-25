using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp1
{
	class Rectangle : Shape
	{



		public Rectangle
			(
			string name,
			string color,
			double widthOfLine,
			string colorOfLine

			) : base(name, color, widthOfLine, colorOfLine)
		{

		}

		public Rectangle(Point Dote1, Point Dote2, Point Dote3, Point Dote4)
		{
			dotes.Add(new Point(Dote1.X, Dote1.Y));
			dotes.Add(new Point(Dote2.X, Dote2.Y));
			dotes.Add(new Point(Dote3.X, Dote3.Y));
			dotes.Add(new Point(Dote4.X, Dote4.Y));

		}


		public override void addDote(int x, int y, int amountOfDotes)
		{
			if (dotes.Count < amountOfDotes)
			{
				dotes.Add(new Point(x, y));
			}

		}

		public override void Draw(List<Point> dotes, double widthOfLine, string colorOfLine)
		{


		}

		public override Point[] GetPoints (List<Point> dotes)
		{
			return dotes.ToArray();
		}

			

	}
}
