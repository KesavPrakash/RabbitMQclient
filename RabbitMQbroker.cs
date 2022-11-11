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
    public class RabbitMQbroker : IRabbitMQbroker
    {

        IRabbitMQConfigurations configMQ;
        ConnectionFactory connectionFactory;
        ConnectionFactory connectionFactoryread;
        List<string> readMessagesLst;
        string readMessages;
        public RabbitMQbroker(IRabbitMQConfigurations config)
        {
            this.configMQ = config;


        }

        /// <summary>
        /// This method will send the payload to rabbit mq
        /// Credentials will be read from configurations
        /// </summary>
        /// <param name="payload"></param>
        /// <returns></returns>
        public bool WriteToMQByFanoutExchange(string payload)
        {
            //Main entry point to the RabbitMQ .NET AMQP client
            connectionFactory = new RabbitMQ.Client.ConnectionFactory()
            {
                HostName = configMQ.RabbitMQHostname,
                UserName = configMQ.RabbitMQUserName,
                Password = configMQ.RabbitMQPassword,
                VirtualHost = configMQ.RabbitMQVirtualhost
            };

            var connection = connectionFactory.CreateConnection();
            var model = connection.CreateModel();

            var properties = model.CreateBasicProperties();
            properties.Persistent = false;

            byte[] messagebuffer = Encoding.Default.GetBytes(payload);

            model.BasicPublish(configMQ.Exchange, "", properties, messagebuffer);
            return true;
        }

    }
}
