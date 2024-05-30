using FluentResults;
using Observer.Events;

namespace Observer.Services.Subscribers.Interfaces;

public interface IBaseSubscriber<TEvent> where TEvent : BaseEvent
{
    Task<Result> HandleAsync(TEvent Event);
}
