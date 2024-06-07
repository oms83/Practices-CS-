using System;
using oms = System.Console;
public class TemperatureChangeEventArgs
{
    public double NewTemperature { get; }
    public double OldTemperature { get; }
    public double Difference { get; }

    public TemperatureChangeEventArgs(double newTemperature, double oldTemperature)
    {
        this.NewTemperature = newTemperature;
        this.OldTemperature = oldTemperature;
        this.Difference = newTemperature - oldTemperature;
    }
}

public class Thermostat
{
    public event EventHandler<TemperatureChangeEventArgs> TemperatureChange;

    private double OldTemperature;
    private double CurrentTemperature;
    public void SetTemperature(double newTemperature)
    {
        if (newTemperature != CurrentTemperature)
        {
            this.OldTemperature = CurrentTemperature;
            this.CurrentTemperature= newTemperature;

            // rais the event
            OnTemperatureChanged(this.CurrentTemperature, this.OldTemperature);
        }
    }

    private void OnTemperatureChanged(double newTemperature, double oldTemperature)
    {
        OnTemperatureChanged(new TemperatureChangeEventArgs(newTemperature, oldTemperature));
    }
    protected virtual void OnTemperatureChanged(TemperatureChangeEventArgs e)
    {
        TemperatureChange?.Invoke(this, e);
    }
}

public class Display
{
    public void Subscribe(Thermostat thermostat)
    {
        thermostat.TemperatureChange += HandleChangeTemperature;
    }

    private void HandleChangeTemperature(object sender, TemperatureChangeEventArgs e)
    {
        Action<string> Print = Message => Console.WriteLine(Message);
        
        oms.ForegroundColor = ConsoleColor.Green;
        Print("\nTemperature Changed: ");

        oms.ForegroundColor = ConsoleColor.DarkCyan;
        Print($"Temperature Changed From : {e.OldTemperature}");

        oms.ForegroundColor = ConsoleColor.Yellow;
        Print($"Temperature Changed To   : {e.NewTemperature}");

        oms.ForegroundColor = ConsoleColor.Red;
        Print($"Temperature Difference   : {e.Difference}");
    }
}

public class Caller
{
    public static void run()
    {
        Thermostat thermostat = new Thermostat();
        Display display = new Display();

        display.Subscribe(thermostat);

        thermostat.SetTemperature(32);
        thermostat.SetTemperature(32);
        thermostat.SetTemperature(34);
        thermostat.SetTemperature(26);
    }

}