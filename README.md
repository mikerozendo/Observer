This is my own personal understanding and coding based on **Observer's Design Pattern**. 

For more information about this pattern you can read: https://refactoring.guru/design-patterns/observer

## Personal thoughts

I see this conceptually as how Messaging tools and all the systems implemented around it work nowadays (AzureServiceBus, RabbitMq, Kakfa) as a default publisher/subscriber solution to deliver certain kind of 'Events'

Thinking in a more general purpose code level, I can even see it as some kind of a processing pipeline, 
all managed by a Handler that knows how to deliver an Event to all the parts that needs to do something with it in a independent way.

This is just a POC!
