using System;


public class Stock
{
    public decimal OldPrice { get; }
    public decimal NewPrice { get; }
    public decimal Difference {  get; }
    public Stock(decimal newPrice, decimal oldPrice)
    {
        OldPrice = oldPrice;
        NewPrice = newPrice;
        Difference = newPrice - oldPrice;
    }
}

public class StockPriceTracker : EventArgs
{
    public event EventHandler<Stock> StockChanged;

    private decimal OldPrice;
    private decimal CurrentPrice = 20000;
    public string Name { get; }

    public StockPriceTracker(string name)
    {
        Name = name;
    }
    public void SetPrice(decimal newPrice)
    {
        if (newPrice != CurrentPrice)
        {
            this.OldPrice = CurrentPrice;
            this.CurrentPrice = newPrice;
            OnStockPriceChanged(CurrentPrice, OldPrice);
        }
    }
    private void OnStockPriceChanged(decimal newPrice, decimal oldPrice)
    {
        OnStockPriceChanged(new Stock(newPrice, oldPrice));
    }
    protected virtual void OnStockPriceChanged(Stock e)
    {
        StockChanged?.Invoke(this, e);
    }
}

public class Tracker
{
    private string name;
    public void Subscirbe(StockPriceTracker priceTracker)
    {
        priceTracker.StockChanged += HandleOnStockPriceChanged;
        name = priceTracker.Name;
    }

    private void HandleOnStockPriceChanged(object sender, Stock e)
    {
        Action<string> Print = Message => Console.WriteLine(Message);

        Console.ForegroundColor = ConsoleColor.White;
        Print($"\n{this.name} Price Changed: ");

        Console.ForegroundColor = ConsoleColor.Green;
        Print($"Stock Old Price         : {e.OldPrice}");

        Console.ForegroundColor = ConsoleColor.Blue;
        Print($"Stock New Price         : {e.NewPrice}");

        Console.ForegroundColor = ConsoleColor.Red;
        Print($"Stock Price Differences : {e.Difference}");

    }

}

public class Run
{
    public static void run()
    {
        StockPriceTracker Bitcoin = new StockPriceTracker("Bitcoin");
        Tracker tracker = new Tracker();

        tracker.Subscirbe(Bitcoin);

        Bitcoin.SetPrice(30000);
        Bitcoin.SetPrice(45000);
        Bitcoin.SetPrice(44000);
        Bitcoin.SetPrice(43000);
    }
}