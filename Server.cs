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

        public Server()
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.DataReceived += Server_DataReceived;
            server.ClientConnected += Server_ClientConnected;
            server.ClientDisconnected += Server_ClientDisconnected;
        }

        private void Server_ClientConnected(object? sender, TcpClient e)
        {
            throw new NotImplementedException();
        }
        private void Server_ClientDisconnected(object? sender, TcpClient e)
        {
            throw new NotImplementedException();
        }
        private void Server_DataReceived(object? sender, SimpleTCP.Message e)
        {
            e.Reply(Encoding.ASCII.GetBytes("I got your data!"));
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
