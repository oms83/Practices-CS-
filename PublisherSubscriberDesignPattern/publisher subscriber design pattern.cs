using System;

public class OrderEventArgs : EventArgs
{
    public decimal OrderTotalPrice { get; }
    public int OrderID { get; }
    public string ClientEmail { get; }

    public OrderEventArgs(decimal orderTotalPrice, int orderID, string clientEmail)
    {
        OrderTotalPrice = orderTotalPrice;
        OrderID = orderID;
        ClientEmail = clientEmail;
    }
}

public class Order
{
    public event EventHandler<OrderEventArgs> OrderCreated;

    public void Create(decimal orderTotalPrice, int orderID, string clientEmail)
    {
        Console.WriteLine("New order is created, now will notify everyone by raising the event. \n");

        //OnOrderCreated(new OrderEventArgs(orderTotalPrice, orderID, clientEmail));
        
        if (OrderCreated != null)
        {
            OrderCreated(this, new OrderEventArgs(orderTotalPrice, orderID, clientEmail));
        }
    }

    protected virtual void OnOrderCreated(OrderEventArgs e)
    {
        OrderCreated?.Invoke(this, e);
    }
}

public class EmailService
{
    public void Subscribe(Order order)
    {
        order.OrderCreated += HandleOrderCreated;
    }
    public void Unsubscribe(Order order)
    {
        order.OrderCreated -= HandleOrderCreated;
    }

    private void HandleOrderCreated(object sender, OrderEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nEmail Service:");
        Console.WriteLine("Order ID: " + e.OrderID);
        Console.WriteLine("Order Total Price: " + e.OrderTotalPrice);
        Console.WriteLine("Client ID: " + e.ClientEmail);
    }
}

public class PhoneService
{
    public void Subscribe(Order order)
    {
        order.OrderCreated += HandleOrderCreated;
    }
    public void Unsubscribe(Order order)
    {
        order.OrderCreated -= HandleOrderCreated;
    }

    private void HandleOrderCreated(object sender, OrderEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nPhone Service:");
        Console.WriteLine("Order ID: " + e.OrderID);
        Console.WriteLine("Order Total Price: " + e.OrderTotalPrice);
        Console.WriteLine("Client ID: " + e.ClientEmail);
    }
}

public class ShippingService
{
    public void Subscribe(Order order)
    {
        order.OrderCreated += HandleOrderCreated;
    }
    public void Unsubscribe(Order order)
    {
        order.OrderCreated -= HandleOrderCreated;
    }

    private void HandleOrderCreated(object sender, OrderEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nShipping Service:");
        Console.WriteLine("Order ID: " + e.OrderID);
        Console.WriteLine("Order Total Price: " + e.OrderTotalPrice);
        Console.WriteLine("Client ID: " + e.ClientEmail);
    }
}

public class Running
{
    public static void run()
    {
        Order order = new Order();
        EmailService emailService = new EmailService();
        PhoneService phoneService = new PhoneService();
        ShippingService shippingService = new ShippingService();

        emailService.Subscribe(order);
        phoneService.Subscribe(order);
        shippingService.Subscribe(order);

        order.Create(123, 1, "oms@gmail.com");
        order.Create(545, 2, "ali@gmail.com");

        phoneService.Unsubscribe(order);
        order.Create(686, 3, "omser@gmail.com");
    }
}