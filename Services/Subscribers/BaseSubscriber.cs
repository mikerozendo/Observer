using FluentResults;
using Observer.Events;
using Observer.Services.Subscribers.Interfaces;

namespace Observer.Services.Subscribers;

public class BaseSubscriber<TEvent> : IBaseSubscriber<TEvent> where TEvent : BaseEvent
{
    public virtual async Task<Result> HandleAsync(TEvent Event) { return await Task.FromResult(Result.Ok()); }
}
