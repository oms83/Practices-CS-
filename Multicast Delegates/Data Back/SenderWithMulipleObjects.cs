using System;


namespace Multicast_Delegates.Data_Back
{
    public class SenderWithMulipleObjects
    {
        public delegate void DataBackEventHandler(object sender, int Number);
        public static event DataBackEventHandler DataBack;

        private void TriggerEvent(int Number)
        {
            DataBack?.Invoke(this, Number);
        }

        private static void HandleDataBack(object sender, int Number)
        {
            Console.WriteLine($"Event triggered by: {sender.GetType().Name}, PersonID: {Number}");
        }

        public static void Start()
        {
            SenderWithMulipleObjects program = new SenderWithMulipleObjects();

            DataBack = HandleDataBack;

            program.TriggerEvent(100);
            program.TriggerEvent(101);

            /*
                Event triggered by: SenderWithMulipleObjects, PersonID: 100
                Event triggered by: SenderWithMulipleObjects, PersonID: 101 
            */
        }
    }
}
