namespace LR9
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Panel_Graphics = new Panel();
			panel1 = new Panel();
			TextBox_Y0 = new TextBox();
			Label_Y0 = new Label();
			TextBox_X0 = new TextBox();
			Label_X0 = new Label();
			Button_Draw = new Button();
			TextBox_B = new TextBox();
			Label_B = new Label();
			TextBox_A = new TextBox();
			Label_A = new Label();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// Panel_Graphics
			// 
			Panel_Graphics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Panel_Graphics.BackColor = Color.Silver;
			Panel_Graphics.Location = new Point(0, 0);
			Panel_Graphics.Name = "Panel_Graphics";
			Panel_Graphics.Size = new Size(583, 461);
			Panel_Graphics.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.Controls.Add(TextBox_Y0);
			panel1.Controls.Add(Label_Y0);
			panel1.Controls.Add(TextBox_X0);
			panel1.Controls.Add(Label_X0);
			panel1.Controls.Add(Button_Draw);
			panel1.Controls.Add(TextBox_B);
			panel1.Controls.Add(Label_B);
			panel1.Controls.Add(TextBox_A);
			panel1.Controls.Add(Label_A);
			panel1.Dock = DockStyle.Right;
			panel1.Location = new Point(584, 0);
			panel1.Name = "panel1";
			panel1.Padding = new Padding(5);
			panel1.Size = new Size(200, 461);
			panel1.TabIndex = 1;
			// 
			// TextBox_Y0
			// 
			TextBox_Y0.Dock = DockStyle.Top;
			TextBox_Y0.Location = new Point(5, 134);
			TextBox_Y0.Name = "TextBox_Y0";
			TextBox_Y0.Size = new Size(190, 23);
			TextBox_Y0.TabIndex = 8;
			// 
			// Label_Y0
			// 
			Label_Y0.AutoSize = true;
			Label_Y0.Dock = DockStyle.Top;
			Label_Y0.Location = new Point(5, 119);
			Label_Y0.Margin = new Padding(5);
			Label_Y0.Name = "Label_Y0";
			Label_Y0.Size = new Size(33, 15);
			Label_Y0.TabIndex = 7;
			Label_Y0.Text = "y0 = ";
			// 
			// TextBox_X0
			// 
			TextBox_X0.Dock = DockStyle.Top;
			TextBox_X0.Location = new Point(5, 96);
			TextBox_X0.Name = "TextBox_X0";
			TextBox_X0.Size = new Size(190, 23);
			TextBox_X0.TabIndex = 6;
			// 
			// Label_X0
			// 
			Label_X0.AutoSize = true;
			Label_X0.Dock = DockStyle.Top;
			Label_X0.Location = new Point(5, 81);
			Label_X0.Margin = new Padding(5);
			Label_X0.Name = "Label_X0";
			Label_X0.Size = new Size(33, 15);
			Label_X0.TabIndex = 5;
			Label_X0.Text = "x0 = ";
			// 
			// Button_Draw
			// 
			Button_Draw.Dock = DockStyle.Bottom;
			Button_Draw.Location = new Point(5, 433);
			Button_Draw.Margin = new Padding(20);
			Button_Draw.Name = "Button_Draw";
			Button_Draw.Size = new Size(190, 23);
			Button_Draw.TabIndex = 4;
			Button_Draw.Text = "Draw";
			Button_Draw.UseVisualStyleBackColor = true;
			Button_Draw.Click += Button_Draw_Click;
			// 
			// TextBox_B
			// 
			TextBox_B.Dock = DockStyle.Top;
			TextBox_B.Location = new Point(5, 58);
			TextBox_B.Name = "TextBox_B";
			TextBox_B.Size = new Size(190, 23);
			TextBox_B.TabIndex = 3;
			// 
			// Label_B
			// 
			Label_B.AutoSize = true;
			Label_B.Dock = DockStyle.Top;
			Label_B.Location = new Point(5, 43);
			Label_B.Name = "Label_B";
			Label_B.Size = new Size(28, 15);
			Label_B.TabIndex = 2;
			Label_B.Text = "b = ";
			// 
			// TextBox_A
			// 
			TextBox_A.Dock = DockStyle.Top;
			TextBox_A.Location = new Point(5, 20);
			TextBox_A.Margin = new Padding(20);
			TextBox_A.Name = "TextBox_A";
			TextBox_A.Size = new Size(190, 23);
			TextBox_A.TabIndex = 1;
			// 
			// Label_A
			// 
			Label_A.AutoSize = true;
			Label_A.Dock = DockStyle.Top;
			Label_A.Location = new Point(5, 5);
			Label_A.Margin = new Padding(5);
			Label_A.Name = "Label_A";
			Label_A.Size = new Size(27, 15);
			Label_A.TabIndex = 0;
			Label_A.Text = "a = ";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(784, 461);
			Controls.Add(panel1);
			Controls.Add(Panel_Graphics);
			Name = "MainForm";
			Text = "Graphics";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel Panel_Graphics;
		private Panel panel1;
		private Button Button_Draw;
		private TextBox TextBox_B;
		private Label Label_B;
		private TextBox TextBox_A;
		private Label Label_A;
		private TextBox TextBox_Y0;
		private Label Label_Y0;
		private TextBox TextBox_X0;
		private Label Label_X0;
	}
}
