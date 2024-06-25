using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
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

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private TcpClient Client { get; set; }
        private NetworkStream Stream { get; set; }

        private IPAddress Address { get; set; }
        private int Port { get; set; }
        private string Username { get; set; }

        private bool IsConnected {  get; set; }

        private void Button_Join_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TextBox_Ip.IsReadOnly = true;
                TextBox_Port.IsReadOnly = true;
                TextBox_Name.IsReadOnly = true;
                Button_Join.IsEnabled = false;

                Address = IPAddress.Parse(TextBox_Ip.Text);
                Port = int.Parse(TextBox_Port.Text);
                Username = TextBox_Name.Text;

                Client = new TcpClient(Address.ToString(), Port);
                Stream = Client.GetStream();

                ListBox_Messages.Items.Add("Connected to server...");

                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
                Client?.Close();
                Stream?.Close();
                TextBox_Ip.IsReadOnly = false;
                TextBox_Port.IsReadOnly = false;
                TextBox_Name.IsReadOnly = false;
                Button_Join.IsEnabled = true;
            }
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];

            IsConnected = true;

            while (IsConnected)
            {
                int bytesRead = Stream.Read(buffer);

                if (bytesRead <= 0)
                {
                    Dispatcher.Invoke(() =>
                    {
                        ListBox_Messages.Items.Add("Disconnected from server!");
                        IsConnected = false;
                    });
                    break;
                }

                string message = Encoding.UTF8.GetString(buffer);

                Dispatcher.Invoke(() =>
                {
                    var time = DateTime.Now.ToShortTimeString();
                    ListBox_Messages.Items.Add($"{message}");
                });
            }
        }

        private void Button_Send_Click(object sender, RoutedEventArgs e)
        {
            if (IsConnected is false)
                return;

            var message = TextBox_Message.Text;
            var time = DateTime.Now.ToShortTimeString();

            var formatted = $"[{time}] {Username}: {message}";
            byte[] data = Encoding.UTF8.GetBytes(formatted);
            Stream.Write(data);

            ListBox_Messages.Items.Add(formatted);
            TextBox_Message.Clear();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            var builder = new StringBuilder();

            foreach (var item in ListBox_Messages.Items)
            {
                builder.AppendLine(item.ToString());
            }

            File.WriteAllText("logs.txt", builder.ToString());

            MessageBox.Show("Saved");
        }
    }
}