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
    public partial class frmDataBack : Form
    {
        public delegate void DataBackEventHandler(int Number);

        public DataBackEventHandler DataBack;
        public frmDataBack()
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
