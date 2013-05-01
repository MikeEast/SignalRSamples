using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client.Hubs;

namespace SignalRSamples.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 80;
            Console.ForegroundColor = ConsoleColor.Green;

            // Connect to the service
            var hubConnection = new HubConnection("http://localhost:3589");

            // Create a proxy to the chat service
            var chat = hubConnection.CreateHubProxy("simpleHub");

            // Print the message when it comes in
            chat.On("notify", message => Console.WriteLine(message));

            var movr = hubConnection.CreateHubProxy("movrHub");

            movr.On< int, int>("moved", (x, y) => {
                Console.WriteLine("Coords: {0} {1}", x, y);
            });

            // Start the connection
            hubConnection.Start().Wait();

            string line = null;
            while ((line = Console.ReadLine()) != null)
            {
                // Send a message to the server
                chat.Invoke("SendAllExceptSelf", line).Wait();
            }
        }
    }
}
