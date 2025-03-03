using _1._SimpleQueueConsumer;

Console.WriteLine("Starting Consumer");
var consumer = new Receive();
await consumer.ReceiveMessage();
