using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multicast_Delegates.Data_Back
{
    public partial class frmDataBackByEvent : Form
    {

        /*
            public delegate void DataBackEventHandler(object sender, int Number);
            
            Identify Event Source:
            By passing sender (often this), event handlers can know which object raised the event. 
            This is especially useful when multiple objects of the same type raise the same event.

            Example: If you have multiple buttons and each button raises an event when clicked, 
            you can determine which button was clicked using sender.


            Provide More Context:
            By passing sender, handlers can access properties or methods of the object that raised the event, 
            providing more flexibility in handling the event.

            Example: Handlers can use sender to access the object's properties to determine its current state 
            or modify its properties based on the event.


            Separate Logic and Event Handling:
            The same event handler can be used to handle events from different objects, making it easier to 
            separate event handling logic from the objects that raise events.

            Example: The same event handler can handle button clicks and determine which button was 
            clicked based on sender. 
        */



        /*
            This example can be used when you only need to pass an integer (int) when the event occurs. 
            This is useful for simple scenarios where a single piece of information (like a number) is sufficient
            to handle the event.   
        */
        public delegate void DataBackEventHandler(int Number);
        public event DataBackEventHandler DataBack;
        public frmDataBackByEvent()
        {
            InitializeComponent();
        }

        private void btnBackData_Click(object sender, EventArgs e)
        {
            int Number = Convert.ToInt32(textBox1.Text);

            // invoke
            DataBack?.Invoke(Number);
        }
    }
}
