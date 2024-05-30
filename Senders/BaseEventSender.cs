using FluentResults;
using Observer.Events;
using Observer.Services.Subscribers.Interfaces;

namespace Observer.Senders;

public class BaseEventSender<TEvent>(IEnumerable<IBaseSubscriber<TEvent>> subscribers, TEvent baseEvent) where TEvent : BaseEvent
{
    public async Task<IEnumerable<Result>> HandleAsync()
    {
        var resultList = new List<Result>();

        var tasks = subscribers.Select(
            async subscriber =>
            await subscriber.HandleAsync(baseEvent)).ToList();

        var expectableTasks = Task.WhenAll(tasks);
        return await expectableTasks;
    }
}
