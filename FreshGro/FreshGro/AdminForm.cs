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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminHomeBtn_Cheanged(object sender, EventArgs e)
        {
            if (adminHomeBtn.Checked) { adminHome1.BringToFront(); headerTitle.Text = "Home"; }
        }

        private void adminCategoryBtn_Changed(object sender, EventArgs e)
        {
            if (adminCategoryBtn.Checked) { adminCategories1.BringToFront(); headerTitle.Text = "Categories"; }

        }

        private void AdminItemBtn_Changed(object sender, EventArgs e)
        {
            if (AdminItemBtn.Checked) { adminItems1.BringToFront(); headerTitle.Text = "Items"; }
        }

        private void adminCutomersBtn_Changed(object sender, EventArgs e)
        {
            if (adminCutomersBtn.Checked) { adminCustomers1.BringToFront(); headerTitle.Text = "Customers"; }
        }

        private void adminRecordsBtn_Changed(object sender, EventArgs e)
        {
            if (adminRecordsBtn.Checked) { adminRecords1.BringToFront(); headerTitle.Text = "Records"; }
        }

        private void adminCashiersBtn_Changed(object sender, EventArgs e)
        {
            if (adminCashiersBtn.Checked) { adminCashiers1.BringToFront(); headerTitle.Text = "Cashiers"; }
        }

        private void AdminForm_Shown(object sender, EventArgs e)
        {
            
        }

        private void siticoneCircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings stn = new Settings();
            stn.Show();
        }











    }
}
