using RabbitMQClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQClient
{
    public class RabbitMQConfigurations : IRabbitMQConfigurations
    {
        public string RabbitMQHostname { get; set; }
        public string RabbitMQVirtualhost { get; set; }
        public string RabbitMQUserName { get; set; }
        public string RabbitMQPassword { get; set; }
        public string Exchange { get; set; }
        public string Queue { get; set; }
    }
}
