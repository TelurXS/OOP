namespace ProcessManager
{
    partial class RunProcessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_FileName = new System.Windows.Forms.TextBox();
            this.TextBox_Arguments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Run = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Button_Select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_FileName
            // 
            this.TextBox_FileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_FileName.Location = new System.Drawing.Point(12, 33);
            this.TextBox_FileName.Name = "TextBox_FileName";
            this.TextBox_FileName.Size = new System.Drawing.Size(260, 29);
            this.TextBox_FileName.TabIndex = 0;
            // 
            // TextBox_Arguments
            // 
            this.TextBox_Arguments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Arguments.Location = new System.Drawing.Point(12, 120);
            this.TextBox_Arguments.Name = "TextBox_Arguments";
            this.TextBox_Arguments.Size = new System.Drawing.Size(260, 29);
            this.TextBox_Arguments.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arguments";
            // 
            // Button_Run
            // 
            this.Button_Run.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Run.Location = new System.Drawing.Point(12, 308);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(260, 41);
            this.Button_Run.TabIndex = 4;
            this.Button_Run.Text = "Run";
            this.Button_Run.UseVisualStyleBackColor = true;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // Button_Select
            // 
            this.Button_Select.Location = new System.Drawing.Point(12, 68);
            this.Button_Select.Name = "Button_Select";
            this.Button_Select.Size = new System.Drawing.Size(260, 25);
            this.Button_Select.TabIndex = 5;
            this.Button_Select.Text = "Select";
            this.Button_Select.UseVisualStyleBackColor = true;
            this.Button_Select.Click += new System.EventHandler(this.Button_Select_Click);
            // 
            // RunProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.Button_Select);
            this.Controls.Add(this.Button_Run);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Arguments);
            this.Controls.Add(this.TextBox_FileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RunProcessForm";
            this.Text = "Run Process";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBox_FileName;
        private TextBox TextBox_Arguments;
        private Label label1;
        private Label label2;
        private Button Button_Run;
        private OpenFileDialog OpenFileDialog;
        private Button Button_Select;
    }
}