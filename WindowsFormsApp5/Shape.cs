using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp5
{
	class Shape
	{
		private List<Point> list = new List<Point>();

		public Shape(Point[] p)
		{
			for (int i = 0; i < p.Length; i++)
			{
				list.Add(p[i]);
			}
			if (p.Length == 0)
			{
				ERROR("ОШИБКА");
				
			}
		}

		public Point[] getPoint()
		{
			return list.ToArray();
		}
		public void ERROR(string error)
		{
			MessageBox.Show(error);
			throw new Exception(error);
		}
	}
}
