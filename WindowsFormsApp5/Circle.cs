using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp5
{
	class Circle:Shape
	{
		public float radius { get; }
		public Circle(Point[] p,float radius, Color color) : base(p, color)
		{
			this.radius = radius;
			if (p.Length != 1)
			{
				ERROR("ОШИБКА");
			}
		}

	}
}
