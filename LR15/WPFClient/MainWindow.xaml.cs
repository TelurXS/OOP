using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using WinForms = System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

namespace WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string HOST = "ftp://ftp.dlptest.com/";
        private const string USERNAME = "dlpuser";
        private const string PASSWORD = "rNrKYTX9g7z3RgJRmxWuGHbeu";

        private static readonly Dictionary<string, string> METHODS = new()
        {
            { "List", WebRequestMethods.Ftp.ListDirectory },
            { "Delete", WebRequestMethods.Ftp.DeleteFile },
            { "Upload", WebRequestMethods.Ftp.UploadFile },
            { "Download", WebRequestMethods.Ftp.DownloadFile },
            { "Remove", WebRequestMethods.Ftp.RemoveDirectory },
            { "Make", WebRequestMethods.Ftp.MakeDirectory },
        };

        public MainWindow()
        {
            InitializeComponent();

            foreach (var key in METHODS.Keys) 
            {
                ComboBox_Method.Items.Add(key);
            }
        }

        private string GetMethod(string key)
        {
            return METHODS[key];
        }

        private FtpWebRequest CreateRequest(string path, string method)
        {
            var uri = new Uri(HOST + path);
            var request = WebRequest.Create(uri) as FtpWebRequest;

            if (request is null)
                throw new ArgumentException();

            request.Credentials = new NetworkCredential(USERNAME, PASSWORD);
            request.Method = method;

            return request;
        }

        private void Button_Apply_Click(object sender, RoutedEventArgs e)
        {
            var path = TextBox_Path.Text;
            var method = GetMethod(ComboBox_Method.SelectedItem.ToString()!);
            var request = CreateRequest(path, method);

            switch (method)
            {
                case WebRequestMethods.Ftp.UploadFile:
                    HandleFileUploadRequest(request);
                    break;
            }

            try
            {
                var response = (FtpWebResponse)request.GetResponse();

                switch (method)
                {
                    case WebRequestMethods.Ftp.ListDirectory:
                        HandleListDirectory(response);
                        break;

                    case WebRequestMethods.Ftp.DeleteFile:
                        HandleDeleteFile(response);
                        break;

                    case WebRequestMethods.Ftp.MakeDirectory:
                        HandleMakeDirectory(response);
                        break;

                    case WebRequestMethods.Ftp.DownloadFile:
                        HandleDownloadFile(response);
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void HandleDownloadFile(FtpWebResponse response)
        {
            var dialog = new FolderBrowserDialog();

            var result = dialog.ShowDialog();

            if (result is WinForms.DialogResult.OK)
            {
                var path = dialog.SelectedPath;
                var fullPath = path + "/" + TextBox_Path.Text;

                using (Stream fileStream = File.OpenWrite(fullPath))
                using (Stream ftpStream = response.GetResponseStream())
                {
                    ftpStream.CopyTo(fileStream);
                }
            }
        }

        private void HandleFileUploadRequest(FtpWebRequest request)
        {
            var dialog = new OpenFileDialog();

            var result = dialog.ShowDialog();

            if (result is true)
            {
                using (Stream fileStream = File.OpenRead(dialog.FileName))
                using (Stream ftpStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(ftpStream);
                }
            }
        }

        private void HandleMakeDirectory(FtpWebResponse response)
        {
            ListBox_Directories.Items.Add(TextBox_Path.Text);
        }

        private void HandleDeleteFile(FtpWebResponse response)
        {
            DeleteSelectedItem();
        }

        private void HandleListDirectory(FtpWebResponse response)
        {
            using (var stream = new StreamReader(response.GetResponseStream()))
            {
                List<string> directories = new List<string>();

                var line = stream.ReadLine();
                while (string.IsNullOrEmpty(line) is false)
                {
                    var lineArr = line.Split('/');
                    line = lineArr[lineArr.Count() - 1];
                    directories.Add(line);
                    line = stream.ReadLine();
                }

                PrintDirectories(directories);
            }
        }

        private void PrintDirectories(IEnumerable<string> directories)
        {
            ListBox_Directories.Items.Clear();

            foreach (var directory in directories) 
            {
                ListBox_Directories.Items.Add(directory);
            }
        }

        private void DeleteSelectedItem()
        {
            ListBox_Directories.Items.Remove(ListBox_Directories.SelectedItem);
        }

        private void ListBox_Directories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBox_Directories.SelectedItem is null)
                return;

            var element = ListBox_Directories.SelectedItem.ToString();

            TextBox_Path.Text = element;
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Path.Text = string.Empty;
        }
    }
}
