using _1._SimpleQueueConsumer.Receive;
using _1._SimpleQueueConsumer.Send;

var producer = new Send();
await producer.SendMessage();

var consumer = new Receive();
await consumer.ReceiveMessage();