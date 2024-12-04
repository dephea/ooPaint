using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimpleTCP;
using System;
using System.Collections.Concurrent;
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

        private ConcurrentDictionary<string, TcpClient> clients; // can access particular clients if needed

        public event Action<RemoteAction> OnActionReceived;

        public Server()
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.DelimiterDataReceived += Server_DataReceived;

            clients = new ConcurrentDictionary<string, TcpClient>();

            server.ClientConnected += Server_ClientConnected;
            server.ClientDisconnected += Server_ClientDisconnected;
        }

        private void Server_ClientConnected(object? sender, TcpClient e)
        {
            string clientId = e.Client.RemoteEndPoint.ToString();

            Debug.WriteLine("User connected: " + clientId);


            clients.TryAdd(clientId, e);
        }
        private void Server_ClientDisconnected(object? sender, TcpClient e)
        {
            string clientId = e.Client.RemoteEndPoint.ToString();

            Debug.WriteLine("User disconnected: " + clientId);
            
            if (clients.ContainsKey(clientId))
            {
                clients[clientId].Close();
                clients.TryRemove(clientId, out e);
            }
            
        }
        private async void Server_DataReceived(object? sender, SimpleTCP.Message e)
        {
            // for asynchronous processing
            await Task.Run(() =>
            {
                //e.Reply(Encoding.ASCII.GetBytes("I got your data!"));

                string jsonAction = Encoding.UTF8.GetString(e.Data);


                try
                {
                    RemoteAction action = JsonConvert.DeserializeObject<RemoteAction>(jsonAction);

                    OnActionReceived?.Invoke(action);

                    server.BroadcastLine(jsonAction);

                    Debug.WriteLine($"Received and broadcasted action: Tool={action.title}, Start={action.start}, End={action.end}");
                    

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

        public void SendAction(Tool tool, Point start, Point end)
        {
            try
            {

                RemoteAction action = new RemoteAction(tool, start, end);


                string jsonAction = JsonConvert.SerializeObject(action);


                if (IsValidJson(jsonAction))
                {
                    byte[] data = Encoding.UTF8.GetBytes(jsonAction);

                    Debug.WriteLine(jsonAction);


                    server.BroadcastLine(jsonAction);

                    //client.WriteLine(jsonAction);

                    Debug.WriteLine("Successfully sent action");
                }
                else
                {
                    Debug.WriteLine("Error: Invalid JSON");
                }
            }
            catch (JsonSerializationException ex)
            {
                Debug.WriteLine("Serialization error: " + ex.Message);
            }
        }


        private bool IsValidJson(string str)
        {
            try
            {
                JToken.Parse(str);
                return true;
            }
            catch (JsonReaderException)
            {
                return false;
            }
        }
    }
}
