using FluentResults;
using Observer.Events;

namespace Observer.Services.Subscribers;

public sealed class Subscriber2 : BaseSubscriber<Event1>
{
    public override async Task<Result> HandleAsync(Event1 Event)
    {
        Console.WriteLine("Executing Subscriber2");
        return await Task.FromResult(Result.Ok());
    }
}
