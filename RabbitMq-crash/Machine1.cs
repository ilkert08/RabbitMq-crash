using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMq_crash
{
    public class Machine1
    {
        public Machine1()
        {

        }

        public void Publish(string message)
        {
            var factory = new ConnectionFactory
            {
                HostName = "localhost",
            };

            
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            var queueName = "Diplomacy";
            channel.QueueDeclare(queue: queueName,
                     durable: false,
                     exclusive: false,
                     autoDelete: false,
                     arguments: null);

            var body = Encoding.UTF8.GetBytes(message);
            channel.BasicPublish(exchange: string.Empty,
                                 routingKey: queueName,
                                 basicProperties: null,
                                 body: body);




            Console.WriteLine($"Message: \"{message}\" published through \"{queueName}\" queue.");
        }
    }
}
