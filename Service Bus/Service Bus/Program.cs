using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;

namespace Service_Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Create a ServiceBusClient object using the connection string to the namespace.
            await using var client = new ServiceBusClient(connectionString);

            // Create a ServiceBusSender object by invoking the CreateSender method on the ServiceBusClient object, and specifying the queue name. 
            ServiceBusSender sender = client.CreateSender(queueName);
            // Create a new message to send to the queue.
            string messageContent = "Order new crankshaft for eBike.";
            var message = new ServiceBusMessage(messageContent);

            // Send the message to the queue.
            await sender.SendMessageAsync(message);
            // Create a ServiceBusProcessor for the queue.
            await using ServiceBusProcessor processor = client.CreateProcessor(queueName, options);

            // Specify handler methods for messages and errors.
            processor.ProcessMessageAsync += MessageHandler;
            processor.ProcessErrorAsync += ErrorHandler;
            await args.CompleteMessageAsync(args.Message);
        }
    }
}
