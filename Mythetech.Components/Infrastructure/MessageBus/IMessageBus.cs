namespace Mythetech.Components.Infrastructure.MessageBus;

public interface IMessageBus
{
    Task PublishAsync<TMessage>(TMessage message) where TMessage : class;
    
    void RegisterConsumerType<TMessage, TConsumer>() where TMessage : class where TConsumer : IConsumer<TMessage>;
    
    void Subscribe<TMessage>(IConsumer<TMessage> consumer) where TMessage : class;
    void Unsubscribe<TMessage>(IConsumer<TMessage> consumer) where TMessage : class;
}