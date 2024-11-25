using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTCP;

namespace ProjectOOP
{
    internal class Client
    {
        private SimpleTcpClient client;

        public Client() {
            client = new SimpleTcpClient();
            client.Delimiter = 0x13;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object? sender, SimpleTCP.Message e)
        {
            e.Reply(Encoding.ASCII.GetBytes("I got your data!"));
        }

        public void Connect(string ipAddress, int port)
        {
            client.Connect(ipAddress, port);
            Console.WriteLine("Connected to the server: " + ipAddress + ":" + port);
        }

        public void Disconnect() 
        {
            client.Disconnect();
            Console.WriteLine("Disconnected from the server.");
        }
    }
}
