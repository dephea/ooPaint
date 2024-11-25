using Newtonsoft.Json;
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{

    // tcp server
    internal class Server
    {
        SimpleTcpServer server;

        public event Action<RemoteAction> OnActionReceived;

        public Server()
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            //server.DataReceived += Server_DataReceived;
            server.DelimiterDataReceived += Server_DataReceived;

            server.ClientConnected += Server_ClientConnected;
            server.ClientDisconnected += Server_ClientDisconnected;
        }

        private void Server_ClientConnected(object? sender, TcpClient e)
        {
            Debug.WriteLine("User connected: " + e.Client.RemoteEndPoint.ToString());
        }
        private void Server_ClientDisconnected(object? sender, TcpClient e)
        {
            Debug.WriteLine("User disconnected: " + e.Client.RemoteEndPoint.ToString());
        }
        private async void Server_DataReceived(object? sender, SimpleTCP.Message e)
        {

            await Task.Run(() =>
            {
                //e.Reply(Encoding.ASCII.GetBytes("I got your data!"));

                string jsonAction = Encoding.UTF8.GetString(e.Data);


                try
                {
                    RemoteAction action = JsonConvert.DeserializeObject<RemoteAction>(jsonAction);

                    OnActionReceived?.Invoke(action);

                    Debug.WriteLine($"Received action: Tool={action.title}, Start={action.start}, End={action.end}");


                }
                catch (Exception ex)
                {
                    Debug.WriteLine("JSON Deserialization Error: " + ex.Message);
                    Debug.WriteLine("Invalid JSON:" + jsonAction);
                }

            });
        }

        public void StartServer(int port)
        {
            server.Start(port);
            Debug.WriteLine("Server started at " + port + " port");
          
        }

        public void StopServer()
        {
            server.Stop();
            Debug.WriteLine("Server stopped");
        }
    }
}
