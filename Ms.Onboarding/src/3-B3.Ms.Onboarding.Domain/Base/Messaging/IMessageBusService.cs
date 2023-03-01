namespace B3.Ms.Onboarding.Domain.Base.Messaging
{
    public interface IMessageBusService
    {
        void Publish<T>(T message, string routingKey);
    }
}
