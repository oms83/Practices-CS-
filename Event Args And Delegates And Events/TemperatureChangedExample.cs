using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace Event_Args_And_Delegates_And_Events
{
    public class TempratureChangedEventArgs : EventArgs
    {
        public int NewTemperature { get; }
        public int OldTemperature { get; }
        public int Diffrence { get; }

        public TempratureChangedEventArgs(int newTemperature, int oldTemperature)
        {
            this.NewTemperature = newTemperature;
            this.OldTemperature = oldTemperature;
            this.Diffrence = newTemperature - oldTemperature;
        }
    }
    public class Thermostat
    {
        public event EventHandler<TempratureChangedEventArgs> TemperatureChanged;

        private int CurrentTemperature;
        private int OldTemperature;

        public void SetTemperature(int newTemperature)
        {
            if (newTemperature != this.CurrentTemperature)
            {
                this.OldTemperature = CurrentTemperature;
                this.CurrentTemperature = newTemperature;
                OnTemperatureChanged(this.CurrentTemperature, this.OldTemperature);
            }
        }
        public void OnTemperatureChanged(int newTemperature, int oldTemperature)
        {
            OnTemperatureChanged(new TempratureChangedEventArgs(newTemperature, oldTemperature));
        }
        protected virtual void OnTemperatureChanged(TempratureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }
    }

    public class Display
    {
        public void Subscribe(Thermostat thermostat)
        {
            thermostat.TemperatureChanged += HandleOnTemperatureChanged;
        }

        public void HandleOnTemperatureChanged(object sender,TempratureChangedEventArgs e)
        {
            Console.WriteLine("\nTemperature Changed:");
            Console.WriteLine($"Temperature Changed From: {e.OldTemperature}");
            Console.WriteLine($"Temperature Changed To: {e.NewTemperature}");
            Console.WriteLine($"Temperature Differance: {e.NewTemperature}");
            Console.WriteLine($"Sender: {sender.GetType().Name}");
        }
    }

    public class caller
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
}
    