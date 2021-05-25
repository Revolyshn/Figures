using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp5
{
    class Rhomb:Shape
    {
		public Rhomb(Point[] p) : base(p)
		{
			if (p.Length != 4)
			{
				ERROR("ОШИБКА");
			}
		}
	}
}
