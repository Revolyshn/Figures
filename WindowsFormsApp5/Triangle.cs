using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp5
{
	class Triangle:Shape
	{

		public Triangle(Point[] p) : base(p)
		{
			if(p.Length != 3)
			{
				ERROR("ОШИБКА");
			}
		}
	}
}
