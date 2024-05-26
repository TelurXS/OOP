using System.Windows.Forms;

namespace Task2;

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();
		FirstThread = new Thread(new ThreadStart(DrawRectangle));
		SecondThread = new Thread(new ThreadStart(DrawElipse));
		ThirdThread = new Thread(new ThreadStart(GenerateNumbers));
	}

	private Thread FirstThread { get; }
	private Thread SecondThread { get; }
	private Thread ThirdThread { get; }

	private void DrawRectangle()
	{
		var graphics = Panel_First.CreateGraphics();

		while (true)
		{
			var width = Random.Shared.Next(Width);
			var height = Random.Shared.Next(Height);

			Thread.Sleep(40);
			graphics.DrawRectangle(Pens.Pink, 0, 0, width, height);
		}
	}

	private void DrawElipse()
	{
		var graphics = Panel_Second.CreateGraphics();

		while (true)
		{
			var width = Random.Shared.Next(Width);
			var height = Random.Shared.Next(Height);

			Thread.Sleep(40);
			graphics.DrawEllipse(Pens.Pink, 0, 0, width, height);
		}
	}

	private void GenerateNumbers()
	{
		Parallel.For(0, 500, i =>
		{
			RichTextBox.Invoke((MethodInvoker)delegate ()
			{
				RichTextBox.Text += Random.Shared.Next().ToString();
			});
		});
	}

	private void Button_First_Start_Click(object sender, EventArgs e)
	{
		FirstThread.Start();
	}

	private void Button_Second_Start_Click(object sender, EventArgs e)
	{
		SecondThread.Start();
	}

	private void Button_Third_Start_Click(object sender, EventArgs e)
	{
		ThirdThread.Start();
	}

	[Obsolete]
	private void Button_First_Stop_Click(object sender, EventArgs e)
	{
		FirstThread.Suspend();
	}

	[Obsolete]
	private void Button_Second_Stop_Click(object sender, EventArgs e)
	{
		SecondThread.Suspend();
	}

	[Obsolete]
	private void Button_Third_Stop_Click(object sender, EventArgs e)
	{
		FirstThread.Suspend();
	}

	private void Button_All_Start_Click(object sender, EventArgs e)
	{
		FirstThread.Start();
		SecondThread.Start();
		ThirdThread.Start();
	}

	[Obsolete]
	private void Button_All_Stop_Click(object sender, EventArgs e)
	{
		FirstThread.Suspend();
		SecondThread.Suspend();
		ThirdThread.Suspend();
	}
}