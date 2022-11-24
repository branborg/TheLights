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

using MQTTnet.Client;
using MQTTnet;
using System.Text;

namespace ShowLauncher
{

    public partial class LaunchController : Form
    {
        private IMqttClient _client;
        private MqttClientOptionsBuilder _options;
        public LaunchController()
        {
            InitializeComponent();
            _options = new MqttClientOptionsBuilder().WithClientId("myClient").WithTcpServer("localhost", 8085);
            _client = new MqttFactory().CreateMqttClient();

        }

        private void BtnStartShow_Click(object sender, EventArgs e)
        {
            
        }
        public void setupClient()
        {
            _client.ConnectAsync(_options.Build()).GetAwaiter().GetResult();
            string test = "testing";

            _client.PublishAsync(new MqttApplicationMessage() { Topic = "rabbits", Payload = Encoding.ASCII.GetBytes(test) }).GetAwaiter().GetResult();
        }
    }
}