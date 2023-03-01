using System.Text;
using B3.Ms.Onboarding.Domain.Base.Messaging;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace B3.Ms.Onboarding.Data.Messaging
{

    public class RabbitMqService : IMessageBusService
    {

        #region Properties

        private readonly IConnection _connection;

        #endregion

        #region Constructors

        public RabbitMqService()
        {
            var connectionFactory = new ConnectionFactory
            {
                HostName = "localhost"
            };

            _connection = connectionFactory.CreateConnection();
        }

        #endregion

        #region Methods       

        public void Publish<T>(T message, string routingKey)
        {
            using(var channel = _connection.CreateModel())
            {
                channel.QueueDeclare(
                    queue: routingKey,
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null
                    );

                var stringMessage = JsonConvert.SerializeObject(message);

                var byteArray = Encoding.UTF8.GetBytes(stringMessage);

                channel.BasicPublish(
                exchange: "",
                routingKey: routingKey,
                basicProperties: null,
                body: byteArray
                );
            }
        }

        #endregion

    }
}
