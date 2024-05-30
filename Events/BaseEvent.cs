using Observer.Interfaces;

namespace Observer.Events;

public class BaseEvent(Guid id, IPayloadData payloadData, DateTime createdAt)
{
    public Guid Id { get; } = id;
    public IPayloadData PayloadData { get; } = payloadData;
    public DateTime CreatedAt { get; } = createdAt;
}
