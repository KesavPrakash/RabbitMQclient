using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQClient.Interfaces
{
    public interface IRabbitMQbroker
    {
        bool WriteToMQByFanoutExchange(string payload);

      
    }
}
