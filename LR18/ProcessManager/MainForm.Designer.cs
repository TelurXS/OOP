namespace ProcessManager
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
            panel1 = new Panel();
            panel2 = new Panel();
            Label_ProcessesCount = new Label();
            label1 = new Label();
            ListBox_Proccesses = new ListBox();
            Button_Refresh = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            Label_ThreadsCount = new Label();
            label4 = new Label();
            ListBox_Threads = new ListBox();
            panel5 = new Panel();
            panel6 = new Panel();
            Label_ModulesCount = new Label();
            label8 = new Label();
            ListBox_Modules = new ListBox();
            Button_Run = new Button();
            Button_Kill = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ListBox_Proccesses);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(235, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(Label_ProcessesCount);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 43);
            panel2.TabIndex = 2;
            // 
            // Label_ProcessesCount
            // 
            Label_ProcessesCount.AutoSize = true;
            Label_ProcessesCount.Font = new Font("Segoe UI", 18F);
            Label_ProcessesCount.Location = new Point(114, 4);
            Label_ProcessesCount.Name = "Label_ProcessesCount";
            Label_ProcessesCount.Size = new Size(41, 32);
            Label_ProcessesCount.TabIndex = 3;
            Label_ProcessesCount.Text = "(0)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(7, 4);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 2;
            label1.Text = "Processes";
            // 
            // ListBox_Proccesses
            // 
            ListBox_Proccesses.Dock = DockStyle.Bottom;
            ListBox_Proccesses.FormattingEnabled = true;
            ListBox_Proccesses.ItemHeight = 15;
            ListBox_Proccesses.Location = new Point(5, 51);
            ListBox_Proccesses.Name = "ListBox_Proccesses";
            ListBox_Proccesses.Size = new Size(225, 394);
            ListBox_Proccesses.TabIndex = 1;
            ListBox_Proccesses.SelectedIndexChanged += ListBox_Proccesses_SelectedIndexChanged;
            // 
            // Button_Refresh
            // 
            Button_Refresh.Location = new Point(713, 7);
            Button_Refresh.Name = "Button_Refresh";
            Button_Refresh.Size = new Size(75, 23);
            Button_Refresh.TabIndex = 1;
            Button_Refresh.Text = "Refresh";
            Button_Refresh.UseVisualStyleBackColor = true;
            Button_Refresh.Click += Button_Refresh_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(ListBox_Threads);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(235, 0);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(235, 450);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(Label_ThreadsCount);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(5, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 43);
            panel4.TabIndex = 2;
            // 
            // Label_ThreadsCount
            // 
            Label_ThreadsCount.AutoSize = true;
            Label_ThreadsCount.Font = new Font("Segoe UI", 18F);
            Label_ThreadsCount.Location = new Point(99, 4);
            Label_ThreadsCount.Name = "Label_ThreadsCount";
            Label_ThreadsCount.Size = new Size(41, 32);
            Label_ThreadsCount.TabIndex = 3;
            Label_ThreadsCount.Text = "(0)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(7, 4);
            label4.Name = "label4";
            label4.Size = new Size(98, 32);
            label4.TabIndex = 2;
            label4.Text = "Threads";
            // 
            // ListBox_Threads
            // 
            ListBox_Threads.Dock = DockStyle.Bottom;
            ListBox_Threads.FormattingEnabled = true;
            ListBox_Threads.ItemHeight = 15;
            ListBox_Threads.Location = new Point(5, 51);
            ListBox_Threads.Name = "ListBox_Threads";
            ListBox_Threads.Size = new Size(225, 394);
            ListBox_Threads.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(ListBox_Modules);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(470, 0);
            panel5.Margin = new Padding(5);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5);
            panel5.Size = new Size(235, 450);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(Label_ModulesCount);
            panel6.Controls.Add(label8);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(5, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(225, 43);
            panel6.TabIndex = 2;
            // 
            // Label_ModulesCount
            // 
            Label_ModulesCount.AutoSize = true;
            Label_ModulesCount.Font = new Font("Segoe UI", 18F);
            Label_ModulesCount.Location = new Point(106, 4);
            Label_ModulesCount.Name = "Label_ModulesCount";
            Label_ModulesCount.Size = new Size(41, 32);
            Label_ModulesCount.TabIndex = 3;
            Label_ModulesCount.Text = "(0)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F);
            label8.Location = new Point(7, 4);
            label8.Name = "label8";
            label8.Size = new Size(107, 32);
            label8.TabIndex = 2;
            label8.Text = "Modules";
            // 
            // ListBox_Modules
            // 
            ListBox_Modules.Dock = DockStyle.Bottom;
            ListBox_Modules.FormattingEnabled = true;
            ListBox_Modules.ItemHeight = 15;
            ListBox_Modules.Location = new Point(5, 51);
            ListBox_Modules.Name = "ListBox_Modules";
            ListBox_Modules.Size = new Size(225, 394);
            ListBox_Modules.TabIndex = 1;
            // 
            // Button_Run
            // 
            Button_Run.Location = new Point(713, 36);
            Button_Run.Name = "Button_Run";
            Button_Run.Size = new Size(75, 23);
            Button_Run.TabIndex = 5;
            Button_Run.Text = "Run";
            Button_Run.UseVisualStyleBackColor = true;
            Button_Run.Click += Button_Run_Click;
            // 
            // Button_Kill
            // 
            Button_Kill.Location = new Point(713, 65);
            Button_Kill.Name = "Button_Kill";
            Button_Kill.Size = new Size(75, 23);
            Button_Kill.TabIndex = 6;
            Button_Kill.Text = "Kill";
            Button_Kill.UseVisualStyleBackColor = true;
            Button_Kill.Click += Button_Kill_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Button_Kill);
            Controls.Add(Button_Run);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(Button_Refresh);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            Text = "Process Manager";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox ListBox_Proccesses;
        private Button Button_Refresh;
        private Panel panel2;
        private Label Label_ProcessesCount;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Label Label_ThreadsCount;
        private Label label4;
        private ListBox ListBox_Threads;
        private Panel panel5;
        private Panel panel6;
        private Label Label_ModulesCount;
        private Label label8;
        private ListBox ListBox_Modules;
        private Button Button_Run;
        private Button Button_Kill;
    }
}