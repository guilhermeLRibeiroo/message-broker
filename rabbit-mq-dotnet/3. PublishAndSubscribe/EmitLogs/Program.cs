using RabbitMQ.Client;
using System.Text;

var factory = new ConnectionFactory { HostName = "localhost", UserName = "guest", Password = "guest" };
using var connection = await factory.CreateConnectionAsync();
using var channel = await connection.CreateChannelAsync();

await channel.ExchangeDeclareAsync(exchange: "logs", type: ExchangeType.Fanout);

var message = GetMessage(args);
var body = Encoding.UTF8.GetBytes(message);
await channel.BasicPublishAsync(exchange: "logs", routingKey: string.Empty, 
    ody: body);
Console.WriteLine($"Sent {message}");

Console.WriteLine("Press [enter] to exit.");
Console.ReadLine();

static string GetMessage(string[] args)
{
    return ((args.Length > 0) ? string.Join(" ", args) : "info: Hello World!");
}