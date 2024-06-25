

using System.Net.Sockets;
using System.Net;
using System.Text;

var clients = new List<TcpClient>();

var listener = new TcpListener(IPAddress.Any, 11000);
listener.Start();

Console.WriteLine("TCP Chat Server started...");

while (true)
{
    var client = listener.AcceptTcpClient();
    clients.Add(client);
    Console.WriteLine("Client connected!");

    Thread thread = new Thread(() => HandleClient(client));
    thread.Start();
}
 
void HandleClient(TcpClient client)
{
    NetworkStream stream = client.GetStream();
    byte[] buffer = new byte[1024];

    while (true)
    {
        int bytesRead = stream.Read(buffer, 0, buffer.Length);
        if (bytesRead == 0)
        {
            Console.WriteLine("Client disconnected!");
            clients.Remove(client);
            break;
        }

        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
        Console.WriteLine($"Received: {message}");

        BroadcastMessage(message, client);
    }
}

void BroadcastMessage(string message, TcpClient sender)
{
    byte[] data = Encoding.UTF8.GetBytes(message);

    foreach (var client in clients)
    {
        if (client != sender)
        {
            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);
        }
    }
}