using Multicast_Delegates.Data_Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multicast_Delegates
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            frmDataBack frm = new frmDataBack();

            // subscribe
            frm.DataBack += ShowReturnValue;

            frm.ShowDialog();
        }

        private void ShowReturnValue(int Number)
        {
            string strNumber = Convert.ToString(Number);
            textBox2.Text = strNumber;

            MessageBox.Show(strNumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDataBackByEvent frm = new frmDataBackByEvent();

            // subscribe
            frm.DataBack += ShowReturnValue;

            frm.ShowDialog();
        }
    }
}
/*
 
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());

            Console.ReadKey();
        }

*/