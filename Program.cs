using Observer.Entities;
using Observer.Events;
using Observer.Senders;
using Observer.Services.Subscribers;
using Observer.Services.Subscribers.Interfaces;
using Microsoft.Extensions.DependencyInjection;



var serviceProvider = BuildServiceProvider();
var subscribers = serviceProvider.GetRequiredService<IEnumerable<IBaseSubscriber<Event1>>>();

var person = new Person(Guid.NewGuid(), "Michael Rozendo", new DateTime(1998, 03, 11));
var eventSender = new BaseEventSender<Event1>(subscribers, new Event1(Guid.NewGuid(), person, DateTime.Now));

var results = await eventSender.HandleAsync();
var failedDeliverys = results?.Where(x => x.IsFailed)?.ToList();
var successfullyDeliverys = results?.Where(x => x.IsSuccess)?.ToList();

if (failedDeliverys is not null && failedDeliverys.Any())
{
    failedDeliverys.ForEach(x =>
    {
        Console.WriteLine($"Some deliverys have failed. Error: {x.Errors[0]}");
    });
}

if (successfullyDeliverys is not null && successfullyDeliverys.Any())
{
    Console.WriteLine($"Other deliverys have been completed successfully");
}

static IServiceProvider BuildServiceProvider()
{
    var serviceCollection = new ServiceCollection();

    serviceCollection.AddScoped<IBaseSubscriber<Event1>, Subscriber1>();
    serviceCollection.AddScoped<IBaseSubscriber<Event1>, Subscriber2>();
    serviceCollection.AddScoped<IBaseSubscriber<Event1>, Subscriber3>();
    return serviceCollection.BuildServiceProvider();
}

