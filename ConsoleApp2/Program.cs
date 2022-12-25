// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

var publisher = new Publisher();
var bigSub = new BigSubscriber { EventType = EventType.Big };
var bigSub2 = new BigSubscriber { EventType = EventType.Big };
var smallSub = new SmallSubscriber { EventType = EventType.Small };
var mediumSub = new MediumSubscriber{ EventType = EventType.Medium };

publisher.Subscribe(bigSub);
publisher.Subscribe(bigSub2);
publisher.Subscribe(smallSub);
publisher.Subscribe(mediumSub);
publisher.Notify(EventType.Big);
publisher.Notify(EventType.Medium);
publisher.Notify(EventType.Small);
publisher.Notify(EventType.All);

publisher.Unsubscribe(bigSub);
publisher.Unsubscribe(bigSub2);
publisher.Unsubscribe(smallSub);
publisher.Notify(EventType.All);
