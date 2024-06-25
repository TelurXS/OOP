using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessManager
{
    public partial class RunProcessForm : Form
    {
        public RunProcessForm()
        {
            InitializeComponent();

            FileName = string.Empty;
            Arguments = string.Empty;
        }

        public string FileName { get; private set; }
        public string Arguments { get; private set; }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            FileName = TextBox_FileName.Text;
            Arguments = TextBox_Arguments.Text;

            Close();
        }

        private void Button_Select_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() is DialogResult.OK)
            {
                FileName = OpenFileDialog.FileName;
                TextBox_FileName.Text = FileName;
            }
        }
    }
}
