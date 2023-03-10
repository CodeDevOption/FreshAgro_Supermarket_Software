using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshGro
{
    public partial class CashierForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V9SH1LB;Initial Catalog=FreshGro;Integrated Security=True");
        SqlCommand cmd;

        public static CashierForm instance;  
        public CashierForm()
        {
            InitializeComponent();
            instance = this;
        }
        public void cashierCutomersBtnCheck() {
            cashierCutomersBtn.Checked = true;
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
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            LoginForm logf = new LoginForm();
            this.Hide();
            logf.Show();
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT Username FROM Cashier WHERE NIC=@nic", con);
                cmd.Parameters.AddWithValue("@nic", Program.User);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    profileName.Text = rd["Username"].ToString() + " (Cashier)";
                }
                rd.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                con.Close();
                
            }
        }



    }
}
