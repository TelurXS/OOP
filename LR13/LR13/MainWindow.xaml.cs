using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LR13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeDrives();
            InitializeDirectories();
        }

        private DriveInfo[] Drives { get; set; } = DriveInfo.GetDrives();
        private Stack<string> PathHistory { get; set; } = new();

        private void InitializeDrives()
        {
            ListBox_Drives.Items.Clear();

            foreach (var drive in Drives)
            {
                if (drive.IsReady)
                {
                    var name = drive.Name;
                    var label = drive.VolumeLabel;
                    var space = Math.Round(((double)(drive.TotalSize - drive.AvailableFreeSpace) / drive.TotalSize) * 100);
                    ListBox_Drives.Items.Add($"{name} ({label}) [{space}%]");
                }
                else
                {
                    ListBox_Drives.Items.Add($"{drive.Name}");
                }
            }
        }

        private void InitializeDirectories()
        {
            ListBox_Files.Items.Clear();

            if (string.IsNullOrEmpty(TextBox_Path.Text))
                return;

            foreach (var directory in Directory.GetDirectories(TextBox_Path.Text))
            {
                var info = new DirectoryInfo(directory);

                ListBox_Files.Items.Add(info.Name);
            }

            foreach (var file in Directory.GetFiles(TextBox_Path.Text))
            {
                var info = new FileInfo(file);

                ListBox_Files.Items.Add(info.Name);
            }
        }

        private void ListBox_Drives_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var drive = Drives[ListBox_Drives.SelectedIndex];
            TextBox_Path.Text = drive.Name;
            PathHistory.Push(TextBox_Path.Text);
            InitializeDirectories();
        }

        private void ListBox_Files_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var directory = ListBox_Files.SelectedItem.ToString();
            TextBox_Path.Text += $"{directory}\\";
            PathHistory.Push(TextBox_Path.Text);
            InitializeDirectories();
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            if (PathHistory.Count <= 0)
                return;

            while (true)
            {
                var path = PathHistory.Pop();

                if (path.Equals(TextBox_Path.Text))
                    continue;

                TextBox_Path.Text = path;
                break;
            }
            
            InitializeDirectories();
        }

        private void Disks_Menu_Properties_Click(object sender, RoutedEventArgs e)
        {
            var drive = Drives[ListBox_Drives.SelectedIndex];
            var builder = new StringBuilder();

            builder.AppendLine($"Name: {drive.Name}");
            builder.AppendLine($"Label: {drive.VolumeLabel}");
            builder.AppendLine($"Total: {drive.TotalSize}B");
            builder.AppendLine($"Available: {drive.TotalFreeSpace}B");

            MessageBox.Show(builder.ToString(), "Properties", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Files_Menu_Properties_Click(object sender, RoutedEventArgs e)
        {
            var selected = ListBox_Files.SelectedItem.ToString();
            var path = TextBox_Path.Text + selected;
            var builder = new StringBuilder();

            if (File.Exists(path))
            {
                var info = new FileInfo(path);

                builder.AppendLine($"Name: {info.Name}");
                builder.AppendLine($"Created: {info.CreationTime}");
                builder.AppendLine($"Size: {info.Length}B");
            }

            if (Directory.Exists(path))
            {
                var info = new DirectoryInfo(path);

                builder.AppendLine($"Name: {info.Name}");
                builder.AppendLine($"Created: {info.CreationTime}");
                builder.AppendLine($"Root: {info.Root}");
            }

            MessageBox.Show(builder.ToString(), "Properties", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}