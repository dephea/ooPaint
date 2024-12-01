using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimpleTCP;

namespace ProjectOOP
{
    internal class Client
    {
        private SimpleTcpClient client;

        public event Action<RemoteAction> OnActionReceived;

        public Client() {
            client = new SimpleTcpClient();
            client.Delimiter = 0x13;
            client.DelimiterDataReceived += Client_DataReceived;
        }

        private async void Client_DataReceived(object? sender, SimpleTCP.Message e)
        {

            Debug.WriteLine("Client_DataReceived proc");
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

                    client.WriteLine(jsonAction);

                    Debug.WriteLine("Успешно отправил");
                }
                else
                {
                    Debug.WriteLine("Ошибка: Некорректный JSON");
                }
            }
            catch (JsonSerializationException ex)
            {
                Debug.WriteLine("Ошибка сериализации: " + ex.Message);
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
