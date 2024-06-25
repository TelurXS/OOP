using System.Diagnostics;
using System.Threading;

namespace ProcessManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public List<Process> Processes { get; set; } = new();

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            ListBox_Proccesses.Items.Clear();
            Processes.Clear();
            Processes.AddRange(Process.GetProcesses());

            Label_ProcessesCount.Text = $"({Processes.Count})";

            foreach (var process in Processes)
                ListBox_Proccesses.Items.Add($"{process.Id} {process.ProcessName}");
        }

        private void ListBox_Proccesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListBox_Threads.Items.Clear();
                ListBox_Modules.Items.Clear();
                Process selected = Processes[ListBox_Proccesses.SelectedIndex];

                var threads = selected.Threads;
                var modules = selected.Modules;

                Label_ThreadsCount.Text = $"({threads.Count})";
                Label_ModulesCount.Text = $"({modules.Count})";

                foreach (ProcessThread thread in threads)
                    ListBox_Threads.Items.Add($"{thread.Id} {thread.BasePriority}");

                foreach (ProcessModule module in modules)
                    ListBox_Modules.Items.Add($"{module.FileName}");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            var form = new RunProcessForm();
            form.ShowDialog();

            string fileName = form.FileName;
            string arguments = form.Arguments;

            if (File.Exists(fileName) is false) 
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = fileName, 
                Arguments = arguments,
                UseShellExecute = true,
            };

            Process.Start(info);
        }

        private void Button_Kill_Click(object sender, EventArgs e)
        {
            var index = ListBox_Proccesses.SelectedIndex;
            var process = Processes[index];
            process.Kill();
        }
    }
}