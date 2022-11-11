using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQClient.Interfaces
{
    public interface IRabbitMQConfigurations
    {
        string RabbitMQHostname { get; set; }
        string RabbitMQVirtualhost { get; set; }
        string RabbitMQUserName { get; set; }
        string RabbitMQPassword { get; set; }
        string Exchange { get; set; }
        string Queue { get; set; }
    }
}
