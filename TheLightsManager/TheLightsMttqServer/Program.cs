using MQTTnet.Server;
using MQTTnet;
using System.Text;

/*  <Remote control led lights>
    Copyright (C) <2022> <Brandon Camadine, Amy Gaton>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

namespace MttqServer
{
    public class TheLightsMttqServer
    {
        public static async Task Main(string[] Args)
        {
            Console.WriteLine("Hello, World!");
            // Create the options for MQTT Broker

            var options = new MqttServerOptionsBuilder().WithDefaultEndpoint().WithDefaultEndpointPort(8085); //localhost

            // Create a new mqtt server
            var server = new MqttFactory().CreateMqttServer(options.Build());
            //Add Interceptor for logging incoming messages
            server.InterceptingPublishAsync += Server_InterceptingPublishAsync;
            // Start the server
            await server.StartAsync();
            // Keep application running until user press a key
            //setupClient();
            Console.ReadLine();
        }
        static Task Server_InterceptingPublishAsync(InterceptingPublishEventArgs arg)
        {
            // Convert Payload to string
            var payload = arg.ApplicationMessage?.Payload == null ? null : Encoding.UTF8.GetString(arg.ApplicationMessage?.Payload);


            Console.WriteLine(
                " TimeStamp: {0} -- Message: ClientId = {1}, Topic = {2}, Payload = {3}, QoS = {4}, Retain-Flag = {5}",

                DateTime.Now,
                arg.ClientId,
                arg.ApplicationMessage?.Topic,
                payload,
                arg.ApplicationMessage?.QualityOfServiceLevel,
                arg.ApplicationMessage?.Retain);
            return Task.CompletedTask;
        }

        //public static void setupClient()
        //{
        //    var options = new MqttClientOptionsBuilder().WithClientId("myClient").WithTcpServer("localhost",8085);
            
        //    var client = new MqttFactory().CreateMqttClient();

        //    client.ConnectAsync(options.Build()).GetAwaiter().GetResult();
        //    string test = "testing";

        //    client.PublishAsync(new MqttApplicationMessage() { Topic = "rabbits", Payload = Encoding.ASCII.GetBytes(test) }).GetAwaiter().GetResult();

        //}
    }
}