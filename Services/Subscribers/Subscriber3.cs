using FluentResults;
using Observer.Events;

namespace Observer.Services.Subscribers;

public sealed class Subscriber3 : BaseSubscriber<Event1>
{
    public override async Task<Result> HandleAsync(Event1 Event)
    {
        Console.WriteLine("Executing Subscriber3");
        return await Task.FromResult(Result.Fail("Internal error while attempting to notify Subscriber3"));
    }
}
