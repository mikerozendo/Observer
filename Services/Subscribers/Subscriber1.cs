using FluentResults;
using Observer.Events;

namespace Observer.Services.Subscribers;

public sealed class Subscriber1 : BaseSubscriber<Event1>
{
    public override async Task<Result> HandleAsync(Event1 Event)
    {
        Console.WriteLine("Executing Subscriber1");
        return await Task.FromResult(Result.Ok());
    }
}
