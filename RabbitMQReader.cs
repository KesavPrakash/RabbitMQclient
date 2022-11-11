using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQClient
{
    public class RabbitMQReader : IRabbitMQReader
    {
        IRabbitMQConfigurations configMQ;
        ConnectionFactory connectionFactoryread;
        List<string> readMessagesLst;
        string readMessages;
        public RabbitMQReader(IRabbitMQConfigurations config)
        {
            this.configMQ = config;
        }

        public List<string> ReadMQByFanoutExchange()
        {
            connectionFactoryread = new RabbitMQ.Client.ConnectionFactory()
            {
                HostName = configMQ.RabbitMQHostname,
                UserName = configMQ.RabbitMQUserName,
                Password = configMQ.RabbitMQPassword
            };
            using (var connection = connectionFactoryread.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += async (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);


                    //readMessagesLst.Add("[x] Received : " + message);
                    //readMessages = "[x] Received : " + message;
                };
                channel.BasicConsume(queue: configMQ.Queue,
                                     autoAck: true,
                                     consumer: consumer);
                string sss = readMessages;
                return readMessagesLst;
            }
        }
    }
}
