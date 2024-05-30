using Observer.Interfaces;

namespace Observer.Entities;

public class Person(Guid id, string name, DateTime birth) : IPayloadData
{
    public Guid Id { get; set; } = id;
    public string Name { get; set; } = name;
    public DateTime Birth { get; set; } = birth;
}

