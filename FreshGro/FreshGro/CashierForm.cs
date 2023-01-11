using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshGro
{
    public partial class CashierForm : Form
    {
        public CashierForm()
        {
            InitializeComponent();
        }

        private void registerSale1_Load(object sender, EventArgs e)
        {

        }

        private void cashierHomeBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (cashierHomeBtn.Checked) { cashierHome1.BringToFront(); CahierHeaderTitle.Text = "Home"; }
        }

        private void cashierCutomersBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (cashierCutomersBtn.Checked) { customers1.BringToFront(); CahierHeaderTitle.Text = "Add Customers"; }
        }

        private void registerSaleBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (registerSaleBtn.Checked) { registerSale1.BringToFront(); CahierHeaderTitle.Text = "Register Sales"; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



    }
}
