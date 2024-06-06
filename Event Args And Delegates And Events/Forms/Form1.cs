using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Args_And_Delegates_And_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlCalculate1_OnCalculationComplate(object sender, Forms.User_Controls.ctrlCalculate.CalculateEventArgs e)
        {
            MessageBox.Show($"Value1: {e.Value1}\nValue2: {e.Value2}\nResult: {e.Result}\nCaller: {sender.GetType().Name}");
        }
    }
}
