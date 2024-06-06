using System;

using System.Windows.Forms;

namespace Event_Args_And_Delegates_And_Events.Forms.User_Controls
{
    public partial class ctrlCalculate : UserControl
    {
        public ctrlCalculate()
        {
            InitializeComponent();
        }

        public class CalculateEventArgs : EventArgs
        {
            public int Value1 { get; }
            public int Value2 { get; }
            public int Result {  get; }

            public CalculateEventArgs(int value1, int value2, int result)
            {
                Value1 = value1;
                Value2 = value2;
                Result = result;
            }
        }

        public event EventHandler<CalculateEventArgs> OnCalculationComplate;

        public void RaiseOnCalculationComplate(int Value1, int Value2, int Result)
        {
            RaiseOnCalculationComplate(new CalculateEventArgs(Value1, Value2, Result));
        }
        protected virtual void RaiseOnCalculationComplate(CalculateEventArgs e)
        {
            OnCalculationComplate?.Invoke(this, e);
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(txtValue1.Text);
            int v2 = Convert.ToInt32(txtValue2.Text);

            int r = v1 + v2;
            lblResult.Text = r.ToString();

            RaiseOnCalculationComplate(v1, v2, r);
        }
    }
}
