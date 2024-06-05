using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Publisher
{
    public delegate void Notify(object sender, string message);
    public event Notify OnPublish;

    public void Publish(object sender, string message)
    {
        OnPublish?.Invoke(sender, message);
    }
}

public class Subscriber
{
    public void Subscribe(Publisher publisher)
    {
        publisher.OnPublish += Display;
    }

    public void Display(object sender, string message)
    {
        Console.WriteLine($"Received message: {message},  object info: {sender.GetType().Name}");
    }

}

public class Caller
{
    public static void Start()
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();
        subscriber.Subscribe( publisher );

        Caller caller = new Caller();

        publisher.Publish(caller, "Hello World!"); // Received message: Hello World!,  object info: Caller
    }
}