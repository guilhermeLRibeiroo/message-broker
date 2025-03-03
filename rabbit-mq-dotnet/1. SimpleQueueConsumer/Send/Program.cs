using _1._SimpleQueueConsumer.Send;

Console.WriteLine("Starting Producer");

var producer = new Send();
await producer.SendMessage();

Console.ReadLine();