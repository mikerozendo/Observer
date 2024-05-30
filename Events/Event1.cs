using Observer.Entities;

namespace Observer.Events;

public sealed class Event1(Guid id, Person payloadData, DateTime createdAt) : BaseEvent(id, payloadData, createdAt) { }
