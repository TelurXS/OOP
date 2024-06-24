using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Shapes;

namespace LR16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int TTL = 20;

        public MainWindow()
        {
            InitializeComponent();
        }

        private bool Alive { get; set; }
        private UdpClient? Client { get; set; }

        private string Username { get; set; } = string.Empty;
        private IPAddress Ip { get; set; } = IPAddress.Any;
        private int Port { get; set; } = default;

        private void Button_Join_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TextBox_Ip.IsReadOnly = true;
                TextBox_Port.IsReadOnly = true;
                TextBox_Name.IsReadOnly = true;
                Button_Join.IsEnabled = false;

                Username = TextBox_Name.Text;
                Ip = IPAddress.Parse(TextBox_Ip.Text);
                Port = int.Parse(TextBox_Port.Text);

                Client = new UdpClient(Port);
                Client.JoinMulticastGroup(Ip, TTL);

                Task receiveThread = new Task(ReceiveMessages);
                receiveThread.Start();

                Send(Username + " enters the room");        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
                TextBox_Ip.IsReadOnly = false;
                TextBox_Port.IsReadOnly = false;
                TextBox_Name.IsReadOnly = false;
                Button_Join.IsEnabled = true;
            }
        }

        private void Button_Send_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string message = $"{Username}: {TextBox_Message.Text}";
                Send(message);
                TextBox_Message.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitChat()
        {
            if (Client is null || Alive is false)
                return;

            string message = Username + " leave";
            Send(message);

            Client.DropMulticastGroup(Ip);
            Client.Close();

            Alive = false;
            TextBox_Ip.IsReadOnly = false;
            TextBox_Port.IsReadOnly = false;
            TextBox_Name.IsReadOnly = false;
            Button_Join.IsEnabled = true;
        }

        private void ReceiveMessages()
        {
            Alive = true;

            try
            {
                while (Alive)
                {
                    IPEndPoint remoteIp = null;
                    var data = Client!.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);

                    Dispatcher.Invoke(() =>
                    {
                        var time = DateTime.Now.ToShortTimeString();
                        ListBox_Messages.Items.Add(time + " " + message);
                    });
                }
            }
            catch (ObjectDisposedException)
            {
                if (!Alive)
                    return;
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Send(string message)
        {
            if (Client is null)
                return;

            var data = Encoding.Unicode.GetBytes(message);
            Client.Send(data, data.Length, Ip.ToString(), Port);
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