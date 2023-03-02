using System.Text;
using B3.Ms.Update.Application.ToDos.Interfaces;
using B3.Ms.Update.Application.ToDos.Requests;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace B3.Ms.Update.Worker.Workers;

public class ToDoUpdateDescriptionWorker : BackgroundService
{

    #region Properties

    private readonly IToDoService _service;

    private readonly IConnection _connection;

    private readonly IModel _channel;

    private const string Queue = "todo-update-status";

    #endregion

    #region Constructors

    public ToDoUpdateDescriptionWorker(IToDoService service)
    {
        var connectionFactory = new ConnectionFactory
        {
            HostName = "localhost"
        };

        _connection = connectionFactory.CreateConnection();

        _channel = _connection.CreateModel();

        _channel.QueueDeclare(
            queue: Queue,
            durable: false,
            exclusive: false,
            autoDelete: false,
            arguments: null);

        _service = service;
    }
    #endregion

    #region Methods

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var consumer = new EventingBasicConsumer(_channel);

        consumer.Received += (sender, eventArgs) =>
        {
            var contentArray = eventArgs.Body.ToArray();
            var contentString = Encoding.UTF8.GetString(contentArray);
            var message = JsonConvert.DeserializeObject<ToDoUpdateStatusRequest>(contentString);

            _service.Update(message, stoppingToken);

            _channel.BasicAck(eventArgs.DeliveryTag, false);
        };

        _channel.BasicConsume(Queue, false, consumer);

        return Task.CompletedTask.WaitAsync(stoppingToken);
    }


    #endregion

}
