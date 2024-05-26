using System.Drawing;
using System.Drawing.Drawing2D;

namespace LR9;

public partial class MainForm : Form
{
	private readonly Point _padding = new Point(5, 5);
	private readonly int _markPadding = 20;
	private readonly int _markSize = 5;
	private readonly int _pointsCount = 1000;

	public MainForm()
	{
		InitializeComponent();
	}

	private void Button_Draw_Click(object sender, EventArgs e)
	{
		var graphics = Panel_Graphics.CreateGraphics();
		graphics.CompositingQuality = CompositingQuality.HighQuality;

		graphics.Clear(Color.Silver);

		var axisPen = new Pen(Brushes.Black, 1);
		var graphicPen = new Pen(Brushes.Red, 2);

		var width = Panel_Graphics.ClientSize.Width;
		var height = Panel_Graphics.ClientSize.Height;

		DrawAxes(graphics, width, height, axisPen);
		DrawGraphic(graphics, width, height, graphicPen);
	}

	private void DrawAxes(Graphics graphics, int width, int height, Pen pen)
	{
		var x0 = width / 2;
		var y0 = height / 2;

		graphics.DrawLine(pen, new Point(0 + _padding.X, y0), new Point(width - _padding.X, y0));
		graphics.DrawLine(pen, new Point(x0, 0 + _padding.Y), new Point(x0, height - _padding.Y));


		// Negativex Axis
		foreach (var i in Enumerable.Range(1, x0 / _markPadding - 1)) 
		{
			var x = i * _markPadding + x0;
			graphics.DrawLine(pen, new Point(x, y0 - _markSize), new Point(x, y0 + _markSize));
			graphics.DrawString((-i).ToString(), Font, pen.Brush, new Point(width - x - _markSize * 2, y0 - _markSize * 5));
		}

		// Positive x Axis
		foreach (var i in Enumerable.Range(1, x0 / _markPadding - 1))
		{
			var x = i * _markPadding + x0;
			graphics.DrawLine(pen, new Point(width - x, y0 - _markSize), new Point(width - x, y0 + _markSize));
			graphics.DrawString(i.ToString(), Font, pen.Brush, new Point(x - _markSize, y0 + _markSize * 2));
		}

		// Negativex y Axis
		foreach (var i in Enumerable.Range(1, y0 / _markPadding - 1))
        {
			var y = i * _markPadding + y0;
			graphics.DrawLine(pen, new Point(x0 - _markSize, y), new Point(x0 + _markSize, y));
			graphics.DrawString((-i).ToString(), Font, pen.Brush, new Point(x0 - _markSize * 5, y - _markSize));
		}

		// Positive y Axis
		foreach (var i in Enumerable.Range(1, y0 / _markPadding - 1))
		{
			var y = i * _markPadding + y0;
			graphics.DrawLine(pen, new Point(x0 - _markSize, height - y), new Point(x0 + _markSize, height - y));
			graphics.DrawString(i.ToString(), Font, pen.Brush, new Point(x0 + _markSize * 2, height - y - _markSize));
		}

		graphics.DrawString("X", Font, pen.Brush, new Point(width - _padding.X - _markSize, y0 + _markSize * 2));
		graphics.DrawString("Y", Font, pen.Brush, new Point(x0 + _markSize * 2, 0 - _markSize + _padding.Y));


	}

	private void DrawGraphic(Graphics graphics, int width, int height, Pen pen)
	{
		int a = 0;
		int b = 0;
		int x0 = 0;
		int y0 = 0;

		try
		{
			a = _markPadding * int.Parse(TextBox_A.Text);
			b = _markPadding * int.Parse(TextBox_B.Text);
			x0 = width / 2 + _markPadding * int.Parse(TextBox_X0.Text);
			y0 = height / 2 - _markPadding * int.Parse(TextBox_Y0.Text);
		}
		catch
		{
			MessageBox.Show("Wrong parameters format");
			return;
		}

		double tMin = 0;
		double tMax = 2 * Math.PI;

		Point[] points = new Point[_pointsCount];

		for (int i = 0; i < _pointsCount; i++)
		{
			double t = tMin + i * (tMax - tMin) / _pointsCount;
			double x = x0 + a * Math.Cos(t);
			double y = y0 + b * Math.Sin(t);
			points[i] = (new Point((int)x, (int)y));
		}

		graphics.DrawLines(pen, points);
	}
}
