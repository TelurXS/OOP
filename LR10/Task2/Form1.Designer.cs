namespace Task2
{
	partial class Form1
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
			TableLayoutPanel = new TableLayoutPanel();
			Button_All_Stop = new Button();
			Button_All_Start = new Button();
			Button_Third_Stop = new Button();
			Button_Second_Stop = new Button();
			Button_First_Stop = new Button();
			Button_Third_Start = new Button();
			Button_Second_Start = new Button();
			Panel_Third = new Panel();
			RichTextBox_Third = new RichTextBox();
			Panel_First = new Panel();
			Panel_Second = new Panel();
			Button_First_Start = new Button();
			RichTextBox_Second = new RichTextBox();
			RichTextBox_First = new RichTextBox();
			TableLayoutPanel.SuspendLayout();
			Panel_Third.SuspendLayout();
			Panel_First.SuspendLayout();
			Panel_Second.SuspendLayout();
			SuspendLayout();
			// 
			// TableLayoutPanel
			// 
			TableLayoutPanel.ColumnCount = 3;
			TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
			TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
			TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
			TableLayoutPanel.Controls.Add(Button_All_Stop, 0, 4);
			TableLayoutPanel.Controls.Add(Button_All_Start, 0, 3);
			TableLayoutPanel.Controls.Add(Button_Third_Stop, 2, 2);
			TableLayoutPanel.Controls.Add(Button_Second_Stop, 1, 2);
			TableLayoutPanel.Controls.Add(Button_First_Stop, 0, 2);
			TableLayoutPanel.Controls.Add(Button_Third_Start, 2, 1);
			TableLayoutPanel.Controls.Add(Button_Second_Start, 1, 1);
			TableLayoutPanel.Controls.Add(Panel_Third, 2, 0);
			TableLayoutPanel.Controls.Add(Panel_First, 0, 0);
			TableLayoutPanel.Controls.Add(Panel_Second, 1, 0);
			TableLayoutPanel.Controls.Add(Button_First_Start, 0, 1);
			TableLayoutPanel.Dock = DockStyle.Fill;
			TableLayoutPanel.Location = new Point(0, 0);
			TableLayoutPanel.Name = "TableLayoutPanel";
			TableLayoutPanel.RowCount = 5;
			TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			TableLayoutPanel.Size = new Size(800, 450);
			TableLayoutPanel.TabIndex = 0;
			// 
			// Button_All_Stop
			// 
			Button_All_Stop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			TableLayoutPanel.SetColumnSpan(Button_All_Stop, 3);
			Button_All_Stop.Location = new Point(5, 415);
			Button_All_Stop.Margin = new Padding(5);
			Button_All_Stop.Name = "Button_All_Stop";
			Button_All_Stop.Size = new Size(790, 30);
			Button_All_Stop.TabIndex = 10;
			Button_All_Stop.Text = "Stop All Threads";
			Button_All_Stop.UseVisualStyleBackColor = true;
			Button_All_Stop.Click += Button_All_Stop_Click;
			// 
			// Button_All_Start
			// 
			Button_All_Start.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			TableLayoutPanel.SetColumnSpan(Button_All_Start, 3);
			Button_All_Start.Location = new Point(5, 375);
			Button_All_Start.Margin = new Padding(5);
			Button_All_Start.Name = "Button_All_Start";
			Button_All_Start.Size = new Size(790, 30);
			Button_All_Start.TabIndex = 9;
			Button_All_Start.Text = "Start All Threads";
			Button_All_Start.UseVisualStyleBackColor = true;
			Button_All_Start.Click += Button_All_Start_Click;
			// 
			// Button_Third_Stop
			// 
			Button_Third_Stop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Button_Third_Stop.Location = new Point(537, 335);
			Button_Third_Stop.Margin = new Padding(5);
			Button_Third_Stop.Name = "Button_Third_Stop";
			Button_Third_Stop.Size = new Size(258, 30);
			Button_Third_Stop.TabIndex = 8;
			Button_Third_Stop.Text = "Stop 3 Thread";
			Button_Third_Stop.UseVisualStyleBackColor = true;
			Button_Third_Stop.Click += Button_Third_Stop_Click;
			// 
			// Button_Second_Stop
			// 
			Button_Second_Stop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Button_Second_Stop.Location = new Point(271, 335);
			Button_Second_Stop.Margin = new Padding(5);
			Button_Second_Stop.Name = "Button_Second_Stop";
			Button_Second_Stop.Size = new Size(256, 30);
			Button_Second_Stop.TabIndex = 7;
			Button_Second_Stop.Text = "Stop 2 Thread";
			Button_Second_Stop.UseVisualStyleBackColor = true;
			Button_Second_Stop.Click += Button_Second_Stop_Click;
			// 
			// Button_First_Stop
			// 
			Button_First_Stop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Button_First_Stop.Location = new Point(5, 335);
			Button_First_Stop.Margin = new Padding(5);
			Button_First_Stop.Name = "Button_First_Stop";
			Button_First_Stop.Size = new Size(256, 30);
			Button_First_Stop.TabIndex = 6;
			Button_First_Stop.Text = "Stop 1 Thread";
			Button_First_Stop.UseVisualStyleBackColor = true;
			Button_First_Stop.Click += Button_First_Stop_Click;
			// 
			// Button_Third_Start
			// 
			Button_Third_Start.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Button_Third_Start.Location = new Point(537, 295);
			Button_Third_Start.Margin = new Padding(5);
			Button_Third_Start.Name = "Button_Third_Start";
			Button_Third_Start.Size = new Size(258, 30);
			Button_Third_Start.TabIndex = 5;
			Button_Third_Start.Text = "Start 3 Thread";
			Button_Third_Start.UseVisualStyleBackColor = true;
			Button_Third_Start.Click += Button_Third_Start_Click;
			// 
			// Button_Second_Start
			// 
			Button_Second_Start.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Button_Second_Start.Location = new Point(271, 295);
			Button_Second_Start.Margin = new Padding(5);
			Button_Second_Start.Name = "Button_Second_Start";
			Button_Second_Start.Size = new Size(256, 30);
			Button_Second_Start.TabIndex = 4;
			Button_Second_Start.Text = "Start 2 Thread";
			Button_Second_Start.UseVisualStyleBackColor = true;
			Button_Second_Start.Click += Button_Second_Start_Click;
			// 
			// Panel_Third
			// 
			Panel_Third.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Panel_Third.BorderStyle = BorderStyle.FixedSingle;
			Panel_Third.Controls.Add(RichTextBox_Third);
			Panel_Third.Location = new Point(537, 5);
			Panel_Third.Margin = new Padding(5);
			Panel_Third.Name = "Panel_Third";
			Panel_Third.Size = new Size(258, 280);
			Panel_Third.TabIndex = 2;
			// 
			// RichTextBox_Third
			// 
			RichTextBox_Third.Dock = DockStyle.Fill;
			RichTextBox_Third.Location = new Point(0, 0);
			RichTextBox_Third.Name = "RichTextBox_Third";
			RichTextBox_Third.Size = new Size(256, 278);
			RichTextBox_Third.TabIndex = 0;
			RichTextBox_Third.Text = "";
			// 
			// Panel_First
			// 
			Panel_First.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Panel_First.BorderStyle = BorderStyle.FixedSingle;
			Panel_First.Controls.Add(RichTextBox_First);
			Panel_First.Location = new Point(5, 5);
			Panel_First.Margin = new Padding(5);
			Panel_First.Name = "Panel_First";
			Panel_First.Size = new Size(256, 280);
			Panel_First.TabIndex = 1;
			// 
			// Panel_Second
			// 
			Panel_Second.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Panel_Second.BorderStyle = BorderStyle.FixedSingle;
			Panel_Second.Controls.Add(RichTextBox_Second);
			Panel_Second.Location = new Point(271, 5);
			Panel_Second.Margin = new Padding(5);
			Panel_Second.Name = "Panel_Second";
			Panel_Second.Size = new Size(256, 280);
			Panel_Second.TabIndex = 0;
			// 
			// Button_First_Start
			// 
			Button_First_Start.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Button_First_Start.Location = new Point(5, 295);
			Button_First_Start.Margin = new Padding(5);
			Button_First_Start.Name = "Button_First_Start";
			Button_First_Start.Size = new Size(256, 30);
			Button_First_Start.TabIndex = 3;
			Button_First_Start.Text = "Start 1 Thread";
			Button_First_Start.UseVisualStyleBackColor = true;
			Button_First_Start.Click += Button_First_Start_Click;
			// 
			// RichTextBox_Second
			// 
			RichTextBox_Second.Dock = DockStyle.Fill;
			RichTextBox_Second.Location = new Point(0, 0);
			RichTextBox_Second.Name = "RichTextBox_Second";
			RichTextBox_Second.Size = new Size(254, 278);
			RichTextBox_Second.TabIndex = 0;
			RichTextBox_Second.Text = "";
			// 
			// RichTextBox_First
			// 
			RichTextBox_First.Dock = DockStyle.Fill;
			RichTextBox_First.Location = new Point(0, 0);
			RichTextBox_First.Name = "RichTextBox_First";
			RichTextBox_First.Size = new Size(254, 278);
			RichTextBox_First.TabIndex = 0;
			RichTextBox_First.Text = "";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(TableLayoutPanel);
			Name = "Form1";
			Text = "Multithread Program";
			TableLayoutPanel.ResumeLayout(false);
			Panel_Third.ResumeLayout(false);
			Panel_First.ResumeLayout(false);
			Panel_Second.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel TableLayoutPanel;
		private Panel Panel_Third;
		private Panel Panel_First;
		private Panel Panel_Second;
		private Button Button_All_Stop;
		private Button Button_All_Start;
		private Button Button_Third_Stop;
		private Button Button_Second_Stop;
		private Button Button_First_Stop;
		private Button Button_Third_Start;
		private Button Button_Second_Start;
		private Button Button_First_Start;
		private RichTextBox RichTextBox_Third;
		private RichTextBox RichTextBox_First;
		private RichTextBox RichTextBox_Second;
	}
}
