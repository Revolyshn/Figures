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
	public partial class Form1 : Form
	{
		public static Point[] p;
		public Form1()
		{
			InitializeComponent();
		
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

			Triangle triangle = new Triangle(new Point[] { new Point(250, 0), new Point(250, 200), new Point(400, 0)}, Color.YellowGreen);
			Square square = new Square(new Point[] { new Point(1, 1), new Point(200, 1), new Point(200, 200), new Point(1,200)}, Color.Red);
			Circle circle = new Circle(new Point[] { new Point(400, 0)},200, Color.Cyan);
			
			Graphics g = pictureBox1.CreateGraphics();
			

			SolidBrush m = new SolidBrush(Color.Black);
			Pen p = new Pen(Color.Aqua,5);
			Pen p2 = new Pen(Color.IndianRed, 5);
			Pen p3 = new Pen(Color.Indigo, 5);
			Point[] curve = square.getPoint();
			Point[] curve2 = triangle.getPoint();
			Point[] curve3 = circle.getPoint();
			g.DrawPolygon(p, curve);
			g.DrawPolygon(p2, curve2);
			g.DrawEllipse(p3, curve3[0].X,curve3[0].Y,circle.radius,circle.radius);

		}
	}
}
